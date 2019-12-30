using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();
            //TypeSafeCollections();
            //CollectionPropertyAndMethodsWork();

            Dictionary<string, string> dictionary = new Dictionary<string, string>(); //ANAHTAR VE DEĞERİN HANGİ TÜRDE OLACAĞINI BELİRLERİZ EN BAŞTA 
            dictionary.Add("book","kitap");
            dictionary.Add("table", "tablo");
            dictionary.Add("computer", "bilgisayar");

            Console.WriteLine(dictionary["table"]);
            //Console.WriteLine(dictionary["glass"]);

            foreach (var item in dictionary)
            {
                Console.WriteLine("*****************KEY*******************");
                Console.WriteLine(item.Key);
                Console.WriteLine("*****************VALUE*******************");
                Console.WriteLine(item.Value);
            }

            Console.WriteLine(dictionary.ContainsKey("glass"));
            Console.WriteLine(dictionary.ContainsKey("table"));

            Console.ReadLine();
        }

        private static void CollectionPropertyAndMethodsWork()
        {
            // KULLANILAN METODLARIN PARAMETRELERİNİN ALDIĞI DEĞERLER, LİSTENİN HANGİ TÜRDEN ELEMAN SAKLADIĞINA BAĞLI
            // CUSTOMER İSE CUSTOMER CLASSINDAN REFERANSLARI GÖNDEREBİLİRİZ METODLARIN PARAMETRELERİNE
            List<Customer> customers = new List<Customer>
            {
                new Customer { Id = 1, FirstName = "Engin" },
                new Customer { Id = 2, FirstName = "Derin" }
            };

            // liste içindeki eleman sayılarını verir
            var count = customers.Count;

            // böyle bir kullanım da mevcut
            var newCustomer = new Customer { Id = 3, FirstName = "Salih" };
            customers.Add(newCustomer);

            // bu metodla listeye ekleyeceğimiz şey, customer array olabilir veya customer listesi olabilir
            customers.AddRange(new Customer[2]
            {
                new Customer{ Id=4, FirstName = "Ali"},
                new Customer{ Id=5, FirstName = "Ayşe"}
            });

            // bu referansa sahip eleman varsa veya referansı tutan bir değişken gönderirsek ve varsa true değer döner
            //Console.WriteLine(customers.Contains("Engin")); HATA VERİR ÇÜNKÜ REFERANS İSTER
            Console.WriteLine(customers.Contains(new Customer { Id = 1, FirstName = "Engin" })); // FALSE ÇIKAR ÇÜNKÜ NEWLEDİK. NEWLEYİNCE DE YENİ BİR REFERANS OLUŞUR
            Console.WriteLine(customers.Contains(newCustomer)); // newCustomer POİNTERI BİR REFERANS TUTAR

            // belli bir yere eklemek istersek kullanırız insertü. add kullanırsak sadece sona ekler
            customers.Insert(0, newCustomer);

            // index bulma
            var index = customers.IndexOf(newCustomer);
            var indexFromLast = customers.LastIndexOf(newCustomer);
            Console.WriteLine("Index : {0}", index);
            Console.WriteLine("LastIndex : {0}", indexFromLast);
            var newCustomer2 = new Customer { Id = 6, FirstName = "Salih" };
            customers.Add(newCustomer2);
            var indexFromLast2 = customers.LastIndexOf(newCustomer2);
            Console.WriteLine("SecondLastIndex : {0}", indexFromLast2);

            // listeyi temizler
            //customers.Clear();

            customers.Remove(newCustomer2);
            customers.RemoveAll(c => c.FirstName == "Salih");

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }
            Console.WriteLine("Count : {0}", count);
        }

        private static void TypeSafeCollections()
        {
            List<string> cities = new List<string>(); // list koleksiyonunda sadece ve sadece stringle çalışabilirim anlamına geliyor bu satır
            cities.Add("Ankara");
            cities.Add("İstanbul");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id = 1, FirstName = "Engin" });
            //customers.Add(new Customer { Id = 2, FirstName = "Derin" });
            // BAŞKA BİR KULLANIM

            List<Customer> customers = new List<Customer>
            {
                new Customer { Id = 1, FirstName = "Engin" },
                new Customer { Id = 2, FirstName = "Derin" }
            };

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }
        }

        private static void ArrayList()
        {
            /*
                        string[] cities = new string[2] { "Ankara", "İstanbul"};
                        cities[2] = "Adana"; // yeni bir veri eklemeye çalışınca arraye ekleyemiyoruz bu gibi sorunlara collectionlar ile çözüm buluruz
                        */

            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");
            cities.Add("İstanbul");
            cities.Add(1);
            cities.Add('A');


            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
