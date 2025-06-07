using System;
class Program
{
    static void Main(string[] args)
    {
        string linha1 = Console.ReadLine();
        string linha2 = Console.ReadLine();
        double valor1 = 0;
        string cpf = GetCPF(linha1, ref valor1);
        double valor2 = PercorrerLinha(linha2);
        double total = valor1 + valor2;
        Console.WriteLine("cpf " + cpf);
        Console.WriteLine($"{total:F2}");
    }
    static string GetCPF(string linha, ref double valor1)
    {
        char[] cpf = new char[11];
        int pos = 0; // variável para controlar a posição de inserção no cpf
        for (int i = 0; i < linha.Length; i++)
        {
            if (int.TryParse(linha[i].ToString(), out _))
            {
                if (pos < 11)
                {
                    cpf[pos] = linha[i];
                    pos++;
                }
                else
                {
                    valor1 += Convert.ToDouble(linha[i].ToString());
                }
            }
        }
        return new string(cpf);
    }
    static double PercorrerLinha(string linha2)
    {
        double valor = 0;
        for (int i = 0; i < linha2.Length; i++)
        {
            if (double.TryParse(linha2[i].ToString(), out double num))
                valor += num;
        }
        return valor;
    }
}
