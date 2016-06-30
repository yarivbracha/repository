using System;
using System.Collections.Generic;

namespace Using_Delegate
{
    class Program
    {
        delegate bool CustomerFilter(Customer customer);

        public static void Main(string[] args)
        {
            Program program = new Program();
            Customer first = new Customer("Avi", 1, "Haifa");
            Customer second = new Customer("Zvi", 2, "Holon");
            Customer third = new Customer("beni", 3, "Tel - Aviv");
            Customer fourth = new Customer("Shimon", 250, "Jerusalem");
            List<Customer> customers = new List<Customer>();
            customers.Add(first);
            customers.Add(second);
            customers.Add(third);
            customers.Add(fourth);
            Console.WriteLine("Customers before filter:\n");
            program.PrintCustomers(customers);
            ICollection<Customer> returnedCustomers = GetCustomers(customers, new CustomerFilter(program.BetweenAToK));
            Console.WriteLine("\nCustomers after A-K filter:\n");
            program.PrintCustomers(returnedCustomers);
            returnedCustomers = GetCustomers(customers, delegate (Customer customer)
            {
                if (!String.IsNullOrEmpty(customer.Name))
                {
                    if (((customer.Name[0] >= 'L') && (customer.Name[0] <= 'Z')) || ((customer.Name[0] >= 'l') && (customer.Name[0] <= 'z')))
                    {
                        return true;
                    }
                }
                return false;
            });
            Console.WriteLine("\nCustomers after L-Z filter:\n");
            program.PrintCustomers(returnedCustomers);
            returnedCustomers = GetCustomers(customers, customer =>
            {
                if (customer.ID < 100)
                {
                    return true;
                }
                return false;
            });
            Console.WriteLine("\nCustomers after ID < 100 filter:\n");
            program.PrintCustomers(returnedCustomers);
        }

        private static ICollection<Customer> GetCustomers(ICollection<Customer> customers, CustomerFilter filter)
        {
            ICollection<Customer> customersCollection = new List<Customer>();
            foreach (Customer customer in customers)
            {
                if (filter(customer))
                {
                    customersCollection.Add(customer);
                }
            }
            return customersCollection;
        }

        private bool BetweenAToK(Customer customer)
        {
            bool isInRange = false;
            if (!String.IsNullOrEmpty(customer.Name))
            {
                if (((customer.Name[0] >= 'A') && (customer.Name[0] <= 'K')) || ((customer.Name[0] >= 'a') && (customer.Name[0] <= 'k')))
                {
                    isInRange = true;
                }
            }
            return isInRange;
        }

        private void PrintCustomers(ICollection<Customer> customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer);
            }
        }
    }
}
