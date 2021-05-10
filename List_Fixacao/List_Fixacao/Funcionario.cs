using System.Globalization;

namespace List_Fixacao
{
	class Funcionario
	{

		public string Nome { get; set; }
		public int Salario { get; set; }
		public int Codigo { get; set; }


		public Funcionario(int codigo) 
		{
			Codigo = codigo;
		}

		public Funcionario(string nome, int salario, int codigo)
		{
			Nome = nome;
			Salario = salario;
			Codigo = codigo;
		}

		public void Aumento(int aumento) 
		{
			Salario += (Salario * (aumento / 100)); 
		}

		public override string ToString()
		{
			return Codigo + ", " + Nome + ", " + Salario;
		}
	}
}
