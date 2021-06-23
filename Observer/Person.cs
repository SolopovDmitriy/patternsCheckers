using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class Person
    {
        private string _fio;
        private DateTime _birthDate;
        private string _address;
        public Person()
        {
            Fio = default;
            BirthDate = default;
        }
        public Person(string fio, DateTime birthDate)
        {
            Fio = fio;
            _birthDate = birthDate;
        }
        public string Fio { get => _fio; set => _fio = value; }
        public string Address { get => _address; set => _address = value; }
        public DateTime BirthDate { get => _birthDate; set => _birthDate = value; }

        public void CatchACold() //простудился - триггер
        {
            GotSick?.Invoke(this, new PersonEventArgs() { Address = "Полтава, Центр стрит" });
        }

        public event EventHandler<PersonEventArgs> GotSick; //- событие
    }
}
