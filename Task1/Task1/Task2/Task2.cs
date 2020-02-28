using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Task2
    {
        static void Main(string[] args) {

            Console.WriteLine("Unesite integer: ");
            int varInt;
            Int32.TryParse(Console.ReadLine(), out varInt);

            try {
                long Checked = checked(long.MaxValue + varInt);
            }
            catch (System.OverflowException e) {
                Console.WriteLine("OVERFLOW: " + e.ToString());
            }
            Console.ReadLine();
        }
    }
}
