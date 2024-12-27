using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    // its project and External Project [import]
    public class TypeA
    {
        public TypeA()
        {
            TypeB typeB = new TypeB();
        }

        private int x;
        internal int y;
        public int z;

        void Print()
        {
            Console.WriteLine(x);
        }
    }
}