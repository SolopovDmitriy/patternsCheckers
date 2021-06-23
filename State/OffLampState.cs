using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class OffLampState:State
    {
        public OffLampState()
        {
            Console.WriteLine("Текущий статус: Лямпочка потушена...");
        }
        public override void On(Switch sw)
        {
            Console.WriteLine("Лампочка зажигается...");
            sw.State = new OnLampState();
        }
    }
}
