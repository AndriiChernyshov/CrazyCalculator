using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CrazyCalculatorLibrary.ResultItem
{
    [DebuggerDisplay("ID = {Id}, Result = {" + nameof(Result) +"}")]
    public class ResultItem
    {
        public Guid Id { get; set; }

        public int Result { get; set; }

        public string FormattedResult { get; set; }

        public string OperationType { get; set; }

        private int _leftOperator;
        public int LeftOperator
        {
            get
            {
                return _leftOperator;
            }
            set
            {
                _leftOperator = value;
            }
        }

        private int _rightOperator;

        public void SetRightOperator(int rightOperator)
        {
            _rightOperator = rightOperator;
        }

        public int GetRightOperator()
        {
            return _rightOperator;
        }
    }
}
