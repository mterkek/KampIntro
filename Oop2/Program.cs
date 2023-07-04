using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            RealCustomer customer1 = new RealCustomer();
            customer1.Id = 22;
            customer1.CustomerNo = "112345";
            customer1.Name = "Taha";
            customer1.SurName = "ERKEK";
            customer1.IdentificationNumber = "31313131313";


            LegalCustomer customer2 = new LegalCustomer();
            customer2.Id = 23;
            customer2.CustomerNo = "232323";
            customer2.CompanyName = "Gardaşlar Gundura";
            customer2.TaxNo = "123456789";

            Musteri customer3 = new RealCustomer();
            Musteri customer4 = new LegalCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

        }
    }
}
