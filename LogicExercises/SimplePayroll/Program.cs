using Shared;
var answer = string.Empty;
var options = new List<string> { "s", "n" };
do
{

    var name = ConsoleExtension.GetString("Ingrese el nombre: ");
    var workHours = ConsoleExtension.GetFloat("Ingrese número de horas trabajadas: ");
    var hourPrice = ConsoleExtension.GetDecimal("Ingrese el valor de la hora: ");
    var salaryMinimun = ConsoleExtension.GetDecimal("Ingrese el valor del salario mínimo mensual: ");

    var salary = (decimal)workHours * hourPrice;

    if (salary > salaryMinimun)
    {
        Console.WriteLine($"Nombre: {name}");
        Console.WriteLine($"Salario mensual: {salary:C2}");
    }
    else
    {
        Console.WriteLine($"Nombre: {name}");
        Console.WriteLine($"Salario mínimo mensual: {salaryMinimun:C2}");
    }
    
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("Game Over.");