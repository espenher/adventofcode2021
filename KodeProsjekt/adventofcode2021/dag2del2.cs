public class dag2
{
    public static int Submarine()
    {
        var lines = FileReader.ReadFile("inputs/dag2.txt");
        var horizontalPos = 0;
        var depth = 0;
        foreach (var line in lines)
        {
            var splits = line.Split(' ');
            if (line.Contains("forward"))
            {
                int.TryParse(splits[1], out var value);
                horizontalPos += value;
            }

            if (line.Contains("down"))
            {
                int.TryParse(splits[1], out var maxDown);
                depth += maxDown;
            }

            if (line.Contains("up"))
            {
                int.TryParse(splits[1], out var maxUp);
                depth -= maxUp;
            }
        }

        var result = depth * horizontalPos;
        Console.WriteLine(horizontalPos);
        Console.WriteLine(depth);
        Console.WriteLine(result);
        return result;
    }

    public static int SubAim()
    {


        return 0;
    }
}

