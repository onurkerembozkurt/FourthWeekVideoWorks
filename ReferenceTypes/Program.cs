using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //We are looking at Reference Typces
            int number1 = 10;
            int number2 = 20;
            number1 = number2;
            Console.WriteLine(number1);
            /*Bu sıklıkla temel mantıgı anlamak için sorulan bir sorudur
             number1 is variable of int and also decimal float enum and boolean, these
            are value types.
            We are reading like this;
            number1 is 10, number2 is 20 and if we say number1=number2 so number1 value's is gonna 
            be number2 cause of value types
            So lets talk about what is going on ram
            Field of value type'name is Stack Ram
            so how is it works
            all those works are working only stack field of ram 
            but if we would create array under lets look what is going on 
            ARRAYS,CLASSES,interfaces .... are reference types
            so how it is works
            We would say there is a stack field of ram but if we would created reference type variable
            also that here is working heap field when we are saying "new" that will be adress at heap

             */
            int[] sayilar = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };
            sayilar= sayilar2;
            /*We are reading above like sayilar'adreses equals to sayilar2' adresess*/
            sayilar2[0] = 1000;
            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin";
            person2 = person1;
            Console.WriteLine(person2.FirstName);
            person1.FirstName = "Derin";
          
            Employee employee = new Employee();
            //We cant say employee=customer
            //Çünkü Türleri aynı değil biri Employee den biri Customer dan
            //that is also like try to equal int to string or vice and versa
            Console.WriteLine(person2.FirstName);
            Customer customer = new Customer();
            customer.CreditCardNumber = "123232";
            customer.FirstName = "Salih";
            Person person3 = customer;

            /*Az önce customer ile person u birbirine atıyamıyorken şimdi ise customer ile person3 
             yukardaki gibi atamış olduk neden ?
            Çünkü Customer bir Persondır : kalıtımdan dolayı
            Yani miras aldıgınız sınıfı miras alan kişiye atayabiliriz
            Çünkü Person Base Class 
            Base class a onu İNHERİT EDEN SINIFLARIN referans adresini atayabiliriz.
             
            yani person 3 customer in adresini tutuyor
            customer in first nameini gelip ahmet yaparsak
            aslında biz aynı adresi değiştirmiş oluıyoruz
            person3 de o zaman niye credit kart numarasını görmüyoruz
            bu tamamen Person classının şablonundan dolayı
            aynı adresi tuttugundan ispatlayalım


            */

            // AKLINDAKİNİ YAP
            Console.WriteLine(((Customer)person3).CreditCardNumber);//Boxing yöntemi
            //boxing yöntemi ile credit card numarasını görebiliriz sadece class şablonundan
            //dolayı göremiyoruz yani düz person3 den ulaşamıyoruz.
            //Şimdi diyebilirsiniz ki ben customer yapmak istesem customerdan giderim şimdi ona bakalım
            //Çünkü base sınıfı Person oldugundan dolayı hepsine ulaşabiliriz.

            PersonManager personManager = new PersonManager();
            personManager.Add(customer);
        }
       
        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
        class Customer : Person
        {
            public string CreditCardNumber { get; set; }
        }
        class Employee : Person
        {
            public int EmployeeNumber { get; set; }
        }
        class PersonManager
        {
            public void Add(Person person)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}
