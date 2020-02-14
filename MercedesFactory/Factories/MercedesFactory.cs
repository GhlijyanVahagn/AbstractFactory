using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryImplementation
{
    public class MercedesFactory : MachineAbstractFactory
    {
        public IBus CreateBusObject()
        {
            return new MercedesBenzBusClass();
        }

        public IOffroad CreateOffroadObject()
        {
            return new MercedesBenzGClass();
        }

        public ISedan CreateSedanObject()
        {
            return new MercedesBenzSClass();
        }
    }
}
