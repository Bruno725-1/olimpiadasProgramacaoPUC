using System;
class Program {
    static void Main (string[] args) {
        string linha;
        while ((linha = Console.ReadLine()) != null) {
            string[] entrada = linha.Split(' ');
            int h = int.Parse(entrada[0]);
            int m = int.Parse(entrada[1]);
            h /= 30;
            m /= 6;
            ImprimirHorario(h, m);
        }
    }
    static void ImprimirHorario(int h, int m) {
        string aux = "0";
        string hora = h.ToString();
        string minuto = m.ToString();
        if (h < 10)
        hora = string.Concat(aux, hora);
        if (m < 10)
        minuto = string.Concat(aux, minuto);
        Console.WriteLine($"{hora}:{minuto}");
    }
}