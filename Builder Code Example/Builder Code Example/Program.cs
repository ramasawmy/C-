using System;

namespace Builder_Code_Example
{

    public class Person

    {

        public string Name;

        public int Age;



        public override string ToString()

        {

            return $"{nameof(Name)}: {Name}, {nameof(Age)}: {Age}";

        }

    }



    public class CodeBuilder

    {

        protected Person person = new Person();



        public PersonBuilder Identity => new PersonBuilder(person);



        public static implicit operator Person(CodeBuilder p)

        {

            return p.person;

        }

    }



    public class PersonBuilder : CodeBuilder

    {



        public PersonBuilder(Person person)

        {

            this.person = person;

        }



        public PersonBuilder Addfield(string field, string type)

        {

            if (type == "string")

                person.Name = field;

            else

                person.Age = Int32.Parse(field);

            return this;

        }

    }



    class Program

    {

        static void Main(string[] args)

        {

            var cb = new CodeBuilder();

            Person person = cb.Identity.Addfield("Steven", "string").Addfield("21", "integer");

            Console.WriteLine(person);

            Console.ReadLine();

        }

    }

}