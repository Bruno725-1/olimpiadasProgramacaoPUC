using System;
class Program
{
    static void Main(string[] args)
    {
        string linha;
        while ((linha = Console.ReadLine()) != null)
        {
            string[] vetor = linha.Split('-');
            string cobol = "COBOL";
            bool valido = true;
            for (int i = 0; i < 5; i++)
            {
                char letra = cobol[i];
                string palavra = vetor[i];
                if (char.ToUpper(palavra[0]) != letra && char.ToUpper(palavra[palavra.Length - 1]) != letra)
                {
                    valido = false;
                    break;
                }
            }
            if (valido)
                Console.WriteLine("GRACE HOPPER");
            else
                Console.WriteLine("BUG");
        }
    }
}