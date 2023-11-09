//Delegate is an object that refers to a method or it is a variable of the reference type that can hold a reference to the methods.
//Delegates are commonly used to implement events and call backs methodsa. All delegates are derived implicitly from the System. Delegate the class.

using System;
delegate int Calculator(int x);

public class Delegateexample
{
    static int value = 10;

    public static int add(int x)
    {
        value = value + x;
        return value;
    }
    public static int subtract(int x)
    {
        value = value - x;
        return value;
    }
    public static int multiply(int x)
    {
        value = value * x;
        return value;
    }
    public static int division(int x)
    {
        value = value / x;
        return value;
    }
    public static int getvalue()
    {
        return value;
    }

    public static void Main(string[] args)
    {
        Calculator cal1 = new Calculator(add);
        Calculator cal2 = new Calculator(subtract);
        Calculator cal3 = new Calculator(multiply);
        Calculator cal4 = new Calculator(division);
        cal1(20);
        Console.WriteLine("After cal1 delegate, value is : " + getvalue());
        cal2(3);
        Console.WriteLine("After cal2 delegate, value is : " + getvalue());
        cal3(5);
        Console.WriteLine("After cal3 delegate, value is : " + getvalue());
        cal4(5);
        Console.WriteLine("After cal4 delegate, value is : " + getvalue());

    }
}
