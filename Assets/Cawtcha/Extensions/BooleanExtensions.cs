using System;

public static class BooleanExtensions
{
    public static void IfFalse(this bool @this, Action action)
    {
        if (!@this)
        {
            action();
        }
    }

    public static void IfTrue(this bool @this, Action action)
    {
        if (@this)
        {
            action();
        }
    }

}
