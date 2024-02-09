using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workspace
{
    class Program
    {
        static void Main(string[] args)
        {

            SelamVer("Ediz");

            //int sonuc = Topla(6,15);

            Person person1 = new Person();
            person1.FirstName = "EDİZ";
            person1.LastName = "TEKER";
            person1.BirthDate = 2003;
            person1.NationalIdentity = 123;



            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);


            Console.ReadLine();

        }

        


        static void SelamVer(string isim = "isimsiz")
        {
            Console.WriteLine("Merhaba " + isim);

        }

  
        static int Topla(int sayi1 = 5, int sayi2 = 10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : "+ sonuc.ToString());
            return sonuc;
        }

    }
}