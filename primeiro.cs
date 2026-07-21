using System;
using System.IO;

class Program
{
    static void Main()
    {
        string f1 = "C:\\Users\\monte\\Desktop\\ficheiro1.txt";
        string f2 = "C:\\Users\\monte\\Desktop\\ficheiro2.txt";

        try
        {
            string[] lines = File.ReadAllLines(f1);
            using (StreamWriter sw = new StreamWriter(f2))
            {
                for (int i = 0; i < lines.Length; i++)
                {

                    string lineM = lines[i].ToUpper();


                    sw.WriteLine($"{i + 1}: {lineM}");
                }
            }

            Console.WriteLine("[+] ficheiro copiado");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("o ficheiro não existe");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"erro: {ex.Message}");
        }
    }
}
