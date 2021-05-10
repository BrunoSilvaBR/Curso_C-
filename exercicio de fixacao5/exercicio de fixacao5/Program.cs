using System;
using System.Globalization;

namespace exercicio_de_fixacao5
{
	class Program {
		static void Main(string[] args)
		{
			{
				Banco conta;

				Console.Write("Entre com o número da conta: ");
				int numero = int.Parse(Console.ReadLine());
				Console.Write("Entre o titular da conta: ");
				string titular = Console.ReadLine();
				Console.Write("Haverá depósito inicial (s/n)? ");
				char resp = char.Parse(Console.ReadLine());
				if (resp == 's' || resp == 'S')
				{
					Console.Write("Entre o valor de depósito iicial: ");
					double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
					conta = new Banco(numero, titular, depositoInicial);
				}
				else 
				{
					conta = new Banco(numero, titular);
				}
				Console.WriteLine();
				Console.WriteLine("Dados da conta");
				Console.WriteLine(conta);

				Console.WriteLine();
				Console.Write("Entre um valor para depósito: ");
				double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				conta.Deposito(quantia);
				Console.WriteLine("Dados da cota atualizados: ");
				Console.WriteLine(conta);

				Console.WriteLine();
				Console.Write("Entre um valor para saque: ");
				quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				conta.Saque(quantia);
				Console.WriteLine("Dados da cota atualizados: ");
				Console.WriteLine(conta);

			}
		}
	}
}

