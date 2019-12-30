using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //PART1();

            //PART2();

            var type = typeof(DortIslem);
            var instance = Activator.CreateInstance(type, 6, 5);

            var methods = type.GetMethods();
            foreach (var method in methods)
            {
                Console.WriteLine("Metod is name: {0}", method.Name);

                foreach (var parameterInfo in method.GetParameters())
                {
                    Console.WriteLine("Parameter : {0}", parameterInfo.Name);
                }

                foreach (var customAttribute in method.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute Name : {0}", customAttribute.GetType().Name);
                }
            }

            Console.ReadLine();
        }

        private static void PART2()
        {
            var type = typeof(DortIslem);
            var instance = Activator.CreateInstance(type, 6, 5);

            //Console.WriteLine(instance.GetType().GetMethod("Topla2").Invoke(instance, null)); // GetMethodla istediğimiz metoda ulaşabiliyoruz, Invoke ile de çalıştırıyoruz. Invoke'un birinci parametresi nerede çalışacağını söyledik, ikinci parametresi ise methodun parametresi olmadığı için null yazdık
            // Aynısının farklı kullanımı
            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");
            Console.WriteLine(methodInfo.Invoke(instance, null));
            // Eğer parametre varsa
            //Console.WriteLine(methodInfo.Invoke(instance, new object[]{6,6} ));
        }

        private static void PART1()
        {
            // DortIslem dortIslem = new DortIslem(2,3);
            // Console.WriteLine(dortIslem.Topla2());
            // Console.Write(dortIslem.Topla(3,4));

            var tip = typeof(DortIslem);
            DortIslem dortIslem = (DortIslem)Activator.CreateInstance(tip, 6, 7); // bununla bu aynı şey --> DortIslem dortIslem = new DortIslem(2,3);
            Console.WriteLine(dortIslem.Topla(4, 5));
            Console.WriteLine(dortIslem.Topla2());
        }
    }

    public class DortIslem
    {
        private int _sayi1;
        private int _sayi2;

        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }

        public DortIslem()
        {

        }

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }

        [MethodName("Carpma")]
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }
    }

    public class MethodNameAttribute : Attribute
    {
        private string name;
        public MethodNameAttribute(string name)
        {
            this.name = name;
        }
    }
}
