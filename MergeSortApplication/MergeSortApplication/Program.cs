
// setup 
List<int> list;
List<int> listMergeSort;
List<int> listPLINQMergeSort;
DataAccessInMemory dataAccessInMemory = new();
Sort sort = new();
Stopwatch watch = new();

// get data
list = dataAccessInMemory.List;
listMergeSort = list;
listPLINQMergeSort = list;

// view unsorted list
ConsoleLog.PrintList(list, "Unsorted");

// recursive merge sort list - sequential version
watch.Start();
listMergeSort = sort.MergeSort(listMergeSort);
watch.Stop();
ConsoleLog.PrintWatch(watch, "Squential");

// view sorted list
ConsoleLog.PrintList(listMergeSort, "Sorted");

watch.Reset();

// recursive merge sort list - PLINQ version
watch.Start();
listPLINQMergeSort = sort.PLINQMergeSort(listPLINQMergeSort);
watch.Stop();
ConsoleLog.PrintWatch(watch, "PLINQ");

// view sorted list
ConsoleLog.PrintList(listPLINQMergeSort, "Sorted");


