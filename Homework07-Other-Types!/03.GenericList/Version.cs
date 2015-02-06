using System;

[AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Method | AttributeTargets.Enum,
    AllowMultiple = true)]

public class Version : Attribute
{
    public int Major { get; set; }
    public int Minor { get; set; }

    public Version(int major, int minor)
    {
        this.Major = major;
        this.Minor = minor;
    }
}

