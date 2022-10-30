using System;
using System.Diagnostics;

namespace ProductorConsumidor
{
	public class Consumidor
	{
		public ProductorConsumidor productorConsumidor;

		public Consumidor()
		{
		}

		public void Extraer()
		{
			productorConsumidor.Extraer();
		}
	}
}