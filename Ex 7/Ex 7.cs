// Faça um programa que solicita que o usuário digite 10 valores.
// O programa deverá contar quantos valores estão dentro do intervalo ]10,157[ e quantos valores estão fora desse intervalo.

int i = 1; int y = 0; int x = 0;

while (i <= 10)
{
    Console.WriteLine($"Digite {i}º número: ");
    var choice = Console.ReadLine();
    int number = int.Parse(choice);

    if (number > 10 & number < 157)
    {
        y++;
    }
    else x++;

    i++;
}

Console.WriteLine($"Você digitou {y} números dento do intervalo e {x} números fora do intervalo");

Console.ReadKey ();