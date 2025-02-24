// Faça um programa que leia 15 números inteiros via teclado. O programa deverá:
// a.Imprimir para cada verificação se o valor lido é par ou ímpar.
// b.Informar quantos valores lidos são pares;
// c.Informar quantos valores lidos são ímpares;
// d.Informar se maior quantidade de valores lidos é par ou ímpar.

int contImpar = 0;
int contPar = 0;

for (int i = 1; i <= 15; i++)
{
    Console.WriteLine($"Digite o {i}º número: ");
    var choice = Console.ReadLine();
    int number = int.Parse(choice);

    if (number % 2 == 0)
    {
        Console.WriteLine("O número que você digitou é par");
        contPar++;
    }
    else
    {
        Console.WriteLine("O número que você digitou é ímpar"); 
        contImpar++;
    }
}

Console.WriteLine($"O número total de números pares foi {contPar} e o número total de números ímpares foi {contImpar}.");

if (contPar > contImpar)
{
    Console.WriteLine("A maioria dos números é par");
}
else Console.WriteLine("A maioria dos números lidos é ímpar");

Console.ReadKey();