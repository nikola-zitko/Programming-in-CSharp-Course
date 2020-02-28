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
            double num1;
            while (!double.TryParse(Console.ReadLine(), out num1)) {
                Console.WriteLine("Krivi unos! Unesi prvi broj: ");
            }
            Console.WriteLine("Unesi drugi broj: ");
            double num2;
            while (!double.TryParse(Console.ReadLine(), out num2) || num2 == 0) {
                Console.WriteLine("Krivi unos! Unesi drugi broj: ");
            }

            try {
               
                double rez = num1 / num2;
                
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
                Console.WriteLine("Unable to convert to Int, exception: " + e);
            }

        }
    }
}
