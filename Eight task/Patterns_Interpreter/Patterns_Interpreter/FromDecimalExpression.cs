using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns_Interpreter
{
    class FromDecimalExpression : ConversionExpression
    {
        public override string ToBinary(string data)
        {
            int integerForm = Convert.ToInt32(data);
            string newData = Convert.ToString(integerForm, 2);
            return newData;
        }

        public override string ToDecimal(string data)
        {
            return data;
        }


        public override string ToOctal(string data)
        {
            int integerForm = Convert.ToInt32(data);
            string newData = Convert.ToString(integerForm, 8);
            return newData;
        }

        public override string ToHexadecimal(string data)
        {
            int integerForm = Convert.ToInt32(data);
            string newData = Convert.ToString(integerForm, 16);
            return newData;
        }
    }
}
