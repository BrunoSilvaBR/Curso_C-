using System;
using System.Globalization;

namespace Exercicios_de_fixacao
{
	class Program
	{

		static void Main(string[] args)
		{
			Console.Write("Qual é a cotação do doólar? ");
			double dolar = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture);

			Console.Write("Quantos dólares você comprar? ");
			double compra = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			Console.Write("Valor a ser pago em reais = " + ConversorDeMoeda.Conversao(dolar, compra).ToString("F2"),CultureInfo.InvariantCulture);
		}



	}
}
