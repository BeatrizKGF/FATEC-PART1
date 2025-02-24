// Faça um programa que mostra os números ímpares entre 18 e 347 em ordem crescente.

int num = 18;

while (num <= 347)
{
    if (num % 2 != 0)
    {
        Console.WriteLine(num);
    }
    num++;
}