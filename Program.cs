using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{

    class Program
    {
        static string str=null;//everything what you write
        static string num=null;//only number 
        static string ope=null;//only operater
        static decimal result=0;//output

        static void Main(string[] args)
        {
            System.Console.WriteLine("数式を入力してください");

            while (true)
            {
                str = Console.ReadLine();
                decimal d;
                if (decimal.TryParse(str, out d))
                {
                    num = str;
                }
                else if (str == "+" || str == "-" || str == "/" || str == "*" || str == "=")
                {
                    calc();
                }
            }
            Console.WriteLine("続行するには何かキーを押してください");
            Console.ReadKey();
        }
        public static void calc()
        {
            decimal number = decimal.Parse(num);
            switch (ope)
            {
                case "+":
                    result = result + number;
                    break;
                case "-":
                    result = result - number;
                    break;
                case "*":
                    result = result * number;
                    break;
                case "/":
                    if (number != 0)
                    {
                        result = result / number;
                    }
                    else
                    {
                        result = 0;
                    }
                    break;
                case null:
                    result = decimal.Parse(num);
                    break;
            }
            ope = str;
            if (ope == "=")
            {
                Console.WriteLine(result+"\n計算完了");
                Clear();
            }
            
        }
        public static void Clear()
        {
            str = null;
            num = null;
            ope = null;
            result = 0;
        }
    }
}