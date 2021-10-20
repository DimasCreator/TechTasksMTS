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
            TransformToElephant();
            Console.WriteLine("Муха");
            //Next code
            Console.WriteLine("Next");
        }

        static void TransformToElephant()
        {
            Console.SetOut(new InterceptWriter());
        }

        class InterceptWriter : StringWriter
        {
            private readonly TextWriter _mainOut;

            public InterceptWriter()
            {
                _mainOut = Console.Out;
            }

            public override void WriteLine(string str)
            {
                Console.SetOut(_mainOut);
                Console.WriteLine("Слон");
            }
        }
    }
}
