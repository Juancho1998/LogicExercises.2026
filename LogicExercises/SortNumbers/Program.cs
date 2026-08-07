using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };
do
{
    Console.WriteLine("Ingrese tres números diferentes...");
    var a = ConsoleExtension.GetInt("Ingrese el primer número: ");
    var b = ConsoleExtension.GetInt("Ingrese el segundo número: ");
    if (a == b)
    {
        Console.WriteLine("Deben ser diferentes, vuelve a empezar");
        continue;
    }
   
    var c = ConsoleExtension.GetInt("Ingrese el tercer número: ");
    if (b == c || c == a)
    {
        Console.WriteLine("Deben ser diferentes, vuelve a empezar");
        continue;
    }
    if (a > b && a > c)
    {
        if(b > c)
        {
            Console.WriteLine($"El número mayor es: {a}, El número del medio es: {b}, El número menor es: {c}");
        }
        else
        {
            Console.WriteLine($"El número mayor es: {a}, El número del medio es: {c}, El número menor es: {b}");
        }
    }
    else if (b > a && b > c)
    {
        if (a > c)
        {
            Console.WriteLine($"El número mayor es: {b}, El número del medio es: {a}, El número menor es: {c}");
        }
        else
        {
            Console.WriteLine($"El número mayor es: {b}, El número del medio es: {a}, El número menor es: {c}");
        }
    }
    else
    {
        if (a > b)
        {
            Console.WriteLine($"El número mayor es: {c}, El número del medio es: {a}, El número menor es: {b}");
        }
        else
        {
            Console.WriteLine($"El número mayor es: {c}, El número del medio es: {b}, El número menor es: {a}");
        }
    }
    
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("Game Over.");
