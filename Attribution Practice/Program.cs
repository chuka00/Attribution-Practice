using System.Reflection;

namespace Attribution_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Customer customer = new();
            customer.GetDocs();

            /*TypeInfo typeInfo = typeof(Customer).GetTypeInfo();
            Console.WriteLine("The assembly qualified name of MyClass is " + typeInfo.AssemblyQualifiedName);*/
        }
    }
}