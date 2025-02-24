// Faça um programa para verificar se um número é par ou ímpar dentro de um intervalo solicitado pelo próprio usuário.

Console.WriteLine ("Digite o primeiro número: ");
var firstChoice = Console.ReadLine ();
int firstNumber = int.Parse (firstChoice);

Console.WriteLine ("Digite o segundo número: ");
var secondChoice = Console.ReadLine ();
int secondNumber = int.Parse (secondChoice);

int i = firstNumber;

while (i <= secondNumber)
{
    if (i % 2 == 0)
    {
        Console.WriteLine ($"{i} é par!");
    }
    else
    {
        Console.WriteLine ($"{i} é ímpar!");
    }
    i++;
}

Console.ReadKey ();