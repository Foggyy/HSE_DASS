using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns_Interpreter
{
    class FromOctalExpression : ConversionExpression
    {
        public override string ToBinary(string data)
        {
            int integerForm = Convert.ToInt32(data, 8);
            string result = Convert.ToString(integerForm, 2);

            return result;
        }

        public override string ToDecimal(string data)
        {
            int result = Convert.ToInt32(data, 8);
            return Convert.ToString(result);
        }


        public override string ToOctal(string data)
        {
            return data;
        }

        public override string ToHexadecimal(string data)
        {
            int integerForm = Convert.ToInt32(data, 8);
            string newData = Convert.ToString(integerForm, 16);
            return newData;
        }
    }
}

