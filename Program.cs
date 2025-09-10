
using System.Security.Cryptography.X509Certificates;

namespace treino;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Olá, Digite seu nome: ");
        string nome = Console.ReadLine() ?? string.Empty;
        Console.WriteLine($"Olá {nome}! Seja bem vindo ao nosso sistema!");
        Console.Write("Digite uma senha (8 caracteres): ");
        string senha = Console.ReadLine() ?? string.Empty;
        if (senha.Length != 8)
        {
            Console.WriteLine("\nSenha inválida! A senha deve conter exatamente 8 caracteres.\nTente novamente.");
            return;
        }
        Console.Write("Confirme sua senha( 8 caracteres): ");
        string confirmaSenha = Console.ReadLine() ?? string.Empty;
        if (senha == confirmaSenha)
        {
            Console.WriteLine("Senha confirmada com sucesso!");
            Console.WriteLine($"Bem vindo ao sistema {nome} !");
        }
        else
        {
            Console.WriteLine("As senhas não coincidem.\nTente novamente.");
        }
    }
}