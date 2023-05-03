using BenchmarkDotNet.Attributes;

namespace MergeSortApplication;

[MemoryDiagnoser(true)]
public class DiagnoserSort
{
    [Params(1000)]
    public int Size { get; set; }
    private List<int> _list;
    private Sort _sort;

    [GlobalSetup]
    public void Setup()
    {
        var list = new DataAccessInMemory().List;
        _list = list;
        _sort= new Sort();
    }

    [Benchmark]
    public List<int> PLINQMergeSort() => _sort.PLINQMergeSort(_list);

    [Benchmark]
    public List<int> MergeSort() => _sort.MergeSort(_list);

    [Benchmark]
    public List<int> TaskParallelMergeSort() => _sort.TaskParallelMergeSort(_list);
}
