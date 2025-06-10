Console.WriteLine("Hello, World!");
int a;
int b;
a = 10;
b = a;
Console.WriteLine("valor de a:" + a);
Console.WriteLine("valor de b:" + b);

Console.Write("Ingrese un numero: ");
string input = Console.ReadLine();
int number;
if (int.TryParse(input, out number))
{
    Console.WriteLine(number);
    if (number > 0)
    {
        Console.Write("El inverso del numero ingresado es: {0:N9}", Decimal.Divide(1, number));
    }
    else
    {
        Console.WriteLine("La division por cero no esta definida.");
    }
}
