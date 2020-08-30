using System;
using System.Collections.Generic;
using System.Text;

namespace CrazyCalculatorLibrary
{
    public class CrazyCalculatorCoolResult
    {
        public ResultItem.ResultItem Addition(int a, int b)
        {
            var c = a + b;
            ResultItem.ResultItem resultItem = new ResultItem.ResultItem();
            resultItem.Id = Guid.NewGuid();
            resultItem.Result = c;
            resultItem.LeftOperator = a;
            resultItem.SetRightOperator(b);
            resultItem.OperationType = "Addddition";
            resultItem.FormattedResult = c.ToString("D5");
            return resultItem;
        }
    }
}
