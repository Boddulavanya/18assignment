using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConAppAssignment18.laptop;
using static ConAppAssignment18.smartphone;

namespace ConAppAssignment18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SmartPhone smartPhone = new SmartPhone();
            smartPhone.Connect();
            smartPhone.Charge(20);
            smartPhone.Display();

            Laptop laptop = new Laptop();
            laptop.Connect();
            laptop.Charge(50);
            laptop.Display();

            Console.ReadKey();
        }
    }
}
