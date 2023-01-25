using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupPractice
{
    internal class Person
    {
        //properties
        internal string Name { get; set; }
        internal int Age { get; set; } 
        //constructor 
        internal Person(string _name, int _age)
        {
            Name= _name;
            Age= _age;
        }
    }
}
