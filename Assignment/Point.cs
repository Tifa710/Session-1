using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
        /// Access Modifiers Allowed Inside a Struct
        /// 1. Private [Default]
        /// 2. Internal
        /// 3. Public
        internal struct Point
        {
            /// What You Can Write Inside a Struct Or a Class
            /// 1. Attributes (Fields) => Member Variables
            //public int X;
            //public int Y;

            /// 2. Functions (Methods) => [Constructor , Getter , Setter , Method]
            // Constructor Special Method
            //1.Name of the Constructor is the same as the Name of the Class
            //2. Constructor has no return type

            //public Point(int x , int y)
            //{
            //    X = x; 
            //    Y = y;
            //}

            //public Point(int Number)
            //{
            //    X = Y = Number;
            //    Y = X = Number;
            //}

            //public override string ToString()
            //{
            //    return $"X = {X} , Y = {Y}";
            //}


            /// 3. Properties [Full Property , Automatic Property , Indexer]
            /// 4. Events


        }
}