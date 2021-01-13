using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation_Demo
{
    public class Base
    {
        // Base has access 

        public int public_Balance = 0;
        private int _private_Balance = 0;
        protected int protected_Balance = 0; // This one
        internal int internal_Balance = 0;
        private protected int _private_Protected_Balance = 0; //This one 
        protected internal int protected_Internal_Balance = 0;
       

        //Try a method call
        protected void ProtectedMethod()
        {
            Console.WriteLine("I'm inside of a protected method");

            // Here we create a base object (which inherits from our Test class in the ClassLibrary) and we have access to the protectedField
            var protectedObject = new Base();
            Console.WriteLine(protectedObject.protectedField); 
        }

        private protected void PrivateProtectedMethod()
        {
            Console.WriteLine("I'm inside of a private protected method");

            // Here we get an error because we CANNOT access a private protected field out side of the assembly that it was created in (even though we used inheritance)
            var privateProtectedObject = new Base();
            Console.WriteLine(privateProtectedObject);//<---.privateProtectedField);
        }




    }
}
