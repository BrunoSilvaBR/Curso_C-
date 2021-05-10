using System;

namespace escopo_e_inicializacao
{
	class Program
	{
		static void Main(string[] args)
		{
			double preco = double.Parse(Console.ReadLine());
			double desconto = 0;

			if (preco > 100) 
			{
				desconto = preco * 0.1;				
			}


			Console.WriteLine(desconto);

		}
	}
}
