namespace Exercicios_de_fixacao
{
	class ConversorDeMoeda
	{


		public static double Conversao(double dolar, double compra) 
		{
			double c = dolar * compra;
			double d = (c * 0.06) + c;
			return d;
		}
	}
}
