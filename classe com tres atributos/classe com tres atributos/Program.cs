using System;
using System.Globalization;

namespace classe_com_tres_atributos
{
	class Program
	{
		static void Main(string[] args)
		{

			Funcionarios x, y;

			x = new Funcionarios();
			y = new Funcionarios();

			Console.WriteLine("Dados do primeiro funcionário: ");

			x.A = Console.ReadLine();
			x.B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

			Console.WriteLine("Dados do segundo funcioário: ");

			y.A = Console.ReadLine();
			y.B = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture);

			double media = (x.B + y.B) / 2;

			Console.WriteLine("Salário Médio = " + media.ToString("F2", CultureInfo.InvariantCulture));
			








		}
	}
}
