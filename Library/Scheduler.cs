using System;
using System.Collections.Generic;
using System.Diagnostics;

public class Scheduler
{
	private Queue<Process> listo;

	// bloqueado es realmente una cola?
	// porque si dos procesos piden recursos distintos,
	// deberian salir a medida que lo obtienen, sin importar el orden
	// pensar estructura
	private Queue<Process> bloqueado;

	public Scheduler()
	{
		listo = new Queue<Process>();
		bloqueado = new Queue<Process>();
	}

	public void Listo(Process proceso)
	{
		listo.Enqueue(proceso);
	}

	public void Bloqueo(Process proceso)
	{
		bloqueado.Enqueue(proceso);
	}

	public void Desbloqueo(Process proceso)
	{
		listo.Dequeue();
	}

}
