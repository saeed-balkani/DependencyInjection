using MethodInterfaceInjection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodInterfaceInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.Inject(new Subject());

            Console.WriteLine(" Search Result :");
            Console.WriteLine("  " + book.SubjectIsAlive());
            Console.ReadKey();
        }
    }
}
