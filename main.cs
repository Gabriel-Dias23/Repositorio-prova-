using System;

namespace ContarPalavras

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();

            // Dividir a frase em palavras usando o método Split
            string[] palavras = frase.Split(' ');

            // Contar o número de palavras
            int numeroDePalavras = palavras.Length;

            Console.WriteLine("A frase contém {0} palavras.", numeroDePalavras);
        }
    }
}