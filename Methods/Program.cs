using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //var result = Add2(20, 30);
            //var result2 = Add2(20);
            //Console.WriteLine(result);
            //Console.WriteLine(result2);

            /*
            int number1 = 20;  // DEĞER TİPLERİDİR...
            int number2 = 100; // DEĞER TİPLERİDİR...
            //var result = Add3(number1, number2); // number1,number2 İLE 20,100 YAZMAK AYNI ŞEY

            // AMA number1 REFERANSINI GÖNDERMEK İSTERSEK ref KEYWORD KULLANIRIZ... ref KEYWORD DİĞER ALTERNATİFİ out KEYWORD
            // ref VE out KEYWORD ARASINDAKİ FARK ref'de DEĞİŞKENE DEĞER SET EDİLMESİ GEREKİRKEN out'da GEREK YOKTUR...FAKAT out KULLANILAN METOD'DA return EDİLMEDEN ÖNCE out EDİLMİŞ DEĞİŞKEN BİR KERE SET EDİLMESİ GEREK
            var result = Add3(out number1, number2);
            Console.WriteLine(number1);
            Console.WriteLine(result);
            */
            /*
            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2, 4, 5));
            */
            Console.WriteLine(Add4(1, 2, 3, 4, 5, 6));
            Console.ReadLine();
        }
        /*
        static void Add()
        {
            Console.WriteLine("Added!");
        }
        static int Add2(int number1, int number2 = 100) // default parametre verirken ya hepsine verilir veya sol taraftan verilir
        {
            var result = number1 + number2;
            return result;
        }*/
        /*
        static int Add3(out int number1, int number2) // out KEYWORD VARSA KESİNLİKLE METODUN İÇİNDE out KEYWORDLÜ DEĞİŞKEN BİR KERE SET EDİLMESİ GEREK
        {
            number1 = 30;
            return number1 + number2;
        }
        */
        /*
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }
        */
        static int Add4(int number, params int[] numbers) // PARAMSLA İSTEDİĞİMİZ KADAR AYNI TİPTE VERİ GÖNDEREBİLİRİZ...
        {
            return numbers.Sum();
        }
    }
}
