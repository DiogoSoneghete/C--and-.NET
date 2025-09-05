
using System.Security.Cryptography.X509Certificates;

namespace treino;

public class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("\n\n-- Calculadora Simples --\n\n");
        Console.WriteLine("Digite o primeiro número: ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o segundo número: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        int som = n1 + n2;
        int sub = n1 - n2;
        int mult = n1 * n2;
        int div = n1 / n2;
        int module = n1 % n2;

        Console.WriteLine("O resultado da soma é: " + som);
        Console.WriteLine("O resultado da subtração é: " + sub);
        Console.WriteLine("O resultado da multiplicação é: " + mult);
        Console.WriteLine("O resultado da divisão é: " + div);
        Console.WriteLine("O resultado do resto da divisão é: " + module + "\n\n");
    
    
        
    }
}