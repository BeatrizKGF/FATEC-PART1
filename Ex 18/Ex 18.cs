//Faça um programa para calcular o MDC entre dois números positivos.

static int CalcularMDC(int a, int b)
{
    while (b != 0)
    {
        int resto = a % b;
        a = b;
        b = resto;
    }
    return a;
}

Console.WriteLine("Digite o primeiro número: ");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 > 0 && number2 > 0)
{
    int mdc = CalcularMDC(number1, number2);

    Console.WriteLine($"O MDC de {number1} e {number2} é {mdc}");
}
else
{
    Console.WriteLine("Os dois números devem ser positivos");
}

Console.ReadKey();