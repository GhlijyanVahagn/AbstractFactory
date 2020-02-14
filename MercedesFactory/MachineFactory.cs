using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryImplementation
{
    public static class MachineFactory
    {
        public static MachineAbstractFactory GetFactory(EcarTypes type)
        {
            switch (type)
            {
                case EcarTypes.Mercedes:
                    return new MercedesFactory();
                case EcarTypes.BMW:
                    return new BMWFactory();

                default: return null;

            }
        }
    }
}
