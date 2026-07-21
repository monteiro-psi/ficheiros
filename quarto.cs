using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Nome do primeiro ficheiro: ");
        string ficheiro1 = Console.ReadLine();

        Console.Write("Nome do segundo ficheiro: ");
        string ficheiro2 = Console.ReadLine();

        try
        {
            // Lê o conteúdo dos dois ficheiros
            string conteudo1 = File.ReadAllText(ficheiro1);
            string conteudo2 = File.ReadAllText(ficheiro2);

            // Escreve o conteúdo trocado
            File.WriteAllText(ficheiro1, conteudo2);
            File.WriteAllText(ficheiro2, conteudo1);

            Console.WriteLine("Conteúdo dos ficheiros trocado com sucesso!");
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"Erro: ficheiro não encontrado - {ex.FileName}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro: {ex.Message}");
        }
    }
}
