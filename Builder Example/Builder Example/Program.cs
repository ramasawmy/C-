using System;
using System.Collections.Generic;

namespace Builder_Example
{
    class Student
    {
        public void Construct(Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }

    class Product
    {
        // USE SYSTEM COLLECTION GENERIC FOR LIST 
        private List<String> _parts = new List<String>();

        public void Add(String part)
        {
            _parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("\nSchool Class");
            foreach (String part in _parts)
                Console.WriteLine(part);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            Builder b1 = new ConcreteBuilder1();
            Builder b2 = new ConcreteBuilder2();

            student.Construct(b1);
            Product p1 = b1.GetResult();
            p1.Show();

            student.Construct(b2);
            Product p2 = b2.GetResult();
            p2.Show();

            Console.ReadLine();
        }
    }

    abstract class Builder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract Product GetResult();

    }

    class ConcreteBuilder1 : Builder

    {
        private Product _product = new Product();

        public override void BuildPartA()
        {
            _product.Add("Student A");
        }

        public override void BuildPartB()
        {
            _product.Add("Student B");
        }

        public override Product GetResult()
        {
            return _product;
        }
    }

    class ConcreteBuilder2 : Builder

    {
        private Product _product = new Product();

        public override void BuildPartA()
        {
            _product.Add("Student X");
        }

        public override void BuildPartB()
        {
            _product.Add("Student Y");
        }

        public override Product GetResult()
        {
            return _product;
        }
    }

}
