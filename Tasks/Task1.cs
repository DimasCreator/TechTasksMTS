using System;
using System.Linq;
using System.Diagnostics;

namespace Tasks
{
    /// <summary>
    /// Реализуйте метод FailProcess так, чтобы процесс завершался. 
    /// Предложите побольше различных решений.
    /// </summary>
    class Task1
    {
		public static void Task()
		{
			try
			{
				FailProcess();
			}
			catch { }

			Console.WriteLine("Failed to fail process!");
			Console.ReadKey();
		}
		/// <summary>
		/// Завершение текущего процесса
		/// </summary>
		private static void FailProcess()
		{
			Process.GetCurrentProcess().Kill();
		}
		/// <summary>
		/// Завершение процесса по имени
		/// </summary>
		private static void FailProcess(string name)
		{
			Process.GetProcessesByName(name).FirstOrDefault()?.Kill();
		}
		/// <summary>
		/// Завершение процесса переданного в качестве аргумента
		/// </summary>
		private static void FailProcess(Process process)
		{
			process?.Kill();
		}
	}
}
