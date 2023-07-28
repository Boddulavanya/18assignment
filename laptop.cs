using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConAppAssignment18.iconnectable;
using static ConAppAssignment18.idisplayable;
using static ConAppAssignment18.irechargable;

namespace ConAppAssignment18
{
    internal class laptop
    {
        internal class Laptop : IConnectable, IRechargable, IDisplayable
        {
            int charge;
            string info;
            public Laptop()
            {
                charge = 0;
                info = "";
            }
            public int Charge(int minutes)
            {
                charge += minutes;
                return charge;
            }

            public bool Connect()
            {
                Console.WriteLine("COnnected Successfully to Laptop!!");
                return true;
            }

            public string Display()
            {
                Console.WriteLine("Charging Time: " + charge + " minutes");
                return info;
            }
        }
    }
}
               