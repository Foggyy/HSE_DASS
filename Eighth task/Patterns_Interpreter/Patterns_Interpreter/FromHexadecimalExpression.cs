using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns_Interpreter
{
    class FromHexadecimalExpression : ConversionExpression
    {
        public override string ToBinary(string data)
        {
            int integerForm = Convert.ToInt32(data, 16);
            string result = Convert.ToString(integerForm, 2);

            return result;
        }

        public override string ToDecimal(string data)
        {
            int result = Convert.ToInt32(data, 16);
            return Convert.ToString(result);
        }


        public override string ToOctal(string data)
        {
            int integerForm = Convert.ToInt32(data, 16);
            string result = Convert.ToString(integerForm, 8);

            return result;
        }

        public override string ToHexadecimal(string data)
        {
            return data;
        }
    }
}
