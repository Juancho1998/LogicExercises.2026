using Shared;

do
{
    Console.WriteLine("Ingrese 2 números: ");
    var a = ConsoleExtension.GetInt("Ingrese el primer número: ");
    var b = ConsoleExtension.GetInt("Ingrese el segundo número: ");

    if (a % b == 0)
    {
        Console.WriteLine($"El número: {b}, es múltiplo del: {a}");
    }
    else
    {
        Console.WriteLine($"El número: {b}, no es múltiplo del: {a}");
    }
} while (true);