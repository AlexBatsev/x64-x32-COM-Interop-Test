using System;

namespace ComClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // The following is commented due to missing reference to x86TestComServer and the code not compiling
            /* 
            Type type = typeof(x86TestComServer.Factory);
            var obj = Activator.CreateInstance(type);
            var factory = (x86TestComServer.IFactory) obj;
            var twoPlusOne = factory.PlusOne(2);
            */

            Console.WriteLine("Hello World!");
        }
    }
}
