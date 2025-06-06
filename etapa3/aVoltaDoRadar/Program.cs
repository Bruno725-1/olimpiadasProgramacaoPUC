using System;
class Program {
    static void Main(string[] args)
    {
        while (true)
        {
            int t = int.Parse(Console.ReadLine());
            if (t == 0) break;
            for (int i = 0; i < t; i++)
            {
                int pessoas = int.Parse(Console.ReadLine());
                int pedidos = 0;
                if (pessoas % 2 == 0)
                {
                    pessoas -= 2;
                    pedidos = (pessoas * 2) + 2;
                }
                else
                {
                    pessoas -= 1;
                    pedidos = (pessoas * 2) + 1;
                }
                Console.WriteLine(pedidos);
            }
        }
    }
}