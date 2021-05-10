
using System.Globalization;

namespace segundo_problema_exemplo
{
	class Produto
	{

		public string Nome;
		public double Preco;
		public int Quantidade;

		public double ValorTotalEmEstoque() 
		{
			double calculo = Preco * Quantidade;
			return calculo;
		}

		public void AdicionarProduto(int quantidade) 
		{
			Quantidade += quantidade;
		}

		public void RemoverProdutos(int quantidade) 
		{
			Quantidade -= quantidade;
		}

		public override string ToString()
		{
			return Nome
				+ ", $ "
				+ Preco.ToString("F2", CultureInfo.InvariantCulture)
				+ ", "
				+ Quantidade
				+ " unidades, Total: $ "
				+ ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
		}

	}
}
