using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Task1
    {
        static void Main(string[] args) {
            //Currency,  Integer,  Scientific, Fixed-point, General, Number, Hexadecimal
            
            Console.WriteLine("Unesi prvi broj: ");
            string num1 = Console.ReadLine();
            Console.WriteLine("Unesi drugi broj: ");
            string num2 = Console.ReadLine();

            try {
                int number1 = Int32.Parse(num1);
                int number2 = Int32.Parse(num2);
                double rez = number1 / (double)number2;

                //currency
                Console.WriteLine(rez.ToString("C", CultureInfo.CurrentCulture));
                //integer
                Console.WriteLine(Convert.ToInt32(rez));
                //scientific
                Console.WriteLine(rez.ToString("E"));
                //fixed point
                Console.WriteLine(rez.ToString("F"));
                //general
                Console.WriteLine(rez.ToString("G"));
                //number
                Console.WriteLine(rez.ToString("N"));
                //hexadecimal
                Console.WriteLine(Convert.ToInt32(rez).ToString("X"));

            }
            catch (Exception e){
                Console.WriteLine("Unable to parse, exception: " + e);
            }

        }
    }
}
