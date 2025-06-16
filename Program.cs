Console.WriteLine("Hello, World!");
int a;
int b;
a = 10;
b = a;
Console.WriteLine("valor de a:" + a);
Console.WriteLine("valor de b:" + b);
// Reinterpretacion de lo propuesto en el ejercicio 4 para simplificar el desarrollo
int resultado = a + b;
Console.WriteLine($"Forma 1: La suma de {a} y {b} es igual a {resultado}");
Console.WriteLine("Forma 2: La suma de " + a.ToString() + " y " + b.ToString() + " es igual a" + resultado.ToString());
Console.Write("Ingrese un numero: ");
string input = Console.ReadLine();
int number;
if (int.TryParse(input, out number))
{
    Console.WriteLine(number);
    if (number > 0)
    {
        Console.WriteLine("El inverso del numero ingresado es: {0:N9}", Decimal.Divide(1, number));
    }
    else
    {
        Console.WriteLine("La division por cero no esta definida.");
    }
}


// Ejercicio 4

Console.Write("Ingresa una cadena de texto: ");
string cadena = Console.ReadLine();
Console.WriteLine($"Longitud de {cadena}: {cadena.Length}");
Console.Write("Ingrese otra cadena de texto: ");
string cadena2 = Console.ReadLine();
Console.WriteLine($"La concatenacion de ambas cadenas es: {string.Concat(cadena, cadena2)}");
string subCadenaDeC1 = cadena.Substring(cadena.Length / 2);
Console.WriteLine($"Subcadena que comienza a partir del indice {cadena.Length / 2}: {subCadenaDeC1}");
Console.WriteLine("Recorrido de cadena con foreach: ");
foreach (char letra in cadena)
{
    Console.Write(letra);
}
Console.WriteLine();
Console.WriteLine($"Contiene la letra \'a\' la cadena: {cadena.Contains('h')}");
Console.WriteLine($"ALL mayusculas: {cadena.ToUpper()}");
Console.WriteLine($"ALL minusculas: {cadena.ToLower()}");
string separada = "Soy una cadena totalmente separada por espacios, es re loco, no lo puedo creer, mira cuantos espacios hay en mi!";
string[] arrSep = separada.Split(" ");
Console.WriteLine("Hay una cadena interna que es muy especial porque esta separada, apliquemosle split() en base a sus espacios!");
foreach (string palabra in arrSep)
{
    Console.WriteLine(palabra);
}

string operacionR = "111+555";
string[] oRS;
int resultadoOR = 0, num1, num2;
// If statements para dar y regalar aunque la cadena ya venga predefinida
if (operacionR.Contains('+'))
{
    oRS = operacionR.Split("+");
    int.TryParse(oRS[0], out num1);
    int.TryParse(oRS[1], out num2);
    resultadoOR = num1 + num2;
}
if (operacionR.Contains('-'))
{
    oRS = operacionR.Split("-");
    int.TryParse(oRS[0], out num1);
    int.TryParse(oRS[1], out num2);
    resultadoOR = num1 - num2;

}
if (operacionR.Contains('*'))
{
    oRS = operacionR.Split("*");
    int.TryParse(oRS[0], out num1);
    int.TryParse(oRS[1], out num2);
    resultadoOR = num1 * num2;

}
if (operacionR.Contains('/'))
{
    oRS = operacionR.Split("/");
    int.TryParse(oRS[0], out num1);
    int.TryParse(oRS[1], out num2);
    if (num2 != 0)
    {
        resultadoOR = num1 / num2;
    }
    else
    {
        Console.WriteLine("La division por cero no esta definida bro!");
    }
}

Console.WriteLine($"Se hizo una cuenta de la que vos como usuario no tenias idea, este es su resultado: {resultadoOR}");
Console.WriteLine("COMOOO????, el DIABLO! \U0001f608 \U0001f608 \U0001f608");