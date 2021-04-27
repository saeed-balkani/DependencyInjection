using ConstructorInjection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book(new Subject());
            Console.WriteLine(" Search Result :");
            Console.WriteLine("  " + book.SubjectIsAlive());
            Console.ReadKey();

        }
    }
}
