using System;

namespace Encapsulation_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var _base = new Base();
            var derived = new Derived();

            // I have  access to these with the base object
            Console.WriteLine(_base.public_Balance);
            Console.WriteLine(_base.internal_Balance);
            Console.WriteLine(_base.protected_Internal_Balance);

            // I have access to these with the derived object 
            Console.WriteLine(derived.public_Balance);
            Console.WriteLine(derived.protected_Internal_Balance);
            Console.WriteLine(derived.internal_Balance);


            derived.PrivateProtectedMethod();
            
        }
    }
}
