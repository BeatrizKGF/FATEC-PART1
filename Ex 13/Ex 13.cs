// Faça um programa que solicita que o usuário digite 10 valores.
// Ao final dos valores digitados o programa deverá mostrar na tela qual foi o maior valor digitado.

int bigNumber = int.MinValue;
int number;

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Digite o {i}º número: ");
    number = int.Parse( Console.ReadLine() );

    if (number > bigNumber)
    {
        bigNumber = number;
    }
}

Console.WriteLine($"O maior número digitado foi {bigNumber}");

Console.ReadKey();