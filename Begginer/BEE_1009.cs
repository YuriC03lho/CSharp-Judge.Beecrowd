// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

namespace BEE_1009
{
    class BEE_1009
    {
        static void Main(string[] args)
        {

            string seller;
            double vendas, totalvendas, r, resposta;


            Console.WriteLine("Digite o seu Nome: ");
            seller = Console.ReadLine();
            Console.WriteLine(seller + " Seu Salario Fixo é: ");
            vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Total de Vendas deste Mes: ");
            totalvendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Muito viajado isso, tenho que estudar mais matematica.
            r = totalvendas * 15.0 / 100 + vendas;

            Console.WriteLine("Sua Comissão é de: " + r.ToString("F2"), CultureInfo.InvariantCulture);
        }
      }  
}
