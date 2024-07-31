// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

double A, B, Media;
Console.WriteLine("Digite o primeiro nota para Media do aluno: ");
A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
Console.WriteLine("Digite a Segunda nota para Media do aluno");
B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Media = ((A * 3.5) + (B * 7.5)) / 11;
Console.WriteLine("A Media do aluno é: " + Media.ToString("F5"),CultureInfo.InvariantCulture);