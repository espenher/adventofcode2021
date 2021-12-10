public class dag3
{
    public static string submarine()
    {
        var lines = FileReader.ReadFile("inputs/dag3test.txt");

        var gammaList = new List<List<char>>();

        var column = -1;

        foreach(var line in lines)
        {
            column++;
            var pos1 = new List<char>();
            pos1.Add(line[column]);
            gammaList.Add(pos1);
        }
        Console.WriteLine(gammaList[0]);

        return "";
    }
}