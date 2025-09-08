
using System.Security.Cryptography.X509Certificates;

namespace treino;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\n\n-----Verificar Impar ou Par-----\n\n");

        Console.Write("Digite um número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine($"O número {numero} é par\n\n");
        }
        else
        {
            Console.WriteLine($"O número {numero} é ímpar\n\n");
        }
        if(numero < 0)
        {
            Console.WriteLine($"O número {numero} é negativo\n\n");
        }
        else if (numero > 0)
        {
            Console.WriteLine($"O número {numero} é positivo\n\n");
        }
        else
        {
            Console.WriteLine($"O número {numero} é neutro\n\n");
        }
    }
}