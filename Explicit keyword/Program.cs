// cs_Keyword_explicit_temp.cs
using System;
class Celsius
{
    public Celsius(float temp)
    {
        degrees = temp;

    }
    public static explicit operator Fahrenheit(Celcius C)
    {
        return new Fahrenheit((9.0 / 5.0f) * C.degrees + 32);
    }
    public float Degrees
    {
        get { return Degrees;  }

    }
    private float degrees;

}
class Fahrenheit
{
    public Fahrenheit(float temp)
    {
        degree = temp;

    }
    public static explicit operator Celsius(Fahrenheit f)
    {
        return new Celsius((5.0 / 9.0f) * (f.degrees - 32));
    }
    public float Degrees
    {
        get { return Degrees; }

    }
    private float degrees;
}


    class Mainclass
    {
        static void Main()
        {
        Fahrenheit f = new Fahrenheit(100.0f);
        Console.WriteLine("{0} fahrenhight", f.Degrees);
        Celsius c = (Celsius)f;
        Console.WriteLine("= {0} celsius", c.Degrees);
        Fahrenheit f2 = (Fahrenheit) c;
        Console.WriteLine("= {0} fahrenheit", f2.Degrees);

        }
    }
