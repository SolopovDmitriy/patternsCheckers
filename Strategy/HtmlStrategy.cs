using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class HtmlStrategy : IStrategy
    {
        public void AddListItem(StringBuilder sb, string item)
        {
            sb.AppendLine($"<li>{item}; </li>");
        }

        public void End(StringBuilder sb)
        {
            sb.AppendLine("</ul>");
        }

        public void Start(StringBuilder sb)
        {
            sb.AppendLine("<ul>");
        }
    }
}
