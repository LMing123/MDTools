using System;
using System.Collections.Generic;
using System.Text;

namespace MDTools
{
    public class MDTable
    {
        public enum AlignMode
        {
            center,
            left,
            right
        }
        StringBuilder _table;
        public MDTable()
        {
            _table = new StringBuilder(Environment.NewLine);
        }
        public void CreateTable(string[] titles, AlignMode alignMode)
        {
            if (titles.Length == 0) return;
            for (int i = 0; i < titles.Length; i++)
            {
                _table.Append($"| {titles[i]}");
            }
            _table.Append("|\n");
            string am = "";
            switch (alignMode)
            {
                case AlignMode.center: am = ":-:"; break;
                case AlignMode.left: am = "-:"; break;
                case AlignMode.right: am = ":-"; break;
            }
            for (int i = 0; i < titles.Length; i++)
            {
                _table.Append($"|{am}");
            }
            _table.Append("|\n");
        }
        public void AppendRow(string[] row)
        {
            if (row.Length == 0) return;
            for (int i = 0; i < row.Length; i++)
            {
                _table.Append($"|{row[i]}");
            }
            _table.Append("|\n");
        }
        public override string ToString()
        {
            var content = _table.ToString();
            return string.IsNullOrEmpty(content) ? "" : _table.ToString();
        }
    }
}
