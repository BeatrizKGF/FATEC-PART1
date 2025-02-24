// Faça um programa que solicita que o usuário digite 10 valores.
// Ao final dos valores digitados o programa deverá mostrar na tela qual foi o menor valor digitado e
// qual maior valor digitado, assim como o valor do resto da divisão do menor valor pelo maior valor.

int bigNumber = int.MinValue;
int smallNumber = int.MaxValue;
int number;

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Digite o {i} número: ");
    number = int.Parse(Console.ReadLine());

    if (number > bigNumber)
    {
        bigNumber = number;
    }
    if (number < smallNumber)
    {
        smallNumber = number;
    }
}

Console.WriteLine($"O maior valor digitado foi {bigNumber}");
Console.WriteLine($"O menor valor digitado foi {smallNumber}");
Console.WriteLine($"O resto da divisão do maior número pelo menor número é {bigNumber % smallNumber}");

Console.ReadKey();