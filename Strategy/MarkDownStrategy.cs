using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class MarkDownStrategy : IStrategy
    {
        public void AddListItem(StringBuilder sb, string item)
        {
            sb.AppendLine($" * { item }; ");
        }

        public void End(StringBuilder sb)
        {
            //empty
        }

        public void Start(StringBuilder sb)
        {
            //empty
        }
    }
}
