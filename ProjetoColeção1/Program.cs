
using System;
using System.Collections.Generic;
using System.IO;
using ProjetoColeção1.Entites;
namespace ProjetoColeção1
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<RegistroLog> registroLogs = new HashSet<RegistroLog>();
            Console.Write("Entre com pasta do arquivo: ");
            string pasta = Console.ReadLine();
            try
            {
                using (StreamReader sr = File.OpenText(pasta))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] linha = sr.ReadLine().Split(' ');
                        string nome = linha[0];
                        DateTime momento = DateTime.Parse(linha[1]);
                        registroLogs.Add(new RegistroLog(nome, momento));
                        Console.WriteLine("Total usuarios: " + registroLogs.Count);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}