using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string f1 = "C:\\Users\\monte\\Desktop\\f1";
        string f2 = "C:\\Users\\monte\\Desktop\\f2";

        try
        {
            string[] linhas = File.ReadAllLines(f1);

            using (StreamWriter sw = new StreamWriter(f1))
            {
                foreach (string linha in linhas)
                {

                    char[] chars = linha.ToCharArray();
                    Array.Reverse(chars);
                    string linhaInvertida = new string(chars);

                    sw.WriteLine(linhaInvertida);
                }
            }
            Console.WriteLine("ficheiro copiado");
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
