// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;
//ouble diamento, circuferencia, circulo, area;
/*
Console.WriteLine("Digite o Diamento: ");
diamento = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a Circuferencia: ");
circuferencia = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o Circulo: ");
circulo = int.Parse(Console.ReadLine());

area = circulo + circuferencia + diamento;
*/


//Aqui jás as variaveis.
double area, n, raio;

//Pi Valor
n = 3.14159;
Console.WriteLine("Digite o Raio da Area: ");
raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

//Aqui multiplicamos o Raio por Raio ou seja: Raio ao quadrado, então multiplicados o N.
area = (raio * raio) * n;

//Autoexplicativo burro, se não lembra aprenda. :) 
Console.WriteLine("Valor da Area é: " + area.ToString("F4"),CultureInfo.InvariantCulture);