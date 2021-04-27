using PropertyInjection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.subjectObj = new Subject();
            Console.WriteLine(" Search Result :");
            Console.WriteLine("  " + book.SubjectIsAlive());
            Console.WriteLine();
            Console.WriteLine(" Descending Sort :");
            int num = 0;
            foreach (var item1 in book.subjectObj.DescendingSortSubject())
            {
                Console.WriteLine($"  {++num} - " + item1.SubjectName);
            }
            Console.ReadKey();
        }
    }
}
