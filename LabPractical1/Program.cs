using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPractical1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Please enter a number");
            int enteredNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The number you entered is {enteredNumber}");
            Console.ReadLine();
        }
    }
}
