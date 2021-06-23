using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    abstract class State
    {
        public virtual void On(Switch sw)
        {
            Console.WriteLine("Лампочка зажглась");
        }

        public virtual void Off(Switch sw)
        {
            Console.WriteLine("Лампочка потухла");
        }
    }
}
