using System;
using System.IO;
using System.Threading.Tasks;
using System.Threading;

namespace Tasks
{
    /// <summary>
    /// Программа выводит на экран строку «Муха», а затем продолжает выполнять остальной код. 
    /// Реализуйте метод TransformToElephant так, чтобы программа выводила на экран строку «Слон», а затем продолжала выполнять остальной код, не выводя перед этим на экран строку «Муха».
    /// </summary>
    class Task5
    {
        public static void Task()
        {
            var consoleStandartOut = Console.Out;
            
            TransformToElephant();
            Console.WriteLine("Муха");

            //Next code
            Console.SetOut(consoleStandartOut);
            Console.WriteLine("Next");
        }

        static void TransformToElephant()
        {
            Console.WriteLine("Слон");
            var consoleNewOut = new StringWriter();
            Console.SetOut(consoleNewOut);
        }
    }
}
