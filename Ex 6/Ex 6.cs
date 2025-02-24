// Fazer um programa para exibir os números múltiplos de 11 entre 1 e 100 em ordem decrescente.

int i = 1;

while (i <= 100)
{
    if (i % 11 == 0)
    {
        Console.WriteLine(i);
    }
    i++;
}