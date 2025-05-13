using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Student()
        {
        }

        public Student(int age, string name)
        {
            Age = age;
            Name = name;
        }


        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
