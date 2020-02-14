using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryImplementation.BMWModel
{
    public class BMWModelX6 : IOffroad
    {
        public void Create()
        {
            Console.WriteLine("BMW Offroad X6 \n");

        }

        public void MakeRestyle()
        {
            Console.WriteLine("Made BMW Offroad X6 make Xdrive style \n");
        }
    }
}
