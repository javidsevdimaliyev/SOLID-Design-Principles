namespace Single_Responsibility_Principle
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

        public List<Customer> GetCustomers()
        {
            return customers;
        }
    }

    public class CustomerReportGenerator
    {
        public void GenerateReport(List<Customer> customers)
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
