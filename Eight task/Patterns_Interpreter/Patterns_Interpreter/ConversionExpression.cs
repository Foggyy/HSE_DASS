using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns_Interpreter
{
    abstract class ConversionExpression
    {
        public abstract string ToDecimal(string data);
        public abstract string ToBinary(string data);
        public abstract string ToOctal(string data);
        public abstract string ToHexadecimal(string data);

        public void Interpret(Context context)
        {
            if(context.newNumberSystem == "2")
            {
                context.Output = ToBinary(context.dataToConvert);
            }
            else if(context.newNumberSystem == "8")
            {
                context.Output = ToOctal(context.dataToConvert);
            }
            else if(context.newNumberSystem == "10")
            {
                context.Output = ToDecimal(context.dataToConvert);
            }
            else if(context.newNumberSystem == "16")
            {
                context.Output = ToHexadecimal(context.dataToConvert);
            }
        }
    }
}
