using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    internal class TypeB
    {
        // its Project Only
        public TypeB()
        {
            TypeA typeA = new TypeA();
            typeA.y = 10;
            typeA.z = 20;

        }

    }
}