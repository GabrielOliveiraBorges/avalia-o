using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a idade em dias:");
        int totalDias = int.Parse(Console.ReadLine());

        int anos = totalDias / 365;
        int restante = totalDias % 365;
        int meses = restante / 30;
        int dias = restante % 30;

        Console.WriteLine($"{anos} ano(s)");
        Console.WriteLine($"{meses} mes(es)");
        Console.WriteLine($"{dias} dia(s)");
    }
}
