
using System.Security.Cryptography.X509Certificates;

namespace treino;

public class Program
{
    public static void Main(string[] args)
    {
        string nome = "Windows";
        Console.WriteLine($"Olá, {nome}!");

        int idade = 25;
        Console.WriteLine($"Você tem {idade} anos de idade.");

        float altura = 1.75f;
        Console.WriteLine($"Sua altura é de {altura} metros.");

        char genero = 'M';
        Console.WriteLine($"Seu gênero é {genero}.");

        bool estaCasado = true;
        if (estaCasado)
        {
            Console.WriteLine("Você está casado.");
        }
        else
        {
            Console.WriteLine("Você não está casado.");
        }

        dynamic variavel = 42;
        Console.WriteLine($"\nA variável dinâmica é {variavel}.");
        variavel = "Uma string!";
        Console.WriteLine($"A variável dinâmica agora é {variavel}.");
        variavel = 3.14f;
        Console.WriteLine($"A variável dinâmica agora é {variavel}.");

        var numero = 100;
        Console.WriteLine($"\nO número é {numero}.");
        numero = 200;
        Console.WriteLine($"O número agora é {numero}.");
    }
}