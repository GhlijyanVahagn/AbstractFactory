using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryImplementation
{
    public class MercedesBenzSClass : ISedan
    {
        public void Create()
        {
            Console.WriteLine("Created Mercedes Benz S class\n");
        }

        public void MakeComfortable()
        {
            Console.WriteLine("Making S class is  very Comfortable  \n");

        }
    }
}
