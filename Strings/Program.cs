using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro();
            string sentence = "My name is Arif Tarpıcı";

            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "My name is Ali Kaykule";

            bool result3 = sentence.EndsWith("ı");
            bool result4 = sentence.StartsWith("My");
            var result5 = sentence.IndexOf("name"); // bulmazsa -1 döndürür
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf(" ");
            var result8 = sentence.Insert(0,"Hello, ");
            var result9 = sentence.Substring(3);
            var result10 = sentence.Substring(3,4);
            var result11 = sentence.ToLower();
            var result12 = sentence.ToUpper();
            var result13 = sentence.Replace(" ","-");
            var result14 = sentence.Remove(2);
            var result15 = sentence.Remove(2,5);

            Console.WriteLine(result15);
            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Ankara";
            Console.WriteLine(city[0]);
            string city2 = "İstanbul";
            /*
            string result = city + city2;
            Console.WriteLine(result);
            */
            Console.WriteLine(String.Format("{0} {1}", city, city2));
        }
    }
}
