using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {/*Bir Class ı new lediğimiz zaman çalışan bloktur bir kere çalışır ve bir daha çalışmaz
          Tr si  Yapıcı bloktur
            */
            Console.WriteLine("Hello World!");
            Customer customer = new Customer();
            customer.Id = 213;
            //.
            //.
            //. diye gidebiliriz. 
            Customer customer2 = new Customer { Id = 1, FirstName = "Engin", LastName = "Demirog", City = "Ankara"};
            Customer customer3 = new Customer(2, "kerem", "bozkurt", "ankara");

        }
        class Customer
        {
            //Constructor hızlı oluşturmak için CTOR  TAB TAB YAPMAN YETERLİ KANKS
            //default constructor 
            /*Constructor da metot gibidir ama sanki above side da yaptıgımız sonunda () var
             * Eger Constructor metod un imzalarını koyarsak 
             * İmza koyarak yani () içini doldurarak class instance oluşturutyoruz
             * ama eger hem yukardaki {} yaptıgım gibi ya da hem sıra sıra . ile ekleme ve hem
             * de 
             * imzali adreslere veri eklemek istiyorsak bir tane daha imzasız constructor metod u oluşrutyorz.
             * Fakat parametreli constructor da içerisi çalışıyor sadece
             * yani imzalı olanın yukarda firstname ini yazdırsak bile görüyoruz ki constructor
             * kısmında doldurdugumuz "Yapıcı blok çalıştı yazısını alıyoruz."
             * parametreli constructor blogunda biz degerleri setledik ve istedğiöiz
                şekişde çalışmasını sagladık ve biz bunu sıklıkla kullanırz demek ki constructorları
            syntaxları bu şekilde kullanuıyruz.

             */
            public Customer()
            {

            }
            public Customer(int id,string firstName,string lastName,string city)
            {
                Id= id;
                FirstName = firstName;
                LastName = lastName;
                City = city;


               

            }
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string City { get; set; }
        }
    }
}
