using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            // Value Tiplerinden Sonra...

            string[] cities1 = new string[] { "Ankara", "Adana", "Afyon"}; //101
            string[] cities2 = new string[] { "Bursa", "Bolu", "Balıkesir" }; //102//101
            cities2 = cities1;
            cities1[0] = "İstanbul";
            Console.WriteLine(cities2[0]);

            /*
            DataTable dataTable = new DataTable();
            DataTable dataTable2 = new DataTable();
            dataTable = dataTable2; // BURADA PERFORMANS PROBLEMİ VAR
            */
            // YUKARIDAKİ YERİNE BÖYLE YAPILABİLİR
            DataTable dataTable;
            DataTable dataTable2 = new DataTable();
            dataTable = dataTable2;

            Console.ReadLine();
        }
    }
}
