using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };
do
{
    var a = ConsoleExtension.GetInt("Ingrese el primer número: ");
    var b = ConsoleExtension.GetInt("Ingrese el segundo número: ");
    var c = ConsoleExtension.GetInt("Ingrese el tercer número: ");

    if (a > b && a > c)
    {
        Console.WriteLine($"El número mayor es el: {a}");
    }
    else if (b>a && b>c)
    {
        Console.WriteLine($"El número mayor es el: {b}");
    }
    else
    {
        Console.WriteLine($"El número mayor es el: {c}");
    }

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("Game Over.");
