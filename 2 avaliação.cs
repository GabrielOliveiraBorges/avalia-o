using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma frase:");
        string frase = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(frase))
        {
            string[] palavras = frase.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            int numeroDePalavras = palavras.Length;

            Console.WriteLine($"A frase contém {numeroDePalavras} palavra(s).");
        }
        else
        {
            Console.WriteLine("A frase está vazia ou inválida.");
        }
    }
}

