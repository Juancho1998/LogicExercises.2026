using Shared;
var answer = string.Empty;
var options = new List<string> { "s", "n" };
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
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("Game Over.");
