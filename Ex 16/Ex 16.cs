// Faça um programa que solicita que o usuário digite qualquer valor positivo X. O programa deverá exibir:
// • A soma dos primeiros números pares (iniciando do número 1):
// • A soma dos primeiros números ímpares (iniciando do número 1):
// • A diferença(soma pares - soma ímpares)
// • Dizer se o resultado da diferença é um número primo ou não.

bool isPrimo (int n)
{
    if (n <= 1)
        return false;

    for (int i = 2; i <= Math.Sqrt(n); i++)
    {
        if (n % i == 0)
        {
            return false;
        }
    }
    return true;
}

Console.WriteLine("Digite um número positivo: ");
int number = int.Parse(Console.ReadLine());
int somaPar = 0;
int somaImpar = 0; 

if (number > 0)
{
    for (int i = 1; i <= number; i++)
    {
        if (i % 2 == 0)
        {
            somaPar += i;
        }
        else
        {
            somaImpar += i;
        }
    }
}
else Console.WriteLine("Escreva um número positivo");

int dif = somaPar - somaImpar;

Console.WriteLine($"A soma de todos os números pares é {somaPar}");

Console.WriteLine($"A soma de todos os números ímpares é {somaImpar}");

Console.WriteLine($"A diferença de números pares e ímpares é {dif}");

if (isPrimo(dif))
{
    Console.WriteLine("O número é primo");
}
else Console.WriteLine("O número não é primo");

Console.ReadKey();