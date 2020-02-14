using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            ISedan sedan;
            IBus bus;
            IOffroad offRoad;
            MachineAbstractFactory factory = MachineFactory.GetFactory(EcarTypes.Mercedes);

            Console.WriteLine(new string('*', 30));

            sedan = factory.CreateSedanObject();
            sedan.Create();
            sedan.MakeComfortable();

            bus = factory.CreateBusObject();
            bus.Create();
            bus.SetPessangerSeats();

            offRoad = factory.CreateOffroadObject();
            offRoad.Create();
            offRoad.MakeRestyle();
       



          

            factory = MachineFactory.GetFactory(EcarTypes.BMW);

            Console.WriteLine(new string('*', 30));

            sedan = factory.CreateSedanObject();
            sedan.Create();
            sedan.MakeComfortable();

            bus = factory.CreateBusObject();
            bus.Create();
            bus.SetPessangerSeats();

            offRoad = factory.CreateOffroadObject();
            offRoad.Create();
            offRoad.MakeRestyle();
            Console.Read();
        }
    }
    

   

   

  









   

  

 

   
    


}
