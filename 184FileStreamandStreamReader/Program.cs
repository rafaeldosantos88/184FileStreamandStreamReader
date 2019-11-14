using System;
using System.IO;

namespace _184FileStreamandStreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminho = @"c:\temp\arquivo.txt";

            StreamReader sr = null;

            try
            {
                sr = File.OpenText(caminho);                                                               //OpenText implicitamente instancia o fileStream e instancia o streamReader em cima dele
                while (!sr.EndOfStream)
                {                                                                                         //Enquanto Eu não chegar no final da Stream


                    string line = sr.ReadLine();                                                       //Vou ler uma linha do arquivo e armazena na variavel line
                    Console.WriteLine(line);
                }


            }
            catch (IOException e)
            {
                Console.WriteLine("Um erro ocorreu");
                Console.WriteLine(e.Message);
            }
            finally                                                 //serve para fechar string
            {
                if (sr != null) sr.Close();


            }

        }
    }
}
