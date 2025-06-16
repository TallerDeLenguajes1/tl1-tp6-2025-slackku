using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;

Console.Write("Ingrese un numero: ");
string input = Console.ReadLine();
float number;
while (!float.TryParse(input, out number))
{
    Console.Write("Ingrese un numero valido: ");
    input = Console.ReadLine();
}

Console.WriteLine($"|{number}| = {Math.Abs(number)}");
Console.WriteLine($"{number}² = {number * number}");
if (number < 0)
{
    Console.WriteLine($"sqrt({number}) no esta definido");
}
else
{
    Console.WriteLine($"sqrt({number}) = {Math.Sqrt(number)}");
}
Console.WriteLine($"sin({number}) = {Math.Sin(number)}");
Console.WriteLine($"cos({number}) = {Math.Cos(number)}");
Console.WriteLine($"Floor({number}) = {Math.Floor(number)}");

float number2, number3;

Console.Write("Ingrese otro numero: ");
input = Console.ReadLine();

while (!float.TryParse(input, out number2))
{
    Console.Write("Ingrese un numero valido: ");
    input = Console.ReadLine();
}
Console.Write("Ingrese otro numero: ");
string input2 = Console.ReadLine();

while (!float.TryParse(input2, out number3))
{
    Console.Write("Ingrese un numero valido: ");
    input2 = Console.ReadLine();
}

Console.WriteLine($"max({number2},{number3}) = {Math.Max(number2, number3)}");
Console.WriteLine($"min({number2},{number3}) = {Math.Min(number2, number3)}");
