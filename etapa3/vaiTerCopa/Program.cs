using System;
class Program
{
    static void Main(string[] args)
    {
        string linha;
        while ((linha = Console.ReadLine()) != null)
        {
            if ((int.Parse(linha)) != 0)
                Console.WriteLine("vai ter duas!");
            else
                Console.WriteLine("vai ter copa!");
        }
    }
}