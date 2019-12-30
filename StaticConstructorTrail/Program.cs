using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructorTrail
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities;
        }
    }

    class Utilities
    {
        // newlenemez
        private Utilities()
        {
            
        }
    }

    class Fonctuions : Utilities
    {
        public Fonctuions(string entity):base(entity)
        {

        }
    }
}
