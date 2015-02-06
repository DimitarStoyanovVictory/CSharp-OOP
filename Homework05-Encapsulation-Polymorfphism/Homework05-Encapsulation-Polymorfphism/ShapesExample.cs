using System;
using System.Collections.Generic;
using BasicShapes;

namespace EncapsulationPolymorfphism
{
    class ShapesExample
    {
        static void Main()
        {
            List<BasicShapes.BasicShape> basicShapes = new List<BasicShapes.BasicShape>(){ new Rectangle(10, 5),
                                                                   new Rectangle(8, 3),
                                                                   new Triangle(10, 8, 35),
                                                                   new Triangle(15, 10, 60),
                                                                   new Circle(10),
                                                                   new Circle(16)
            };
            basicShapes.ForEach(shape => Console.WriteLine("The type of the shape is {0}, it's surface is {1} and it's perimeter is {2}", shape.GetType().Name, shape.CalculateArea(), shape.CalcualtePerimeter()));
        }
    }
}
