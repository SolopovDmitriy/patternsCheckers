namespace State
{
     class Switch
    {
        public   State State = new OffLampState(); //по умолчанию выключен. лампочка не горит
        public void On()
        {
            State.On(this);
        }
        public void Off()
        {
            State.Off(this);
        }
    }
}