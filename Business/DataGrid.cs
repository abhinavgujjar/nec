using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class Row
    {
        public string OrderChangeStatus { get; set; }
        public string Value { get; set; }
    }

    public interface IDataGrid
    {
        int rowCount { get; set; }

        bool getRowVellValue(int loopIndex, string p);

        Row getData(int loopIndex);
    }
}
