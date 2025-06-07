using System;
class Program
{
    static void Main(string[] args)
    {
        string linha1 = Console.ReadLine();
        string linha2 = Console.ReadLine();
        string cpf = GetCPF(linha1);
        Console.WriteLine(cpf);
    }
    static string GetCPF(string linha)
    {
        char[] cpf = new char[11];
        int pos = 0; // variável para controlar a posição de inserção no cpf
        for (int i = 0; i < linha.Length; i++)
        {
            if (pos >= 11) break; //evita inserção de itens em índices inexistentes
            if (int.TryParse(linha[i].ToString(), out int digito))
            {
                cpf[pos] = Convert.ToChar(digito);
                pos++;
            }
        }
        return new string(cpf);
    }
}
