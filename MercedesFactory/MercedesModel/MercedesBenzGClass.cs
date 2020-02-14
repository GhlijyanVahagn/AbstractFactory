using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryImplementation
{
    public class MercedesBenzGClass : IOffroad
    {
        public void Create()
        {
            Console.WriteLine("Created Mercedes Benz G class \n");
        }

        public void MakeRestyle()
        {
            Console.WriteLine("Made Mercedes Benz G class 4x4 And Amg Restyle \n");

        }
    }
}
