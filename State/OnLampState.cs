using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class OnLampState:State
    {
        public OnLampState()
        {
            Console.WriteLine("Лямпочка горит...");
        }
        public override void Off(Switch sw)
        {
            Console.WriteLine("Лампочка выключается...");
            sw.State = new OffLampState();
        }
    }
}
