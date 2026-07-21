using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("primeiro ficheiro: ");
        string ficheiro1 = Console.ReadLine();

        Console.Write("segundo ficheiro: ");
        string ficheiro2 = Console.ReadLine();

        Console.Write("ficheiro de destino: ");
        string ficheiroD = Console.ReadLine();

        try
        {
            string content1 = File.ReadAllText(ficheiro1);
            string content2 = File.ReadAllText(ficheiro2);


            using (StreamWriter sw = new StreamWriter(ficheiroD))
            {
                sw.Write(content1);
                sw.Write(content2);
            }

            Console.WriteLine("ficheiro criado");
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"ficheiro n encontrado - {ex.FileName}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"erro: {ex.Message}");
        }
    }
}
