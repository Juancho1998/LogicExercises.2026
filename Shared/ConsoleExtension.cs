namespace Shared;

public static class ConsoleExtension
{
    public static int GetInt(string message)
    {
        Console.Write(message);
        var numberString = Console.ReadLine();
        if (int.TryParse(numberString, out numberInt))
        {
            return numberInt;
        }
        return 0;
    }
}
