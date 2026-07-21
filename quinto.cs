using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("ficheiro: ");
        string file = Console.ReadLine();

        Console.Write("carácter a procurar: ");
        char chr = Console.ReadLine()[0];

        try
        {
            string content = File.ReadAllText(file);

            int count = 0;

            foreach (char c in content)
            {
                if (c == chr)
                {
                    count++;
                }
            }

            Console.WriteLine($"o caracter {chr} aparece {count} vezes no ficheiro.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("ficheiro não encontrado");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"erro: {ex.Message}");
        }
    }
}
