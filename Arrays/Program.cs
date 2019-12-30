using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] students = new string[3]; //Eleman Sayısı Başta Neyse Odur...
            students[0] = "Engin";
            students[1] = "Derin";
            students[2] = "Salih";

            string[] students2 = new[] { "Engin2", "Derin2", "Salih2" }; //Eleman Sayısı Başta Neyse Odur...
             
            string[] students3 = { "Engin3", "Derin3", "Salih3" };  //Eleman Sayısı Başta Neyse Odur...

            foreach (var student in students3)
            {
                Console.WriteLine(student);
            }
            */
            string[,] regions = new string[5, 3] // 0'dan BAŞLANMAZ 1 DEN BAŞLAR 7 VE 3 KISMI
            {
                {"İstanbul","İzmit","Balıkesir" },
                { "Ankara","Konya","Kırıkkale" },
                { "Antalya","Adana","Mersin" },
                {"Rize","Trabzon","Samsun"  },
                { "İzmir","Muğla","Manisa" },
            };
            
            for (int i = 0; i <= regions.GetUpperBound(0); i++) // 5 0. dimension ve 3 1. dimension
            {   //regions.GetUpperBound(0) bize 0,1,2,3,4 döner
                for (int j = 0; j <= regions.GetUpperBound(1); j++)  //regions.GetUpperBound(0) bize 0,1,2 döner
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("*************************************************************");
            }
            /*
            for (int i = 0; i <= 4; i++) 
            {   
                for (int j = 0; j <= 2; j++)  
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("*************************************************************");
            }
            */
            Console.ReadLine();
        }
    }
}
