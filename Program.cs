using static System.Console;

public class Idade
{
    public static void Main()
    {
        WriteLine("Qual Sua Idade ? :");
        if (!int.TryParse(ReadLine(), out var n1)) return;
        else if (n1 < 10) WriteLine("Você é Criança");
        else if (n1 < 18) WriteLine("Você é Adolescente");
        else WriteLine("Você é Adulto");
    }
}