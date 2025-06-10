using System.Runtime.InteropServices;

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