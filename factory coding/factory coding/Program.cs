using System;
using System.Collections.Generic;

namespace FactoryExercise
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static PersonFactory Factory = new PersonFactory();

        private Person(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"{Id}: {Name}";
        }

        public class PersonFactory
        {
            private int CurrentId = 0;
            public Person CreatePerson(string name)
            {
                return new Person(CurrentId++, name);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            persons.Add(Person.Factory.CreatePerson("Mark"));
            persons.Add(Person.Factory.CreatePerson("John"));
            persons.Add(Person.Factory.CreatePerson("Jack"));

            foreach (Person p in persons) Console.WriteLine(p);

            Person.PersonFactory factory = new Person.PersonFactory();
            persons.Clear();

            persons.Add(factory.CreatePerson("Mary"));
            persons.Add(factory.CreatePerson("Jane"));
            persons.Add(factory.CreatePerson("Judy"));

            foreach (Person p in persons) Console.WriteLine(p);

            Console.ReadKey();

            Console.ReadLine();
        }

        
    }
}