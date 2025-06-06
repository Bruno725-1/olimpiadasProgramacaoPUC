using System;
class Program {
    static void Main (string[] args) {
        string[] input = Console.ReadLine().Split(' ');
        int horaInicio = int.Parse(input[0]);
        int horaTermino = int.Parse(input[1]);
        if (horaTermino <= horaInicio)
        horaTermino += 24;
        int tempo = horaTermino - horaInicio;
        Console.WriteLine("O JOGO DUROU {0} HORA(S)", tempo);
    }
}