using System;
using System.Collections.Generic;

namespace Patterns_Interpreter
{
    class Program
    {

        static void Main(string[] args)
        {
            bool ok = true;
            int check = 5;
            while (ok)
            {
                Console.WriteLine("Введите число и системы счисления:");
                string task = Console.ReadLine();
                Context context = new Context(task);
                List<ConversionExpression> conversions = new List<ConversionExpression>();
                conversions.Add(new FromBinaryExpression());
                conversions.Add(new FromOctalExpression());
                conversions.Add(new FromDecimalExpression());
                conversions.Add(new FromHexadecimalExpression());

                if (context.basicNumberSystem == "2")
                {
                    conversions[0].Interpret(context);
                }
                else if (context.basicNumberSystem == "8")
                {
                    conversions[1].Interpret(context);
                }
                else if (context.basicNumberSystem == "10")
                {
                    conversions[2].Interpret(context);
                }
                else if (context.basicNumberSystem == "16")
                {
                    conversions[3].Interpret(context);
                }

                Console.WriteLine("Ответ: {0}", context.Output);
                Console.WriteLine("Перевести еще одно число? 1 - да, 0 - нет");
                check = Convert.ToInt32(Console.ReadLine());
                while (check != 1 && check != 0)
                    check = Convert.ToInt32(Console.ReadLine());

                if (check == 0)
                    ok = false;

                Console.WriteLine("\n");
            }

        }
    }
}
