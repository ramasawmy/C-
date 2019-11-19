using System;
using System.Collections.Generic;
using System.Text;

namespace Coding.Exercise

{

    public class Person

    {

        public int Id { get; set; }

        public string Name { get; set; }

        public static PersonFactory Factory = new PersonFactory();



        internal Person() { }



        public override string ToString()

        {

            return $"Id: {Id}, Name: {Name}";

        }

    }



    public class PersonFactory

    {

        public List<Person> People = new List<Person>();

        private static int _id = 0;



        public Person CreatePerson(string name)

        {

            Person p = new Person { Name = name, Id = _id++ };

            People.Add(p);

            return p;

        }



        public override string ToString()

        {

            var result = new StringBuilder();

            foreach (var p in People)

            {

                result.AppendLine(p.ToString());

            }

            return result.ToString();

        }



    }

}