using System;

namespace modificador_de_parametros
{
	class Program
	{
		static void Main(string[] args)
		{

			string[] vect = new string[] { "Maria", "Bob", "Alex" };

			foreach (string obj in vect)
			{
				Console.WriteLine(obj);
			}

			Console.WriteLine("---------------------");

			for (int i = 0; i < vect.Length; i++) 
			{
				Console.WriteLine(vect[i]);
			}
		}	
	}
}
