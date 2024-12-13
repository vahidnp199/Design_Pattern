using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concrete
{
    public class ServiceFactoryImp1 : ServiceFactory
    {
        public Service makeSvc()
        {
            return new ConcreateImp1();
        }
    }
}
