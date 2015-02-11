using System;

struct Fraction
{
    private long _numerator;
    private long _denominator;

    internal Fraction(long numerator, long denominator)
        : this()
    {
        this.Numerator = numerator;
        this.Denominator = denominator;
    }

    internal long Numerator
    {
        get { return this._numerator; }
        set { this._numerator = value; }
    }

    internal long Denominator
    {
        get { return this._denominator; }
        set
        {
            if (value == 0) throw new ArgumentException("Invalid number, numerator can't be 0");
            this._denominator = value;
        }
    }

    public static Fraction operator + (Fraction f1, Fraction f2)
    {
        return new Fraction(((f1._numerator * f2._denominator) + (f2._numerator * f1._denominator)), (f1._denominator * f2._denominator));
    }

    public override string ToString()
    {
        return string.Format("{0}", (decimal)this.Numerator / (decimal)this.Denominator);
    }
}

