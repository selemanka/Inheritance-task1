using System;

namespace Task5_AbstractClass
{
    public class Circle : Figure
    {
        public double Radius { get; private set; }

        public double X { get; private set; }

        public double Y { get; private set; }

        //
        public Circle() : base()
        {
            Radius = 1;
            X = 0;
            Y = 0;
        }

        public Circle(double newRadius) : base()
        {
            Radius = newRadius;
            X = 0;
            Y = 0;
        }
        //
        public override void Input()
        {
            base.Input();
            System.Console.Write("Enter radius : ");
            double enteredRadius = Convert.ToDouble(System.Console.ReadLine());
            if (enteredRadius <= 0)
            {
                throw new ArgumentException("Radius is wrong! ");
            }
            Radius = enteredRadius;
            System.Console.Write("Enter x : ");
            X = Convert.ToDouble(System.Console.ReadLine());
            System.Console.Write("Enter y : ");
            Y = Convert.ToDouble(System.Console.ReadLine());
        }
        public override void OutputParams()
        {
            base.OutputParams();
            System.Console.WriteLine($" Radius : {Radius}");
            System.Console.WriteLine($" (x, y) : ({X}, {Y})");
        }

        //
        public override double GetArea()
        {
            double area = (Math.PI * Math.Pow(Radius, 2));
            return area;
        }
        public override double GetPerimetr()
        {
            double perimetr = (2 * Math.PI * Radius);
            return perimetr;
        }
    }
}