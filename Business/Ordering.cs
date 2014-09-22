using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Constants
    {
        public static string SELECT_ALL_RECORDS = "SS";
        public static string PENDING = "PENDING";
        public static string NOT_PENDING = "NOT_PENDING";
    }

    public class Ordering
    {
        public void UpdateOrderApproval(IDataGrid recapView, IModel model)
        {
            var result = new List<String>();

            for (int loopIndex = 0; loopIndex < recapView.rowCount; loopIndex++)
            {
                if ((bool)recapView.getRowVellValue(loopIndex, Constants.SELECT_ALL_RECORDS))
                {
                    var data = recapView.getData(loopIndex);

                    if (data.OrderChangeStatus == Constants.PENDING)
                    {
                        result.Add(data.Value);
                    }

                }
            }

            model.update(result);

        }
    }
}
