using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryImplementation.BMWModel
{
    public class BMWModelF10 : ISedan
    {
        public void Create()
        {
            Console.WriteLine("Created BMW sedan F10 class \n");

        }

        public void MakeComfortable()
        {
            Console.WriteLine("Made sedan more confortable class \n");
        }
    }
}
