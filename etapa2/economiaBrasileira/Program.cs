using System;
class Program {
    static void Main (string[] args) {
        int n = int.Parse(Console.ReadLine());
        int[] numeros = ToIntArray(Console.ReadLine());
        bool populacaoSatisfeita = VerificarOpinioes(numeros, n);
        if (populacaoSatisfeita)
        Console.WriteLine("Y");
        else
        Console.WriteLine("N");
    }
    static int[] ToIntArray(string linha ) {
        string[] vetor = linha.Split(' ');
        int[] numeros = new int[vetor.Length];
        for (int i = 0; i < vetor.Length; i++) {
            numeros[i] = Convert.ToInt32(vetor[i]);
        }
        return numeros;
    }
    static bool VerificarOpinioes(int[] numeros, int n) {
        int contador = 0;
        for (int i = 0; i < n; i++) {
            if (numeros[i] == 0)
            contador++;
        }
        return contador > n / 2;
    }
}