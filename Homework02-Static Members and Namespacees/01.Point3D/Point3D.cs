using System;
using System.Collections.Generic;
    
public class Point3D
{
    private string name;
    private double x;
    private double y;
    private double z;

    private static Point3D startingPoint;
    public Point3D(string name, double x, double y, double z)
    {
        this.Name = name;
        this.X = x;
        this.Y = y;
        this.Z = z;
    }
    static Point3D()
    {
        Point3D.startingPoint = new Point3D("Start Point(Center Point)", 0, 0, 0);
    }
    public string Name { get; set; }
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public override string ToString()
    {
        return String.Format("Cordinate of the point \"{3}\" X = {0} Y = {1} Z = {2}", this.X, this.Y, this.Z, this.Name);
    }
}

class MainProgram
{
    static void Main()
    {
        List<Point3D> points = new List<Point3D>();
        points.Add(new Point3D("First point", 2, 3, 4));
        points.Add(new Point3D("Second point", 3, 5, 6));
        points.Add(new Point3D("Third point", 5, 6, 7));
        points.ForEach(point => Console.WriteLine(point));
    }
}

