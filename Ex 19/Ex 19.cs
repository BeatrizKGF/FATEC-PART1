// Faça um programa que solicita que o usuário digite um conjunto de valores positivos até que um certo número negativo seja digitado.
// Ao final, o programa deverá calcular a média dos valores digitados e verificar se esse valor é um número primo ou não.

using System.Globalization;

List<int> numbers = new List<int>();

bool IsPrimo (int a)
{
    if (a <= 1)
        return false;

    for (int i = 2; i <= Math.Sqrt (a); i++)
    {
        if (a % i == 0)
        {
            return false;
        }
    }
    return true;
}

int CalcMedia(List<int> a)
{
    int soma = 0;

    for (int i = 0; i < a.Count; i++)
    {
        soma += a[i];
    }
    return soma / a.Count;
}

Console.WriteLine("Digite um número: (digite um número negativo para encerrar)");
int number = int.Parse(Console.ReadLine());

while (number > 0)
{
    numbers.Add(number);
    Console.WriteLine("Digite o próximo número: (digite um número negativo para encerrar)");
    number = int.Parse(Console.ReadLine());
}

int media = CalcMedia(numbers);

Console.WriteLine(media);

if (IsPrimo(media))
{
    Console.WriteLine("A média dos número digitados é um número primo."); 
}
else Console.WriteLine("A média dos números digitados não é um número primo.");

Console.ReadKey();