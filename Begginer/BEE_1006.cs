// See https://aka.ms/new-console-template for more information
double A, B, C, Media;
Console.WriteLine("Digite a Primeira Nota: ");
A = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a Segunda Nota: ");
B = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a Terceira Nota: ");
C = double.Parse(Console.ReadLine());


Media = ((A * 2) + (B * 3) + (C * 5)) / 10;



Console.WriteLine("A Soma de sua Media foi de: " + Media.ToString("F1"));
