using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            sqlServer.Delete();
            MySql mySql = new MySql();
            mySql.Add();
            mySql.Delete();

            Console.ReadLine();
        }
    }

    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added By Default...");
        }
        public virtual void Delete()
        {
            Console.WriteLine("Deleted By Default...");
        }
    }

    class SqlServer : Database
    {
        public override void Add()
        {
            Console.WriteLine("Added By Sql Code");
            base.Add();
        }
    }

    class MySql : Database
    {

    }
}
