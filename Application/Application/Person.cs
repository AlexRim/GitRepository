using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class Person
    {
        private string name;

        private string sorname;

        private int age;

      
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Sorname { get => sorname; set => sorname = value; }
        public int Age { get => age; set => age = value; }

        public Person(string name, string sorname,int age)
        {
            this.name = name;
            this.sorname = sorname;
            this.age = age;
        }

        public Person() { }

        public override string ToString()
        {
            return Name + " " + Sorname + " " + Age;
        }

    }
}
