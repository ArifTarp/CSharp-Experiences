using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Value Types (Int Bir Değer Tipidir)
            //Console.WriteLine("Hello World!");
            //Console.ReadLine();
            var number7 = 10; // ASLINDA BİR DEĞİŞKEN DEĞİLDİR number7....İlk atama hangi tipte olursa sonraki atamlar'da o tipten olur
            number7 = 'A'; // Char yerine string atayamazdık
            decimal number6 = 10.4m; //int için long neyse double içinde decimal odur...
            double number5 = 10.4; //64 bit ve ondalıklı değerler tutulmak için kullanılır
            char character = 'A';
            bool condition = true; //Değer tipidir buda ve mantıksal ifadelerde kullanılır
            byte number4 = 255; //8bit
            short number3 = -32768; //16 bit
            int number1 = 2147483647; //32 bit
            long number2 = 2147483648; //64 bit  
            Console.WriteLine("Number1 is {0}",number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Character is {0} and digital value of character is {1}", character,(int)character);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Number6 is {0}", number6);
            Console.WriteLine("Index of {0} is {1}",Days.Friday,(int)Days.Friday);
            Console.WriteLine("Number7 is {0}", number7);
            Console.ReadLine();
        }
    }
    enum Days
	{   
        //Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday 
        // Indexleri Biz Belirleyebiliyoruz...
        Monday=20,Tuesday=30,Wednesday,Thursday,Friday,Saturday,Sunday  // Herbiri Birer Enum Sabitidir...   
	}
}
