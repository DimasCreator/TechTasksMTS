using System;
using System.Globalization;

namespace Tasks
{
	/// <summary>
	/// Измените класс Number так, чтобы на экран выводился результат сложения для любых значений someValue1 и someValue2.
	/// </summary>
	class Task2
    {
		static readonly IFormatProvider _ifp = CultureInfo.InvariantCulture;

		class Number
		{
			readonly int _number;

			public Number(int number)
			{
				_number = number;
			}

			public static string operator + (Number value1, string value2)
			{
				if (int.TryParse(value2, out int _b))
				{
					return (value1._number + _b).ToString(_ifp);
				}
				else { throw new Exception(); }
			}
		}

		public static void Task()
		{
			int someValue1 = 10;
			int someValue2 = 5;

			string result = new Number(someValue1) + someValue2.ToString(_ifp);
			Console.WriteLine(result);
			Console.ReadKey();
		}
	}
}
