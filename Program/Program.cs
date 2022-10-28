using System;
using System.Diagnostics;
using Library;

namespace SistemaOperativo
{
	public class Program
	{
		public static void Main(string[] args)
		{
			// hacer varios y que se esperen para ejecutarse (Listo) solo puede haber uno en ejecucion

			Process proceso1 = new Process();

			proceso1.StartInfo.FileName = "cmd.exe";
			proceso1.StartInfo.Arguments = @"/K dotnet run --project C:/Users/seba8/Desktop/SO/LiebreTortuga/LiebreTortuga";//cd C:\\Users\\seba8\\Desktop\\SO\\SegundaEntrega\\Program\\proceso1.cs; dotnet run

			//proceso1.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;


			//proceso1.Start();

			Process proceso2 = new Process();

			proceso2.StartInfo.FileName = "cmd.exe";
			proceso2.StartInfo.Arguments = @"/K dotnet run --project C:/Users/seba8/Desktop/SO/LiebreTortuga/LiebreTortuga";//cd C:\\Users\\seba8\\Desktop\\SO\\SegundaEntrega\\Program\\proceso1.cs; dotnet run

			//proceso1.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;


			//proceso2.Start();

			Process proceso3 = new Process();

			proceso3.StartInfo.FileName = "cmd.exe";
			proceso3.StartInfo.Arguments = @"/K dotnet run --project C:/Users/seba8/Desktop/SO/LiebreTortuga/LiebreTortuga";//cd C:\\Users\\seba8\\Desktop\\SO\\SegundaEntrega\\Program\\proceso1.cs; dotnet run

			//proceso1.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;


			//proceso3.Start();

			Process proceso4 = new Process();

			proceso4.StartInfo.FileName = "cmd.exe";
			proceso4.StartInfo.Arguments = @"/K dotnet run --project C:/Users/seba8/Desktop/SO/LiebreTortuga/LiebreTortuga";//cd C:\\Users\\seba8\\Desktop\\SO\\SegundaEntrega\\Program\\proceso1.cs; dotnet run

			//proceso1.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;


			//proceso4.Start();

			Process proceso5 = new Process();

			proceso5.StartInfo.FileName = "cmd.exe";
			proceso5.StartInfo.Arguments = @"/K dotnet run --project C:/Users/seba8/Desktop/SO/LiebreTortuga/LiebreTortuga";//cd C:\\Users\\seba8\\Desktop\\SO\\SegundaEntrega\\Program\\proceso1.cs; dotnet run

			//proceso1.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;


			//proceso5.Start();

			SchedulerAlto scheduler = new SchedulerAlto();

			scheduler.Enviar(proceso1);
			scheduler.Enviar(proceso2);
			scheduler.Enviar(proceso3);
			scheduler.Enviar(proceso4);
			scheduler.Enviar(proceso5);
		}
	}
}