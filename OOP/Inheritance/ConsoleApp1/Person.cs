using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonTask
{
    public class Person
    {
        private string name;
        private int age;
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public virtual string Name { get
            {
                return this.name;
            }
            protected set
            {
                if (value.Length < 3 || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name's length should be less than 3 symbols!");
                }
                this.name = value;
            }
        }
        public virtual int Age { get 
            
            { 
                return this.age; 
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age must be positive!");
                }
                this.age = value;
            }

        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"Name: {Name}, Age: {Age}");
            return stringBuilder.ToString();
        }
    }
}
