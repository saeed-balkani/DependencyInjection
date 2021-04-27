using PropertyInjection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyInjection.Services
{
    public interface ISubject
    {
        List<Subject> SearchSubject(string subjectName);
        List<Subject> DescendingSortSubject();
    }
}
