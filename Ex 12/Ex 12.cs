// Faça um programa que calcula o fatorial de um número sabendo que:
// Fórmula geral: n(n-1)

Console.WriteLine("Digite um número: ");
int number = int.Parse(Console.ReadLine());
int fator = 1;

for (int i = 1; i <= number; i++)
{
    fator *= i;
}

Console.WriteLine($"O fatorial de {number} é {fator}");