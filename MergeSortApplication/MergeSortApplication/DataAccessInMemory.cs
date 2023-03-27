namespace MergeSortApplication;

internal class DataAccessInMemory
{
    public List<int> List { get; set; } = new();

    public DataAccessInMemory()
    {
        string path = "Resources\\data.txt"; // 1000 values

        using StreamReader streamReader = new(new FileStream(path, FileMode.Open, FileAccess.Read));

        while (streamReader.Peek() > -1)
        {
            int value = int.Parse(streamReader.ReadLine() ?? "0");
            List.Add(value);
        }
    }
}
