using System;
using System.Globalization;

namespace exercicio4_estrutura_for
{
	class Program
	{
		static void Main(string[] args)
		{

			int n = int.Parse(Console.ReadLine());

			int q = 0;
			int c = 0;

			for (int i = 1; i <= n; i++)
			{
				q = (i * i);
				c = (i * i * i);

				Console.WriteLine($"{i} {q} {c}");
			}

			

		

		}

	}
}
