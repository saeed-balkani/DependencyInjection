using PropertyInjection.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyInjection.Models
{
    public class Book
    {
        private ISubject _subject;
        public ISubject subjectObj
        {
            get { return _subject; }
            set { this._subject = value; }
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
