using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation_Demo
{
    public class Derived : Base
    {
        // I have access to public, protected from Base, private from Derived, and internal
        public Derived()
        {
            protected_Balance = 5;
            _private_Protected_Balance = 10;
        }

        public void PrivateProtectedMethod()
        {
            PrivateProtectedMethod();            
            Console.WriteLine($"{_private_Protected_Balance}");
        }
        public void ProtectedMethod()
        {
            ProtectedMethod();
            Console.WriteLine($"{protected_Balance}");
        }
    }
}
