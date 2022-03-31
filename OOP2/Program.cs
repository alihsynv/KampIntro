using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CutomerNumber = "12345";
            customer1.FirstName = "Ali";
            customer1.LastNmae = "Huseynov";
            customer1.TcNo = "123456789";


            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CutomerNumber = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNo = "1234567890";


            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);


        }
    }
}
