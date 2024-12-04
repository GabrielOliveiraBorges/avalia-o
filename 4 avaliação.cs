using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a primeira data (no formato dd/MM/yyyy):");
        string entrada1 = Console.ReadLine();

        Console.WriteLine("Digite a segunda data (no formato dd/MM/yyyy):");
        string entrada2 = Console.ReadLine();

        try
        {
            DateTime data1 = DateTime.ParseExact(entrada1, "dd/MM/yyyy", null);
            DateTime data2 = DateTime.ParseExact(entrada2, "dd/MM/yyyy", null);

            TimeSpan diferenca = data2 - data1;
            int dias = Math.Abs(diferenca.Days);
            
            Console.WriteLine($"A diferença entre as datas é de {dias} dia(s).");
        }
        catch (FormatException)
        {
            Console.WriteLine("Uma ou ambas as datas inseridas são inválidas. Certifique-se de usar o formato dd/MM/yyyy.");
        }
    }
}
