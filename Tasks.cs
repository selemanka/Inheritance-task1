using System;
using System.Collections.Generic;
using System.Linq;

namespace Task5_AbstractClass
{
    public class Tasks
    {

        private static void OutputCollection(List<Figure> figures)
        {
            foreach (var figure in figures)
            {
                figure.Output();
            }
        }


        private static List<Figure> CreateCollection()
        {
            try
            {
                const int n = 2;
                System.Console.WriteLine($"Enter collection of {n} elements : ");
                System.Console.WriteLine("Press number to create an object : ");
                System.Console.WriteLine("0 = terminate input; \n 1 = circle; \n 2 = rectangle; \n 3 = cylinder; \n 4 = parallelepiped;");
                var figures = new List<Figure>();

                var end = false;
                while (!end)
                {
                    System.Console.Write($"Figure {figures.Count + 1} : ");
                    var objectNumber = Convert.ToInt32(System.Console.ReadLine());
                    switch (objectNumber)
                    {
                        case 1:
                            {
                                figures.Add(new Circle());
                                break;
                            }
                        case 2:
                            {
                                figures.Add(new Rectangle());
                                break;
                            }
                        case 3:
                            {
                                figures.Add(new Cylinder());
                                break;
                            }
                        case 4:
                            {
                                figures.Add(new Parallelepiped());
                                break;
                            }
                        default:
                            {
                                end = true;
                                break;
                            }
                    }
                }
                return figures;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.TargetSite);
                throw;
            }
        }

        public static double GetCollectionPerimetr(List<Figure> figures)
        {
            double collectionPerimetr = 0;
            foreach (var figure in figures)
            {
                collectionPerimetr += figure.GetPerimetr();
            }

            return collectionPerimetr;
        }

        public static double GetCollectionArea(List<Figure> figures)
        {
            double collectionArea = 0;
            foreach (var figure in figures)
            {
                collectionArea += figure.GetArea();
            }

            return collectionArea;
        }

        public static void ExerciseTask()
        {
            try
            {
                var figures = CreateCollection();
                OutputCollection(figures);
                System.Console.WriteLine($"Collection Perimetr : {GetCollectionPerimetr(figures)} ;");
                System.Console.WriteLine($"Collection Area : {GetCollectionArea(figures)} ; ");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.TargetSite);
                throw;
            }
        }
    }
}