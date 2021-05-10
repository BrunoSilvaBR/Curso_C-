using System;

namespace estrutura_repetitiva_para_for
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.Write("Quantos números inteiros você vai digitar? ");
			int n = int.Parse(Console.ReadLine());

			int soma = 0;


			for (int i = 1; i <= n; i += 1) 
			{
				Console.Write("Valor #{0}: ", i);
				int valor = int.Parse(Console.ReadLine());
				soma += valor;
			}

			Console.WriteLine("Soma = "+ soma);
		}
	}
}
