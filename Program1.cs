using System;

namespace figurs
{
    abstract class figur
    {
        public abstract double Perimeter();
        public abstract double Area();

    }

    class Rectangle : figur
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
        public override double Perimeter()
        {
            return Width * 2 + Height * 2;
        }
        public override double Area()
        {
            return Width * Height;
        }
    }

    class Circle : figur
    {
        public float Radius { get; set; }
        public Circle(float radius)
        {
            this.Radius = radius;
        }
        public override double Perimeter()
        {
            return Radius * 2 * Math.PI;
        }
        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }

        class Triangle : figur
        {
            public double First { get; set; }
            public double Second { get; set; }
            public double Third { get; set; }



            public Triangle(double first, double second, double third)
            {
                this.First = first;
                this.Second = second;
                this.Third = third;
            }


            public override double Perimeter()
            {
                return First + Second + Third;
            }
            public override double Area()
            {
                double p = (First + Second + Third) / 2;
                double S = Math.Sqrt(p * (p - First) * (p - Second) * (p - Third));
                return S;
            }
        }

        public abstract class Animal
        {

            public Animal(float Weight, string Color)
            {
                this.Weight = Weight;
                this.Color = Color;
            }

            public float Weight
            {
                get; set;
            }

            public string Color
            {
                get; set;
            }

            public abstract string MakeSound();
            static void Main(string[] args)
            {

            }

        }

        class Cat : Animal
        {
            string Sound;
            public Cat(float weight, string color) : base(100, "rainbow")
            {
                this.Weight = weight;
                this.Color = color;
                Sound = MakeSound();
            }

            public override string MakeSound()
            {
                return "Myau";
            }
        }

    }
}
