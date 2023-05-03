bool testEenvironment = true;

if (testEenvironment)
{
    BenchmarkRunner.Run<DiagnoserSort>();
}
else
{
    // setup 
    List<int> list;
    List<int> listMergeSort;
    List<int> listPLINQMergeSort;
    List<int> listTaskParallel;
    DataAccessInMemory dataAccessInMemory = new();
    Sort sort = new();
    Stopwatch watch = new();

    // get data
    list = dataAccessInMemory.List;
    listMergeSort = list;
    listPLINQMergeSort = list;
    listTaskParallel = list;

    // view unsorted list
    ConsoleLog.PrintList(list, "Unsorted");

    // merge sort list - sequential version
    watch.Start();
    listMergeSort = sort.MergeSort(listMergeSort);
    watch.Stop();
    ConsoleLog.PrintWatch(watch, "Squential");

    // view sorted list
    ConsoleLog.PrintList(listMergeSort, "Sorted");

    watch.Reset();

    // merge sort list - PLINQ version
    watch.Start();
    listPLINQMergeSort = sort.PLINQMergeSort(listPLINQMergeSort);
    watch.Stop();
    ConsoleLog.PrintWatch(watch, "PLINQ");

    // view sorted list
    ConsoleLog.PrintList(listPLINQMergeSort, "Sorted");

    watch.Reset();


    // merge sort list - task parallel version
    watch.Start();
    listTaskParallel = sort.TaskParallelMergeSort(listTaskParallel);
    watch.Stop();
    ConsoleLog.PrintWatch(watch, "TaskParallel");

    // view sorted list
    ConsoleLog.PrintList(listTaskParallel, "Sorted");

}





