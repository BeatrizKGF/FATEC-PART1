// Faça um programa que verifica quais são os divisores de um número. Por exemplo, ao digitar os números abaixo, o programa deverá imprimir:
// • 48: 1,2,3,4,6,8,12,16,24,48
// • 3: 1,3
// • 726: 1,2,3,6,11,22,33,66,121,242,363,726

Console.WriteLine("Digite um número para saber seus divisores: ");
var choice = Console.ReadLine();
int number = int.Parse(choice);

List<int> divisores = new List<int>();

for (int divisor = 1; divisor <= number; divisor++)
{
    if (number % divisor == 0)
    {
        divisores.Add(divisor);
    }
}

Console.WriteLine($"{number}: {string.Join(",", divisores)}");

Console.ReadKey();