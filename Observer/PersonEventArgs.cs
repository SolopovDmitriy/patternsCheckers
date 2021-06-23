using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class PersonEventArgs:EventArgs
    {
        private string _address;

        public string Address { get => _address; set => _address = value; }
    }
}
