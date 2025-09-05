
using System.Security.Cryptography.X509Certificates;

namespace treino;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\n\n-------------LOGIN-------------\n\n");

        //solicitar o nome do usuário
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();
        if (string.IsNullOrEmpty(nome))
        {
            Console.WriteLine("Nome inválido. Por favor, tente novamente.");
            return;
        }
        else
        {
            Console.WriteLine($"\nBem-vindo, {nome}!");
        }

        //solicitar a idade do usuário
        Console.Write("\nDigite sua idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());
        if (idade < 18)
        {
            Console.WriteLine("\n-----------ACESSO NEGADO-----------");
            Console.WriteLine($"{nome}, Você é menor de idade.\n");
        }
        else
        {
            Console.WriteLine("\n-----------ACESSO PERMITIDO-----------");
            Console.WriteLine($"{nome}, Você é maior de idade.\n");
        }
        
    }
}