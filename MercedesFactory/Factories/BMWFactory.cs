using AbstractFactoryImplementation.BMWModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryImplementation
{
    public class BMWFactory : MachineAbstractFactory
    {
        public IBus CreateBusObject()
        {
            return new BMWBus();
        }

        public IOffroad CreateOffroadObject()
        {
            return new BMWModelX6();
        }

        public ISedan CreateSedanObject()
        {
            return new BMWModelF10();

        }
    }
}
