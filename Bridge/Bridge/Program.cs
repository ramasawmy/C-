using System;

namespace Coding.Exercise
{
    public abstract class Shape
    {
        public string Name { get; set; }
    }

   

    public class Square : Shape
    {
        public Square()
        {
            Name = "Square";
        }
    }

   
    

    public interface IRenderer
    {
        string WhatToRenderAs { get; }
    }

    public abstract class shape
    {
        private IRenderer rendering;

        protected shape(IRenderer rendering)
        {
            this.rendering = rendering;
        }

        public string Name { get; set; }

        public override string ToString()
        {
            return $"Drawing {Name} as {rendering.WhatToRenderAs}";
        }
    }

    public class triangle : Shape
    {
        public triangle(IRenderer strategy) : base()
        {
            Name = "Triangle";
        }
    }

    public class square : Shape
    {
        public square(IRenderer rendering) : base()
        {
            Name = "Square";
        }
    }

    public class RasterRenderer : IRenderer
    {
        public string WhatToRenderAs
        {
            get { return "pixels"; }
        }
    }

    public class VectorRenderer : IRenderer
    {
        public string WhatToRenderAs
        {
            get { return "lines"; }
        }
    }
    class TestClass
    {
        static void Main(string[] args)
        {
            // Display the number of command line arguments.
           
        }
    }


}

