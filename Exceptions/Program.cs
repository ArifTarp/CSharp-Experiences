using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part1();
            //Part2();
            //Part3();

            // FUNCI ACTİON GİBİ METODA GÖNDEREBİLİRİZ MERKEZİLEŞTİREBİLİRİZ
            Func<int, int, int> add = Topla;
            Console.WriteLine(add(3,5));
            
            // BAŞKA KULLANIMI
            Func<int> getRandomNumber = delegate()
            {
                Random random = new Random();
                return random.Next(1, 100);
            };
            Console.WriteLine(getRandomNumber());

            Thread.Sleep(1000);
            // BAŞKA KULLANIMI
            Func<int> getRandomNumber2 = () => new Random().Next(1,100);
            Console.WriteLine(getRandomNumber2());


            Console.ReadLine();
        }

        private static int Topla(int x, int y) // Main class statik bir metod.Static olan metodların içinde kullanmak istediğin metodlar da static olmak zorunda
        {
            return x + y;
        }

        private static void Part3()
        {
            try
            {
                Part2Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }

            HandleException(() => { Part2Find(); }); // () işareti parametresiz demek
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void Part2()
        {
            try
            {
                Part2Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void Part2Find()
        {
            List<string> students = new List<string> { "Engin", "Derin", "Salih" };

            if (!students.Contains("Ahmet"))
            {
                throw new RecordNotFoundException("Record Not Found!");
            }
            else
            {
                Console.WriteLine("Record Found!");
            }
        }

        private static void Part1()
        {
            // BÜTÜN EXCEPTİON TÜRLERİ EXCEPTİONDAN TÜRER. YANİ BASELERİ EXCEPTİON CLASSIDIR

            // Aşağıdaki kod için ilk önce try çalışır. Hata varsa IndexOutOfRangeException bu exceptiona bakar. Bu hataysa bu catche girip program devam eder.
            // IndexOutOfRangeException exceptionı değilse Exception catch bloğuna girip programı devam ettirir
            try
            {
                string[] students = new string[3] { "Engin", "Derin", "Salih" };
                students[3] = "Ahmet";
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine("EXCEPTİONNNN!");
                Console.WriteLine(exception.Message);
                Console.WriteLine(exception.InnerException); // EXCEPTİON HAKKINDA VARSA DAHA DETAYLI BİLGİ VARSA VERİR
            }
        }
    }
}
