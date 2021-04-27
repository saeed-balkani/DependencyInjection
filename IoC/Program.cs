using IoC.IoC;
using IoC.Models;
using IoC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC
{
    class Program
    {
        static void Main(string[] args)
        {
            DependencyInjector injector = new DependencyInjector();
            injector.Register<Book,Book>();
            injector.Register<ISubject, Subject>();
            var book = injector.Dependency<Book>();
            Console.WriteLine(" Search Result :");
            Console.WriteLine("  " + book.SubjectIsAlive());
            Console.ReadKey();
        }
    }
}
