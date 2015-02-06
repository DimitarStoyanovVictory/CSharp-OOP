using System;

public static class DistanceCalculator
{
    public static double CalculateDistance(Point3D firstPoint, Point3D secondPoint)
    {
        return Math.Sqrt(Math.Pow((firstPoint.X - secondPoint.X), 2) + Math.Pow((firstPoint.Y - secondPoint.Y), 2) + Math.Pow((firstPoint.Z - secondPoint.Z), 2));
    }
}

public class MainProgram
{
    static void Main()
    {
        Point3D firstPoint = new Point3D("First Point", -7, -4, 3);
        Point3D secondPoint = new Point3D("Second Point", 17, 6, 2.5);
        Console.WriteLine("The distance between the two points is : {0}", DistanceCalculator.CalculateDistance(firstPoint, secondPoint)); 
    }
}
