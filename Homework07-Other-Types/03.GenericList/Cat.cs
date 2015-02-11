using System;

public class Cat : IComparable<Cat>
{
    public String Name { get; set; }
    public int CompareTo(Cat cat)
    {
        return this.Name.CompareTo(cat.Name);
    }
    public override string ToString()
    {
        return this.Name;
    }
}