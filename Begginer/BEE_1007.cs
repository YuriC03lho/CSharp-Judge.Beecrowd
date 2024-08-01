// See https://aka.ms/new-console-template for more information
using System;

class BEE_1007
{
    static void Main(string[] args)
    {
        int A, B, C, D, DIF;

        Console.WriteLine("Digite o Primeiro Numero: ");
        A = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o Segundo Numero: ");
        B = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o Terceiro Numero: ");
        C = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o Quarto e ultimo Numero: ");
        D = int.Parse(Console.ReadLine());

        DIF = (A * B - C * D);
        Console.WriteLine("A Diferença entre os Valores é: " + DIF);
    }
}

