using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Builder
{
    public class HtmlElement
    {
        public String Name, Text;
        public List<HtmlElement> Elements = new List<HtmlElement>();
        private const int indentSize = 2;
        
        public HtmlElement()
        {

        }

        public HtmlElement(String name, String text)
        {
            //if (name == null)
            //{
            //    throw new ArgumentNullException(paramName: nameof(name));
            //}
            //if (text == null)
            //{
            //    throw new ArgumentNullException(paramName: nameof(text));
            //}

            Name = name ?? throw new ArgumentNullException(paramName: nameof(name));
            Text = text ?? throw new ArgumentNullException(paramName: nameof(text));
        }
        private String ToStringImpl(int indent)
        {
            var sb = new StringBuilder();
            var i = new String(' ', indentSize * indent);
            sb.AppendLine($"{i}<{Name}>");

            if (!String.IsNullOrWhiteSpace(Text))
            {
                sb.Append(new String(' ', indentSize * (indent + 1)));
                sb.AppendLine(Text);
            }
            foreach (var e in Elements)
            {
                sb.Append(e.ToStringImpl(indent + 1));
            }
            sb.AppendLine($"{i} </{Name}>");
            return sb.ToString();
        }

        public override string ToString()
        {
            return ToStringImpl(0);
        }
    }
    public class HtmlBuilder
    {
        private readonly string rootName;
        HtmlElement root = new HtmlElement();

        public HtmlBuilder(String rootName)
        {
            this.rootName = rootName;
            root.Name = rootName;
        }

        public HtmlBuilder AddChild(String childName, String childText)
        {
            var e = new HtmlElement(childName, childText);
            root.Elements.Add(e);
            return this;
        }

        public override string ToString()
        {
            return root.ToString();
        }

        public void clear()
        {
            root = new HtmlElement { Name = rootName };
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            var hello = "hello";
            var sb = new StringBuilder();
            sb.Append("<p>");
            sb.Append(hello);
            sb.Append("</p>");
            WriteLine(sb);

            var words = new[] { "hello", "world" };
            sb.Clear();
            sb.Append("<ul>");
            foreach (var word in words)
            {
                sb.AppendFormat("<li>{0}</li>", word);
            }
            sb.Append("</ul>");
            WriteLine(sb);

            var builder = new HtmlBuilder("ul");
            builder.AddChild("li", "hello").AddChild("li", "world");
            WriteLine(builder.ToString());

            Console.ReadLine();
        }
    }
}
