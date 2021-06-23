using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Наблюдатель — это поведенческий паттерн проектирования, который создаёт механизм подписки, 
             * позволяющий одним объектам следить и реагировать на события, происходящие в других объектах.
             * 
             * observer - подписчик на какоето событие
             * observable - обьект который генерирует событие
             */

            Person person = new Person() { Fio = "Чакка норрис", BirthDate = DateTime.Now, Address = "Полтава, Иванова 13" };

            person.GotSick += Person_GotSick;

            person.CatchACold();
        }

        private static void Person_GotSick(object sender, PersonEventArgs e)
        {
            Console.WriteLine($"Заболел: {((Person)sender).Fio}; Вызвать врача по адрессу: {e.Address}"); ;
        }
    }
}
