﻿using System.Globalization;


namespace exercicio_de_fixacao5
{
	class Banco
	{

		public int Numero { get; private set; }
		public string Titular { get; set; }
		public double Saldo { get; private set; }

		public Banco(int numero, string titular)
		{
			Numero = numero;
			Titular = titular;
		}

		public Banco(int numero, string titular, double depositoInicial) : this(numero, titular)
		{
			Deposito(depositoInicial);
		}

		public void Deposito(double quantia) 
		{
			Saldo += quantia;
		}

		public void Saque(double quantia) 
		{
			Saldo -= quantia + 5.00; 
		}


		public override string ToString()
		{
			return "Conta "
				+ Numero
				+ ", Titular:"
				+ Titular
				+ ", Saldo: $ "
				+ Saldo.ToString("F2", CultureInfo.InvariantCulture);
		}
	}
}
