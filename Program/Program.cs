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
			proceso1.StartInfo.Arguments = "/K dotnet run --project C:/Users/seba8/Desktop/SO/LiebreTortuga/LiebreTortuga";//cd C:\\Users\\seba8\\Desktop\\SO\\SegundaEntrega\\Program\\proceso1.cs; dotnet run

			//proceso1.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;


			proceso1.Start();
		}
	}
}