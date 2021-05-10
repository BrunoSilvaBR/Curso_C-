using System;
using System.Globalization;

namespace exercícios_proposto1
{
	class Program
	{
		static void Main(string[] args)
		{

			string [] n = Console.ReadLine().Split(" ");
			double valorA = double.Parse(n[0], CultureInfo.InvariantCulture);
			double valorB = double.Parse(n[1], CultureInfo.InvariantCulture);
			double valorC = double.Parse(n[2], CultureInfo.InvariantCulture);
			double tria, cir, trap, quadr, retang;

			tria = (valorA * valorC) / 2;
			cir = Math.PI * (valorC * valorC);
			trap = ((valorA + valorB) * valorC) / 2;
			quadr = valorB * valorB;
			retang = valorA * valorB;

			Console.WriteLine(" Triangulo: " + tria.ToString("F3"),CultureInfo.InvariantCulture);
			Console.WriteLine(" Circulo: " + cir.ToString("F3"), CultureInfo.InvariantCulture);
			Console.WriteLine(" Trapezio: " + trap.ToString("F3"), CultureInfo.InvariantCulture);
			Console.WriteLine(" Quadrado: " + quadr.ToString("F3"), CultureInfo.InvariantCulture);
			Console.WriteLine(" Retangulo: " + retang.ToString("F3"), CultureInfo.InvariantCulture);

		}
	}
}
