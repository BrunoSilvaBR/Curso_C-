using System;
using System.Globalization;
using System.Collections.Generic;

namespace List_Fixacao
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Quantos serão :");
			int total = int.Parse(Console.ReadLine());

			List<Funcionario> list = new List<Funcionario>();

			for (int i = 1; i <= total; i++)
			{
				Console.WriteLine($"Empregado {i}");
				int codigo = int.Parse(Console.ReadLine());
				string nome = Console.ReadLine();
				int salario = int.Parse(Console.ReadLine());
				list.Add(new Funcionario(nome, salario, codigo));
				Console.WriteLine();

			}

			Console.Write("Coloque um id ?");
			int id = int.Parse(Console.ReadLine());

			Funcionario emp = list.Find(x => x.Codigo == id);
			if (emp != null)
			{
				Console.WriteLine("Entre com a porcentagem");
				int porcetagem = int.Parse(Console.ReadLine());
				emp.Aumento(porcetagem);
			}
			else 
			{
				Console.WriteLine("Isso não existe! ");
			}


			foreach (Funcionario obj in list) 
			{
				Console.WriteLine(obj);
			}
			

		}
	}
}
