using System;
using System.Globalization;

namespace exercicio_entrada_de_dados
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Entre com seu nome completo: ");
			string a = Console.ReadLine();
			Console.WriteLine("Quantos quartos você tem na sua casa? ");
			int b = int.Parse(Console.ReadLine());
			Console.WriteLine("Entre com o preço de um produto: ");
			double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			Console.WriteLine("Entre seu último nome, idade e altura (mesma linha): ");
			string[] d = Console.ReadLine().Split(' ');
			string nome = d[0];
			int idade = int.Parse(d[1]);
			double altura = double.Parse(d[2], CultureInfo.InvariantCulture);

			Console.WriteLine("----");
			Console.WriteLine(a);
			Console.WriteLine(b);
			Console.WriteLine(c.ToString("F2", CultureInfo.InvariantCulture));
			Console.WriteLine(nome);
			Console.WriteLine(idade);
			Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

		}
	}
}
