using System;
using System.Globalization;

namespace segundo_problema_exemplo
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("Entre os dados do produto: ");

			Produto x;

			x = new Produto();

			Console.Write("Nome: ");
			x.Nome = Console.ReadLine();
			Console.Write("Preço: ");
			x.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			Console.Write("Quantidade no estoque: ");
			x.Quantidade = int.Parse(Console.ReadLine());

			x.ValorTotalEmEstoque();

			Console.WriteLine("--");
			Console.WriteLine("Dados do produto: " + x);
			Console.WriteLine("--");

			Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
			int qte = int.Parse(Console.ReadLine());
			x.AdicionarProduto(qte);

			Console.WriteLine("--");
			Console.WriteLine("Dados atualizados: " + x);

			Console.WriteLine("--");

			Console.WriteLine("Digite o número de produtos a ser removido do estoque: ");
			qte = int.Parse(Console.ReadLine());
			x.RemoverProdutos(qte);

			Console.WriteLine("--");
			Console.WriteLine("Dados atualizados: " + x);



		}
	}
}
