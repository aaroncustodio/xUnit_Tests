using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            EmailValidator ev = new EmailValidator();

            Console.WriteLine(ev.ValidateEmail("@gmail.com"));
            Console.WriteLine(ev.ValidateEmail("hello.gmail@com")); 
            Console.WriteLine(ev.ValidateEmail("gmail")); 
            Console.WriteLine(ev.ValidateEmail("hello@gmail"));
            Console.WriteLine(ev.ValidateEmail("hello@edabit.com"));
            
            Console.ReadKey();
        }
    }
}
