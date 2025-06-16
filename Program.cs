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

Console.Write("Operaciones aceptadas:");
Console.Write("\x1b[1m + - * /\x1b[0m\n");
Console.Write(" └┬ Ingrese la operacion que desea hacer: ");
string inputOp = Console.ReadLine();
bool calcular = true;
int num1, num2;
while (calcular)
{
    bool rightOp = !inputOp.Equals("*") || !inputOp.Equals("/") || !inputOp.Equals("-") || !inputOp.Equals("+");
    while (!rightOp)
    {
        Console.Write(" └┬ Operacion Erronea, ingrese una operacion valida:  ");
        inputOp = Console.ReadLine();
        rightOp = !inputOp.Equals("*") || !inputOp.Equals("/") || !inputOp.Equals("-") || !inputOp.Equals("+");
    }

    if (inputOp == "*" || inputOp == "/" || inputOp == "-" || inputOp == "+")
    {
        Console.Write("  └┬ Ingrese el primer operando: ");
        string inputNum1 = Console.ReadLine();
        bool isInputNum1Ok = int.TryParse(inputNum1, out num1);
        if (!isInputNum1Ok)
        {
            while (!isInputNum1Ok)
            {
                Console.Write("  └┬ Error, ingrese un numero valido: ");
                inputNum1 = Console.ReadLine();
                isInputNum1Ok = int.TryParse(inputNum1, out num1);
            }
        }
        Console.Write("   ├ Ingrese el segundo operando: ");
        string inputNum2 = Console.ReadLine();
        bool isInputNum2Ok = int.TryParse(inputNum2, out num2);
        if (!isInputNum2Ok)
        {
            while (!isInputNum2Ok)
            {
                Console.Write("  └┬ Error, ingrese un numero valido: ");
                inputNum2 = Console.ReadLine();
                isInputNum2Ok = int.TryParse(inputNum2, out num2);
            }
        }
        float resultado;
        switch (inputOp)
        {
            case "+":
                resultado = num1 + num2;
                break;
            case "-":
                resultado = num1 - num2;
                break;
            case "*":
                resultado = num1 * num2;
                break;
            case "/":
                resultado = num1 / num2;
                break;
            default:
                resultado = 0;
                break;
        }
        Console.WriteLine($"   └ El resultado de la operacion es: {resultado}");
        Console.Write("¿Quiere seguir realizando calculos? (Y/N): ");
        string buff = Console.ReadLine();
        calcular = buff.ToUpper().Equals("Y");
        Console.Write(" └┬ Ingrese la operacion que desea hacer: ");
        inputOp = Console.ReadLine();
    }
}