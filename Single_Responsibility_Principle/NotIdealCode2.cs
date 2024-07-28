using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle
{
    internal class NotIdealCode2
    {
        public class CustomerManager
        {
            private List<Customer> customers = new List<Customer>();

            public void AddCustomer(Customer customer)
            {
                customers.Add(customer);
                Console.WriteLine("Customer added: " + customer.Name);
            }

            public void RemoveCustomer(int id)
            {
                var customer = customers.Find(c => c.Id == id);
                if (customer != null)
                {
                    customers.Remove(customer);
                    Console.WriteLine("Customer removed: " + customer.Name);
                }
            }

            //Violated SRP
            public void GenerateReport()
            {
                Console.WriteLine("Generating customer report...");
                foreach (var customer in customers)
                {
                    Console.WriteLine($"Customer ID: {customer.Id}, Name: {customer.Name}");
                }
            }
        }

        public class Customer
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
        }
    }


  

}
