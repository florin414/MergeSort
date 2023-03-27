namespace MergeSortApplication;
internal static class ConsoleLog
{

    public static void PrintList(List<int> list, string typeList)
    {
        Console.WriteLine($"\n ----- {typeList} ----- \n");
        foreach (int x in list)
        {
            Console.Write(x + " ");
        }
        Console.Write("\n");
    }

    public static void PrintWatch(Stopwatch watch, string typeSort)
    {
        var oldColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Blue;

        Console.WriteLine($"\n{typeSort} version: {watch.ElapsedMilliseconds} Milliseconds");
        Console.WriteLine($"{typeSort} version: {watch.ElapsedTicks} Ticks\n");

        Console.ForegroundColor = oldColor;
    }
}
