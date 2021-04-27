using IoC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC.Services
{
    public interface ISubject
    {
        List<Subject> SearchSubject(string subjectName);
    }
}
