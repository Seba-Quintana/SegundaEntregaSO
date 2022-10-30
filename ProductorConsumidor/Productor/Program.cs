using System;
using System.Diagnostics;

namespace ProductorConsumidor
{
	public class Productor
	{
		public ProductorConsumidor productorConsumidor;

		public Productor()
		{
		}

		public int Producir()
		{
			Console.WriteLine("produciendo...\n");
			Console.WriteLine("produccion completada");
			return 5;
		}

		public void Insertar()
		{
			productorConsumidor.Insertar(5);
		}
	}
}