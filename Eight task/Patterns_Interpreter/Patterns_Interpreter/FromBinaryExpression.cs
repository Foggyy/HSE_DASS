using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns_Interpreter
{
    class FromBinaryExpression : ConversionExpression
    {
        public override string ToBinary(string data)
        {
            return data;
        }

        public override string ToDecimal(string data)
        {
            int result = Convert.ToInt32(data, 2);

            return Convert.ToString(result);
        }


        public override string ToOctal(string data)
        {
            int integerForm = Convert.ToInt32(data, 2);
            string newData = Convert.ToString(integerForm, 8);
            return newData;
        }

        public override string ToHexadecimal(string data)
        {
            int integerForm = Convert.ToInt32(data, 2);
            string newData = Convert.ToString(integerForm, 16);
            return newData;
        }
    }
}
