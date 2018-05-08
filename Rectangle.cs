using System;

namespace Task5_AbstractClass
{
    public class Rectangle : Figure
    {
        public double Side1 { get; set; }

        public double Side2 { get; set; }

        //
        public Rectangle() : base()
        {
            Side1 = 2;
            Side2 = 1;
        }
        public Rectangle(double newSide1, double newSide2) : base()
        {
            Side1 = newSide1;
            Side2 = newSide2;
        }
        //
        public override void Input()
        {
            base.Input();
            System.Console.Write("Enter length of side 1 : ");
            var enteredSide1 = Convert.ToDouble(System.Console.ReadLine());
            if (enteredSide1 <= 0)
            {
                throw new ArgumentException("Side 1 is wrong! ");
            }

            Side1 = enteredSide1;
            System.Console.Write("Enter length of side 2 : ");
            var enteredSide2 = Convert.ToDouble(System.Console.ReadLine());
            if (enteredSide2 <= 0)
            {
                throw new ArgumentException("Side 2 is wrong! ");
            }

            Side2 = enteredSide2;

        }

        public override void OutputParams()
        {
            base.OutputParams();
            System.Console.WriteLine($" Length of side 1 : {Side1}");
            System.Console.WriteLine($" Length of side 2 : {Side2}");
        }

        public override double GetArea()
        {
            double area = (Side1 * Side2);
            return area;
        }
        public override double GetPerimetr()
        {
            double perimetr = (Side1 + Side2) * 2;
            return perimetr;
        }

    }
}