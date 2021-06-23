using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Состояние — это поведенческий паттерн проектирования, который позволяет объектам менять поведение в 
             * зависимости от своего состояния. */

            Switch smallSwitch = new Switch();

            smallSwitch.On();
            smallSwitch.Off();
            smallSwitch.Off();
            smallSwitch.Off();
            smallSwitch.Off();
        }
    }
}
