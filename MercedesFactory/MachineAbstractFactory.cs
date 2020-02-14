using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryImplementation
{
    public interface MachineAbstractFactory
    {
        IBus CreateBusObject();
        ISedan CreateSedanObject();
        IOffroad CreateOffroadObject();
    }
}
