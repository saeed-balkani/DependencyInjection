using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodInterfaceInjection.Services
{
    public interface IAccessToDependency
    {
        void Inject(ISubject subject);

    }
}
