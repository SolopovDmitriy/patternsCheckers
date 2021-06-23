using System;
using System.Collections.Generic;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Стратегия — это поведенческий паттерн проектирования, который определяет семейство схожих алгоритмов и 
                помещает каждый из них в собственный класс, после чего алгоритмы можно взаимозаменять прямо во 
                время исполнения программы.
             */

            TextBulder textBulder = new TextBulder();
            textBulder.CheckOutputFormat(OutputFormat.MarkDown);
            textBulder.AddItems(new List<string>() {
                "Молоко",
                "Селедка",
                "Малосольный огурец",
                "Пиво",
            });
            Console.WriteLine(textBulder.GetText());
            
            TextBulder textBulderHtml = new TextBulder();
            textBulderHtml.CheckOutputFormat(OutputFormat.Hhml);
            textBulderHtml.AddItems(new List<string>() {
                "Молоко",
                "Селедка",
                "Малосольный огурец",
                "Пиво",
            });
            Console.WriteLine(textBulderHtml.GetText());
        }
    }
}
