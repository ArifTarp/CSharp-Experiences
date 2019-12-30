using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Customer
    {
        int id; // sadece ama sadece tanımlandığı blok içerisinde geçerlidir...
        protected int Id { get; set; }
        
    }

    class Student : Customer
    {
        public void Save()
        {
            Customer customer = new Customer();
            Id = 3; // protected Access Modifier Olduğundan Kalıtım Yapan Sınıfta Kullanabildik...
        }
    }

    //internal class Course
    //{
    //    public string Name { get; set; }

    //    private class NestedClass
    //    {
    //        // public veya internal olsaydı bu class gene dişarıdan erişilebilirdi...
    //    }
    //}
    public class Course
    {
        public string Name { get; set; }

        private class NestedClass
        {
            // public veya internal olsaydı bu class gene dişarıdan erişilebilirdi...
        }
    }
}
