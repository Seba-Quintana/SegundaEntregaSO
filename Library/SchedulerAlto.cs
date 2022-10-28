using System.Diagnostics;

namespace Library
{
	public class SchedulerAlto
	{
		Scheduler scheduler = new Scheduler();

		public void Enviar(Process proceso)
		{
			if (proceso != null)
			{
				scheduler.Listo(proceso);
			}
		}
	}
}