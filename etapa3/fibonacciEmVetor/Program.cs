using System;
class Program
{
    static void Main(string[] args)
    {
        int testes = int.Parse(Console.ReadLine());
        for (int i = 0; i < testes; i++)
        {
            UInt64 t1 = 0, t2 = 1, prox = 0;
            int num = int.Parse(Console.ReadLine());
            int aux = num + 1; //o programa deve apresentar o último termo da sequência a partir do número digitado + 1
            if (aux == 2)
                prox = 1;
            for (int j = 3; j <= aux; j++)
            {
                prox = t1 + t2;
                t1 = t2;
                t2 = prox;
            }
            Console.WriteLine("Fib({0}) = {1}", num, prox);
        }
    }
}