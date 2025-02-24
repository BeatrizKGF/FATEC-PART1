// Faça um programa para converter binário para decimal.
// OBS.: O USO DE VETORES OU QUALQUER BIBLIOTECA É PROIBIDO. UTILIZAR SOMENTE O QUE FOI VISTO EM SALA DE AULA.

Console.WriteLine("Digite um número binário");
string binario = Console.ReadLine();

int dec = 0;
int potencia = 0;

for (int i = binario.Length -1; i >= 0; i--)
{
    if (binario[i] == '1')
    {
        dec += (int)Math.Pow(2, potencia);
    }
    potencia++;
}

Console.WriteLine($"O número decimal do binário {binario} é {dec}");

Console.ReadKey();