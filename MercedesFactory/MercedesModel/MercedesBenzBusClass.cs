using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryImplementation
{
    public class MercedesBenzBusClass : IBus
    {
        public void Create()
        {
            Console.WriteLine("Created Mercedes Benz Vito class \n");
        }

        public void SetPessangerSeats()
        {
            Console.WriteLine("Mercedes Benz Vito Passangers seats 26 \n");

        }
    }
}
