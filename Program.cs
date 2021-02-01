using System;

namespace BankCustomerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri customer1 = new Musteri();
            customer1.id = 1;
            customer1.name = "Aydın";
            customer1.surName="Deneme";
            customer1.creditRating = 1.5;

            Musteri customer2 = new Musteri();
            customer2.id = 2;
            customer2.name = "Cemal";
            customer2.surName = "Deneme";
            customer2.creditRating = 10.2;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.CustomerAdding(customer1);
            musteriManager.CustomerAdding(customer2);
            musteriManager.CustomerList();


            musteriManager.CustomerDelete(customer2);
            Console.WriteLine("Müşteri 2'yi Sildikten sonra!");
            musteriManager.CustomerList();

    
        }
    }
}
