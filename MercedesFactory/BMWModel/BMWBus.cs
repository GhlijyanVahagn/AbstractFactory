using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryImplementation.BMWModel
{
    public class BMWBus : IBus
    {
        public void Create()
        {
            Console.WriteLine("Creating Bmw Bus model"); 
        }

        public void SetPessangerSeats()
        {
            Console.WriteLine("Setting Passeners seats for Bmw Bus");


        }
    }
}
