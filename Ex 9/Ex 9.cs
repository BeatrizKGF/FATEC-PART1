// Faça um programa que solicita que o usuário digite valores positivos (> 0) na tela até que o usuário digite um valor negativo.
// Ao final o programa deverá imprimir a soma dos valores digitados.

int soma = 0;
Console.WriteLine("Digite números positivos para serem somados. Coloque um número negativo para terminar a operação");
var choice = Console.ReadLine();
int number = int.Parse(choice);

while (number > 0)
{
    soma += number;
    Console.WriteLine("Digite outro número. Coloque um número negativo para terminar a operação");
    choice = Console.ReadLine();
    number = int.Parse(choice);
}

Console.WriteLine($"A soma dos números é {soma}");

Console.ReadKey();