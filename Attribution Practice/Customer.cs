using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Attribution_Practice
{
    [Document("This class represents a customer in the system", Input = "Customer ID", Output = "Customer details")]
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        [Document("Retrieves customer details from the database")]
        public void GetCustomerDetails(int id)
        {
            // implementation goes here
        }

        public void GetDocs()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var types = assembly.GetTypes();
            foreach (var type in types)
            {
                var attributes = type.GetCustomAttributes(typeof(DocumentAttribute), true);
                if (attributes.Length > 0)
                {
                    var document = (DocumentAttribute)attributes[0];
                    Console.WriteLine("Type: " + type.Name);
                    Console.WriteLine("Description: " + document.Description);
                    Console.WriteLine("Input: " + document.Input);
                    Console.WriteLine("Output: " + document.Output);
                    Console.WriteLine();
                }
            }
        }

    }

}
