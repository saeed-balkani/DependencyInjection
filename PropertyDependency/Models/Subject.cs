using PropertyInjection.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyInjection.Models
{
    public class Subject : ISubject
    {
        public string SubjectName { get; set; }
        public List<Subject> SearchSubject(string subjectName)
        {
            return SubjectItems().Where(a => a.SubjectName == subjectName).ToList();
        }
        public List<Subject> DescendingSortSubject()
        {
            return SubjectItems().OrderByDescending(a => a.SubjectName).ToList();
        }
        public static List<Subject> SubjectItems()
        {
            List<Subject> db = new List<Subject>();
            db.Add(new Subject() { SubjectName = "History" });
            db.Add(new Subject() { SubjectName = "Romance" });
            return db;
        }
    }
}
