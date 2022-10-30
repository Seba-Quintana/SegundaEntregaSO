using System;
using System.Collections.Concurrent;
using System.Diagnostics;
//using System.Buffers; no tengo internet, hay que ver como funciona

namespace ProductorConsumidor
{
	public class ProductorConsumidor
	{
		private int[] buffer;

		public int[] Buffer { get; private set; }

		private int ins;

		private int rem;

		private Mutex mutex;

		private readonly Process productor;

		private readonly Process consumidor;

		private ProductorConsumidor instance;

		public ProductorConsumidor Instance { get; private set; }

		// Singleton para poder inicializar valores en ctor
		private ProductorConsumidor()
		{
			// inicializo buffer circular
			buffer = new int[10];
			ins = 0;
			rem = 0;
			// false o true? debe comenzar abierto
			mutex = new Mutex(false);
			// inicializo los procesos
			productor = new Process();
			consumidor = new Process();
			// configuro la ejecucion de los procesos
			productor.StartInfo.FileName = "cmd.exe";
			productor.StartInfo.Arguments = @"/K dotnet run --project ";
			consumidor.StartInfo.FileName = "cmd.exe";
			consumidor.StartInfo.Arguments = @"/K dotnet run --project ";
			// lanzo los procesos
			productor.Start();
			consumidor.Start();

		}
		public ProductorConsumidor GetInstance()
		{
			if (productor == null)
				instance = new ProductorConsumidor();
			return instance;
		}

		public void Insertar(int producto)
		{
			mutex.WaitOne();
			buffer[ins++] = producto;
			mutex.ReleaseMutex();
		}

		public int Extraer()
		{
			mutex.WaitOne();
			int producto = buffer[rem++];
			mutex.ReleaseMutex();
			return producto;
		}
	}
}