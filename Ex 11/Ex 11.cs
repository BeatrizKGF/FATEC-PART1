// Faça um programa que calcula a tabuada de um número (1 ao 10).
// Exemplo: é solicitado ao usuário que digite um valor, por exemplo 6, o valor retornado é a tabuada do número 6 (1 ao 10).

Console.WriteLine("Digite um número: ");
int number = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{number} x {i} = {number * i}");
}

Console.ReadKey();
