using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a primeira característica:");
        string entrada1 = Console.ReadLine().ToLower();

        Console.WriteLine("Digite a segunda característica:");
        string entrada2 = Console.ReadLine().ToLower();

        Console.WriteLine("Digite a terceira característica:");
        string entrada3 = Console.ReadLine().ToLower();

        string animal = "";
        
    
        if (entrada1 == "vertebrado")
        {
            if (entrada2 == "ave")
            {
                if (entrada3 == "carnivoro")
                    animal = "aguia";
                else if (entrada3 == "onivoro")
                    animal = "pomba";
            }
            else if (entrada2 == "mamifero")
            {
                if (entrada3 == "onivoro")
                    animal = "homem";
                else if (entrada3 == "herbivoro")
                    animal = "vaca";
            }
        }
        }
        else if (entrada1 == "invertebrado")
        {
            if (entrada2 == "inseto")
            {
                if (entrada3 == "hematofago")
                    animal = "pulga";
                else if (entrada3 == "herbivoro")
                    animal = "lagarta";
            }
            else if (entrada2 == "anelideo")
            {
                if (entrada3 == "hematofago")
                    animal = "sanguessuga";
                else if (entrada3 == "onivoro")
                    animal = "minhoca";
            }
        }

     Console.WriteLine(animal.ToUpper());

    }
}