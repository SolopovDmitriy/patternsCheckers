using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class TextBulder
    {
        private StringBuilder _sb;
        private IStrategy _strategy;

        public TextBulder()
        {
            _sb = new StringBuilder();
        }

        public void CheckOutputFormat(OutputFormat output)
        {
            switch (output)
            {
                case OutputFormat.MarkDown:
                    _strategy = new MarkDownStrategy();
                    break;
                case OutputFormat.Hhml:
                    _strategy = new HtmlStrategy();
                    break;
                default:
                    break;
            }
        }
        public void AddItems(IEnumerable<string> items)
        {
            _strategy.Start(_sb);
            foreach (var item in items)
            {
                _strategy.AddListItem(_sb, item);
            }
            _strategy.End(_sb);
        }
        public string GetText()
        {
            return _sb.ToString();
        }
    }
}
