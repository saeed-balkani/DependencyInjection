using IoC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC.Models
{
    public class Book
    {
        ISubject _subject;
        public Book(ISubject subject)
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
