using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public class Person
    {
        public string Name
        {
            get;
            set;
        }
        public string Address
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }
    }
    public class PersonImplementation
    {
        public double Average(IList<Person> Person)
        {
            double avg = Person.Average(x => x.Age);
            return avg;
        }
        public int Max(IList<Person> Person)
        {
            int MaxAge = Person.Max(p => p.Age);
            return MaxAge;
        }
    }
    class Test
    {
        static void Main3()
        {
            PersonImplementation s = new PersonImplementation();
            IList<Person> p = new List<Person>();
            p.Add(new Person { Name = "Aarya", Address = "A2101", Age = 69 });
            p.Add(new Person { Name = "Daniel", Address = "D104", Age = 40 });
            p.Add(new Person { Name = "Ira", Address = "H801", Age = 25 });
            s.Average(p);
            s.Max(p);
        }
    }

}
