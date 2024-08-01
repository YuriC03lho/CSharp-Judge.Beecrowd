// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;

class BEE_1008
{
    static void Main(string[] args)
    {
        //Poderia por o Worktimer para INT más fui ver depois a pergunta rsrs. Depois eu convertia :V
        int number ;
        double salary, timePerSalary, worktimer;

        Console.WriteLine("Digite seu Numero de ID caro Caramada: ");
        number = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Caro Camarada, Quantas horas serviu ao nossa Mãe Russia: ");
        worktimer = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        Console.WriteLine("Quantas Horas por Salario você é merecido, camarada: ");
        timePerSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        salary = timePerSalary * worktimer;

        Console.WriteLine("Caro Camarada, obrigado pelos seus Serviços!, Seu ID é: ");
        Console.WriteLine("Seu Salario é: R$ " + salary.ToString("F2"), CultureInfo.InvariantCulture);

        //Ta Tudo Fluindo como Magica aqui, ta estranho más estou gostando.

    }
}
