using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_AbstractClass
{
    public abstract class Figure
    {
        //
        public string Color { get; set; }

        public int BorderSize { get; set; }

        public string BorderColor { get; set; }

        //
        protected Figure()
        {
            Color = "white";
            BorderColor = "black";
            BorderSize = 1;
        }

        //
        public virtual void Input()
        {
            System.Console.Write("Enter color : ");
            Color = System.Console.ReadLine();
            System.Console.Write("Enter border color : ");
            BorderColor = System.Console.ReadLine();
            System.Console.Write("Enter border size : ");
            BorderSize = Convert.ToInt32(System.Console.ReadLine());
        }

        public void Output()
        {
            System.Console.WriteLine(ToString());
            OutputParams();
        }

        public virtual void OutputParams()
        {
            System.Console.WriteLine($" Color : {Color}");
            System.Console.WriteLine($" Border color : {BorderColor}");
            System.Console.WriteLine($" Border size : {BorderSize}");
        }


        //
        public abstract double GetArea();
        public abstract double GetPerimetr();

    }
}