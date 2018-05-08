using System;

namespace Task5_AbstractClass
{
    public class Cylinder : Circle
    {
        public double Height { get; set; }

        //
        public Cylinder() : base()
        {
            Height = 1;
        }

        public Cylinder(double radius, double height) : base(radius)
        {
            Height = height;
        }


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
    }
}