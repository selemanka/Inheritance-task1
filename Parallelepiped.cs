using System;

namespace Task5_AbstractClass
{
    public class Parallelepiped : Rectangle
    {
        public double Height { get; set; }

        //
        public Parallelepiped() : base()
        {
            Height = 1;
        }

        public Parallelepiped(double side1, double side2, double side3) : base(side1, side2)
        {
            Height = side3;
        }

        //TODO: add exeptions

        public override void Input()
        {
            base.Input();
            System.Console.Write(" Enter height : ");
            var height = Convert.ToDouble(System.Console.ReadLine());
            if (height <= 0)
            {
                throw new ArgumentException("Height is wrong! ");
            }

            Height = height;
        }

        public override void OutputParams()
        {
            base.OutputParams();
            System.Console.WriteLine($" Height : {Height}");
        }

        //
        public double GetVolume()
        {
            double volume = (GetArea() * Height);
            return volume;
        }
        public override double GetPerimetr()
        {
            double perimetr = (base.GetPerimetr() * 2 + Height * 4);
            return perimetr;
        }
    }
}