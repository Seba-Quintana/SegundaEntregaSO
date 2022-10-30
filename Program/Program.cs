using System;
using System.Diagnostics;
using Library;

namespace SistemaOperativo
{
	public class Program
	{
		public static void Main(string[] args)
		{
			/// convierto de direccion abosluta a relativa
			
			string pathA = @"C:/Users/seba8/Desktop/SO/LiebreTortuga/LiebreTortuga";
			string pathB = @"C:/LiebreTortuga/LiebreTortuga";

			System.Uri uriA = new Uri(pathA);
			System.Uri uriB = new Uri(pathB);
			Uri relativeUri = uriA.MakeRelativeUri(uriB);
			string relativeToA = relativeUri.ToString();

			// hacer varios y que se esperen para ejecutarse (Listo) solo puede haber uno en ejecucion

			Process proceso1 = new Process();

			proceso1.StartInfo.FileName = $"cmd.exe";
			proceso1.StartInfo.Arguments = @$"/K dotnet run --project  {relativeToA} && exit";

			/*Process proceso1 = new Process
			{
				StartInfo = new ProcessStartInfo
				{
					CreateNoWindow = false,
					UseShellExecute = true,
					FileName = "C:/Users/seba8/Desktop/SO/LiebreTortuga/LiebreTortuga/Program.cs",
					WindowStyle = ProcessWindowStyle.Normal,
					//Arguments = "dotnet run --project {relativeToA}"
				}
			};*/

			//proceso1.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;

			Process proceso2 = new Process();

			proceso2.StartInfo.FileName = $"cmd.exe";
			proceso2.StartInfo.Arguments = @$"/K dotnet run --project  {relativeToA} && exit";

			//proceso1.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;

			proceso1.Start();
			
			proceso1.WaitForExit();
			proceso1.CloseMainWindow();
			proceso1.Close();


			proceso2.Start();

			proceso2.WaitForExit();

			proceso2.CloseMainWindow();
			proceso2.Close();
			


			Process proceso3 = new Process();

			proceso3.StartInfo.FileName = "cmd.exe";
			proceso3.StartInfo.Arguments = @$"/K dotnet run --project  {relativeToA}";

			//proceso1.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;


			//proceso3.Start();

			Process proceso4 = new Process();

			proceso4.StartInfo.FileName = "cmd.exe";
			proceso4.StartInfo.Arguments = @$"/K dotnet run --project  {relativeToA}";

			//proceso1.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;


			//proceso4.Start();

			Process proceso5 = new Process();

			proceso5.StartInfo.FileName = "cmd.exe";
			proceso5.StartInfo.Arguments = $@"/K dotnet run --project  {relativeToA}";

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