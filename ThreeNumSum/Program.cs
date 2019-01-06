using System;

namespace ThreeNumSum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int? a, b, c;
            a = getNumNull();
            b = getNumNull();
            c = getNumNull();
            if (a != null && b != null && c != null)
            {
                Console.WriteLine("{0}", a + b + c);
            }
            else
            {
                Console.WriteLine("Bad Input");
            }
        }
        static int getNum()
        {
            int val;
            string myInput;
            myInput = Console.ReadLine();
            bool res = int.TryParse(myInput, out val);
            while (!res)
            {
                myInput = Console.ReadLine();
                res = int.TryParse(myInput, out val);
            }
            return val;
        }
        static int? getNumNull()
        {
            int val;
            string myInput;
            myInput = Console.ReadLine();
            bool res = int.TryParse(myInput, out val);
            if (res)
            {
                return val;
            }
            else
            {
                return null;
            }
        }
    }
}
