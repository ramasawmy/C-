using System;

namespace InheritanceEg1
{
    class Customer
    {
        public int CustomerID { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }

        public void Details()
        {
            Console.WriteLine("CustomerID " + CustomerID);
        }
    }

    class BankCustomer:Customer
    {
        public int AccountNumber { get; set; }
        public double Balance { get; set; }

        public void BankCustomerDetails()
        {
            Console.WriteLine("CustomerID " + CustomerID);
            Console.WriteLine("Bal " + Balance );
        }
    }

    public class Program
    {
        static void Main(String[] args)
        {
            Customer C = new Customer()
            {
                CustomerID = 123,
                Name = "Peter",
                Email = "Peter@gmail.com"
            };

            BankCustomer BC = new BankCustomer()
            {
                CustomerID = 124,
                Name = "Jack",
                Email = "Jack@gmail.com",
                AccountNumber = 12345,
                Balance = 5000,
            };

            BC.Details();
            BC.BankCustomerDetails();  

            C.Details();

        }
    }
}
