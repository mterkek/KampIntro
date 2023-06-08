using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethotDemo
{
    public class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Name + " müşteri eklendi.");
        }
        public void Listed(Customer customer)
        {
            Console.WriteLine("Müşteri No: " + customer.Id);
            Console.WriteLine("Müşteri Adı: " + customer.Name);
            Console.WriteLine("Müşteri Soyadı: " + customer.Surname);
            Console.WriteLine("Müşteri Adresi: " + customer.Address);

            Console.WriteLine("-----------------------------------");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine($"{customer.Id} no'lu müşteri silindi.");
        }
    }
}
