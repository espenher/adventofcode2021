

public static class FileReader
{
    public static List<string> ReadFile(string path)
    {
        var lines = File.ReadAllLines(path).ToList();

        return lines;
    }
}
