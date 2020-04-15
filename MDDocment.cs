using System;
using System.Text;

namespace MDTools
{
    public class MDDocment
    {
        private StringBuilder _doc;
        public MDDocment()
        {
            _doc = new StringBuilder();
        }
        public void AppendTitle1(string content) => AppendTitle(1, content);
        public void AppendTitle2(string content) => AppendTitle(2, content);
        public void AppendTitle3(string content) => AppendTitle(3, content);
        public void AppendTitle4(string content) => AppendTitle(4, content);
        public void AppendTitle5(string content) => AppendTitle(5, content);
        public void AppendTitle6(string content) => AppendTitle(6, content);

        public void AppendContent(string content) => _doc.Append(content);
        public void AppendNewLine()
        {
            _doc.Append(" " + Environment.NewLine);
        }
        public void AppendNewLine(string content)
        {
            _doc.Append(content);
            _doc.Append(" " + Environment.NewLine);
        }
        public void AppendLink(string linkName, string url) => _doc.Append($"[{linkName}]({url}) ");
        public void AppendOnlineImg(string imgName, string url)
        {
            _doc.Append($"![{imgName}]({url}) ");
        }
        public void AppendTable(MDTable table)
        {
            _doc.Append(table.ToString());
        }
        public string Save() => _doc.ToString();

        private void AppendTitle(int level, string content)
        {
            if (level > 6) level = 6;
            for (int i = 0; i < level; i++)
                _doc.Append("#");
            _doc.Append(" ");
            _doc.Append(content);
            _doc.Append(Environment.NewLine);
        }
    }
}
