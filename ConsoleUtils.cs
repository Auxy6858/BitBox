namespace BitBox;

public static class ConsoleUtils
{
    public static string? Input(string? value) 
    {
        Console.Write(value);
        return Console.ReadLine();
    }

    public static string? InputLine(string? value)
    {
        Console.WriteLine(value);
        return Console.ReadLine();
    }
}

