using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Шаблонный метод — это поведенческий паттерн проектирования, который определяет скелет алгоритма, 
                перекладывая ответственность за некоторые его шаги на подклассы. 
                Паттерн позволяет подклассам переопределять шаги алгоритма, не меняя его общей структуры.
            */
            CheckersGame game1 = new CheckersGame(2);

            //game1.Start();
            //game1.Print();

            game1.Run();

        }
    }
}
