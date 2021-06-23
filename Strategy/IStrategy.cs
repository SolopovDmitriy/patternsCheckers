using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    interface IStrategy
    {
        void Start(StringBuilder sb);

        void End(StringBuilder sb);

        void AddListItem(StringBuilder sb, string item);
    }
}
