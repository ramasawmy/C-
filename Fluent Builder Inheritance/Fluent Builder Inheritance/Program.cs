using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluent_Builder_Inheritance
{
    public class Person
    {
        public String Name;
        public string Position;

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Position)}: {Position}";
        }
    }

    public class PersonInfoBuilder
    {
        protected Person person = new Person();

        public PersonInfoBuilder called(String name)
        {
            person.Name = name;
            return this;
        }
    }

    public class PersonJobBuilder : PersonInfoBuilder
    {
        public PersonJobBuilder WorksAsA(String position)
        {
            person.Position = position;
            return this;
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            var builder = new PersonJobBuilder();
            builder.called("Dmitri");
                
        }
    }
}
