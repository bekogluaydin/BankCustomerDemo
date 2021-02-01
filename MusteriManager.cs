using System;
using System.Collections.Generic;
using System.Text;

namespace BankCustomerDemo
{
    class MusteriManager
    {
        List<Musteri> Customers = new List<Musteri>();
        public void CustomerAdding(Musteri customer)
        {
            if (Customers!=null)
            {
                Customers.Add(customer);
                Console.WriteLine("ID'si" + customer.id + "olan müşteri sisteme eklendi ");
            }
            else
            {
                foreach (Musteri customers in Customers)
                {
                    Console.WriteLine("foreach girdi");
                    if (customers.id == customer.id)
                    {
                        Console.WriteLine("Bu id'ye ait bir müşteri mevcut!!!");
                        return;
                    }
                    else
                    {
                        Customers.Add(customer);
                        Console.WriteLine("ID'si " + customer.id + " olan müşteri sisteme eklendi ");
                    }
                }
            }
        }

        public void CustomerList()
        {
            foreach (Musteri customer in Customers)
            {
                Console.WriteLine("ID: " + customer.id + "\n Ad:" + customer.name + "\n Soyad:" + customer.surName + "\n Kredi Notu: " + customer.creditRating);
            }
        }
        public void CustomerDelete(Musteri customer)
        {
            if (Customers.Contains(customer))
            {
                Customers.Remove(customer);
                Console.WriteLine("Müşteri başarıyla silindi!");
                return;
            }
            else Console.WriteLine("sistemde böyle bir müşteri yok!");
        }
    }
}
