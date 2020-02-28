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
            string num1, num2;
            int number1, number2;
            double rez;

            Console.WriteLine("Unesi prvi broj: ");
            num1 = Console.ReadLine();
            Console.WriteLine("Unesi drugi broj: ");
            num2 = Console.ReadLine();

            try {
                number1 = Int32.Parse(num1);
                number2 = Int32.Parse(num2);
                rez = (double)number1 / (double)number2;

                Console.WriteLine(rez.ToString("C", CultureInfo.CurrentCulture));

                try {
                    int num;
                    num = (int)rez;
                    Console.WriteLine(num);
                }
                catch (FormatException) {
                    Console.WriteLine($"Unable to parse INTEGER!");
                }

                Console.WriteLine(rez.ToString("E"));

                Console.WriteLine(rez.ToString("F"));

                Console.WriteLine(rez.ToString("G"));

                Console.WriteLine(rez.ToString("N"));

                try {
                    int num;
                    num = (int)rez;
                    Console.WriteLine(num.ToString("x"));
                }
                catch (FormatException) {
                    Console.WriteLine($"Unable to parse HEXADECIMAL!");
                }

            }
            catch (FormatException) {
                Console.WriteLine($"Unable to parse");
            }

            Console.ReadLine();

        }
    }
}
