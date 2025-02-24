// Faça um programa que solicita que o usuário digite um conjunto de valores positivos até que um certo número negativo seja digitado.
// Ao final o programa deverá verificar se os valores digitados estão em:
// • Ordem crescente;
// • Ordem decrescente;
// • Nenhuma ordem.

List<int> numbers = new List<int>();

Console.WriteLine("Digite um número positivo para continuar: (digite um número negativo para terminar)");
int number = int.Parse(Console.ReadLine());

while (true)
{
    Console.WriteLine("Digite outro número: (digite um número negativo para terminar)");
    number = int.Parse(Console.ReadLine());

    if (number < 0)
    {
        break;
    }

    numbers.Add(number);
}

if (numbers.Count < 2)
{
    Console.WriteLine("Não existem números suficientes para verificar a ordem");
}

bool crescente = true;
bool decrescente = true;

for (int i = 0; i < numbers.Count - 1; i++)
{
    if (numbers[i] < numbers[i + 1])
    {
        decrescente = false;
    }
    else if (numbers[i] > numbers[i + 1])
    {
        crescente = false;
    }
}

if (crescente)
{
    Console.WriteLine("Os números digitados estão em ordem crescente.");
}
else if (decrescente)
{
    Console.WriteLine("Os números estão em ordem decrescente.");
}
else
{
    Console.WriteLine("Os números não estão em nenhuma ordem");
}

Console.ReadKey();