using System;

namespace Tasks
{
	/// <summary>
	/// Модифицируйте код так, чтобы во всех местах на экран выводилось «True». Метод Main изменять нельзя. 
	/// Появились ли в коде новые методы или свойства? Можно ли обойтись без них?
	/// 
	/// Ответы на вопрос: 
	/// В коде неявно появилось публичное поле get_HasValue, которое является указателем на метод возвращиющий булево значение.
	/// Можно ли обойтись без них? Я думаю для решения данной задачи без них можно обойтись нельзя.
	/// </summary>
	class Task3
    {
		struct IntValue
		{
			public int? Value;

			public bool HasValue { get => Value.HasValue; }
		}

		public static void Task()
		{
			IntValue intValue = new IntValue();
			Console.WriteLine(intValue.HasValue == intValue.Value.HasValue);

			intValue.Value = 1;
			Console.WriteLine(intValue.HasValue == intValue.Value.HasValue);

			intValue.Value = -1;
			Console.WriteLine(intValue.HasValue == intValue.Value.HasValue);

			intValue.Value = 0;
			Console.WriteLine(intValue.HasValue == intValue.Value.HasValue);

			intValue.Value = null;
			Console.WriteLine(intValue.HasValue == intValue.Value.HasValue);

			Console.ReadKey();
		}
	}
}
