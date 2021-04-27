using ConstructorInjection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInjection.Services
{
    public interface ISubject
    {
        List<Subject> SearchSubject(string subjectName);
    }
}
