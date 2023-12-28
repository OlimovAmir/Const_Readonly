using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Const_Readonly
{
    internal class MyClass
    {
        public const double PI = 3.14;
        public const string MY_ERROR = "some error";
        public readonly int _age;

        public MyClass(int age)
        {

            _age = age;

        }

        public void Foo()
        {

        }
    }
}
