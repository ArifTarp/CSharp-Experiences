using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new SqlServer();
            database.Add();
            database.Delete();
            Database database1 = new Oracle();
            database1.Add();
            database1.Delete();
            Console.ReadLine();

        }
    }

    abstract class Database
    {
        // abstract classlarla hem tamamlanmış metodlar hemde tamamlanmamış metodlar yazabiliyoruz
        // add metodu her veri tabanı için aynı delete metodu ise her veri tabanı için farklı olsun
        public void Add()
        {
            Console.WriteLine("Added By Default");
        }

        public abstract void Delete();
        // add herkesde aynı delete herkesin implemente etmesi gereken metod
    }

    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted By Sql");
        }
    }

    class Oracle : Database
    {
        public override void Delete()   
        {
            Console.WriteLine("Deleted By Oracle");
        }
    }
}
