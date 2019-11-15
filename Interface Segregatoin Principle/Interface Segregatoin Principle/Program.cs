using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Interface_Segregatoin_Principle
{
    public class Document
    {

    }

    public interface IMachine
    {
        void Print(Document d);
        void Scan(Document d);
        void Fax(Document d);
    }

    public class MaultiFunctionPrinter : IMachine
    {
        public void Print(Document d)
        {
            //
        }
        public void Scan(Document d)
        {
            //
        }
        public void Fax(Document d)
        {
            //
        }
    }

    public class OldFashionPrinter : IMachine
    {
        public void Print(Document d)
        {
            //
        }
        public void Scan(Document d)
        {
            throw new NotImplementedException();
        }
        public void Fax(Document d)
        {
            throw new NotImplementedException();
        }
    }

    public interface IPrinter
    {
        void Print(Document d);
    }
    public interface IScanner
    {
        void Scan(Document d);
    }

    public class photocopier : IPrinter, IScanner
    {
        public void Print(Document d)
        {
            throw new NotImplementedException();
        }

        public void Scan(Document d)
        {
            throw new NotImplementedException();
        }
    }

    public interface IMultiFunctionDevice : IScanner, IPrinter
    {

    }

    public class MultiFunctionMachine : IMultiFunctionDevice
    {
        private IPrinter Printer;
        private IScanner Scanner;

        public MultiFunctionMachine(IPrinter printer, IScanner scanner)
        {
            if (printer == null)
            {
                throw new ArgumentNullException(paramName: nameof(printer));
            }
            if (scanner == null)
            {
                throw new ArgumentNullException(paramName: nameof(scanner));
            }
            this.Printer = printer;
            this.Scanner = scanner;
        }
        public void Print(Document d)
        {
            Printer.Print(d);
        }
        public void Scan(Document d)
        {
            Scanner.Scan(d);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.ReadLine();
        }
    }
}
