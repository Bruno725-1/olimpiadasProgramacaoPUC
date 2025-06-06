using System;
using System.Collections.Generic;
class Program {
    static void Main (string[] args) {
        int t = int.Parse(Console.ReadLine());
        for (int i = 0; i < t; i++) {
            int n = int.Parse(Console.ReadLine());
            int posicao = 0;
            List<string> instrucoes = new List<string>();
            for (int j = 0; j < n; j++) {
                string[] linha = Console.ReadLine().Split(' ');
                if (linha.Length == 1) {
                    instrucoes.Add(linha[0]);
                    if (linha[0] == "LEFT") 
                    posicao--;
                    else if(linha[0] == "RIGHT")
                    posicao++;
                }
                else {
                    string instrucao = ProcessarInstrucao(linha, instrucoes);
                    if (instrucao == "LEFT")
                    posicao--;
                    else if (instrucao == "RIGHT" )
                    posicao++;
                }
            }
            Console.WriteLine(posicao);
        }
    }
    static string ProcessarInstrucao(string[] linha, List<string> instrucoes) {
        int indice = int.Parse(linha[2]) - 1; //ajustar para o índice da lista
        string processada = instrucoes[indice];
        instrucoes.Add(processada);
        return processada;
    }
}