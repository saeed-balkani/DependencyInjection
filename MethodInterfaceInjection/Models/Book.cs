using MethodInterfaceInjection.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodInterfaceInjection.Models
{
    public class Book : IAccessToDependency
    {
        private ISubject _subject;
        public void Inject(ISubject subject)
        {
            _subject = subject;
        }

        public string SubjectIsAlive()
        {
            int check = _subject.SearchSubject("History").Count();
            if (check > 0)
            {
                return "This Subject Exist in our Library.";
            }
            return "This Subject Does not Exist in our Library.";
        }
    }
}
