﻿namespace MergeSortApplication;
internal class Sort
{
    public Sort()
    {

    }

    public List<int> PLINQMergeSort(List<int> list)
    {
        if (list.Count <= 1)
            return list;

        int mid = list.Count / 2;

        var left = list.Take(mid).ToList();
        var right = list.Skip(mid).ToList();

        // Sortează cele două jumătăți în paralel folosind PLINQ
        var sortedLeft = left.AsParallel().WithDegreeOfParallelism(Environment.ProcessorCount)
            .OrderBy(x => x).ToList();
        var sortedRight = right.AsParallel().WithDegreeOfParallelism(Environment.ProcessorCount)
            .OrderBy(x => x).ToList();

        // Unește cele două jumătăți sortate
        return PLINQMerge(sortedLeft, sortedRight);
    }

    private List<int> PLINQMerge(List<int> left, List<int> right)
    {
        var result = new List<int>(left.Count + right.Count);

        int i = 0, j = 0;

        // Îmbină cele două jumătăți sortate în paralel folosind PLINQ
        var merged = left.Concat(right).AsParallel().WithDegreeOfParallelism(Environment.ProcessorCount)
            .OrderBy(x => x).ToList();

        return merged;
    }

    public List<int> MergeSort(List<int> unsorted)
    {
        if (unsorted.Count <= 1)
            return unsorted;

        List<int> left = new();
        List<int> right = new();

        int middle = unsorted.Count / 2;
        for (int i = 0; i < middle; i++)  //Dividing the unsorted list
        {
            left.Add(unsorted[i]);
        }
        for (int i = middle; i < unsorted.Count; i++)
        {
            right.Add(unsorted[i]);
        }

        left = MergeSort(left);
        right = MergeSort(right);
        return Merge(left, right);
    }

    private List<int> Merge(List<int> left, List<int> right)
    {
        List<int> result = new();

        while (left.Count > 0 || right.Count > 0)
        {
            if (left.Count > 0 && right.Count > 0)
            {
                if (left.First() <= right.First())  //Comparing First two elements to see which is smaller
                {
                    result.Add(left.First());
                    left.Remove(left.First());      //Rest of the list minus the first element
                }
                else
                {
                    result.Add(right.First());
                    right.Remove(right.First());
                }
            }
            else if (left.Count > 0)
            {
                result.Add(left.First());
                left.Remove(left.First());
            }
            else if (right.Count > 0)
            {
                result.Add(right.First());

                right.Remove(right.First());
            }
        }
        return result;
    }


}