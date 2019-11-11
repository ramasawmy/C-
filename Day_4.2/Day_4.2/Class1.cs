using System;

namespace Day_4._2
{
    class Customer
    {
        public int CustomerID { get; set; }
        public String Name { get; set; }
        public string Email { get; set; }

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
            Console.WriteLine("Bal " + Balance);
        }
    }
    public class Class1
    {
        static void Main(String[] args)
        {
            Customer C = new Customer()
            {
                CustomerID = 123,
                Name = "Steven",
                Email = "Steven@gmail.com"
            };

            BankCustomer BC = new BankCustomer()
            {
                CustomerID = 124,
                Name = "Peter",
                Email = "Peter@gmail.com",
                AccountNumber = 12345,
                Balance = 5000

            };

            BC.Details();
            BC.BankCustomerDetails();

            C.Details();

        }


    }
}
