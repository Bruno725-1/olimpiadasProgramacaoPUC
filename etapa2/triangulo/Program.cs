using System;
class Program {
    static void Main(string[] args) {
        string[] entrada = Console.ReadLine().Split(' ');
        int a = int.Parse(entrada[0]);
        int b = int.Parse(entrada[1]);
        int c = int.Parse(entrada[2]);
        int d = int.Parse(entrada[3]);
        if (FormaTriangulo(a, b, c) ||
            FormaTriangulo(a, b, d) ||
            FormaTriangulo(a, c, d) ||
            FormaTriangulo(b, c, d))
        Console.WriteLine("S");
        else
        Console.WriteLine("N");
    }
    static bool FormaTriangulo(int x, int y, int z) {
        return(x + y > z) && (x + z > y) && (y + z > x);
    }
}