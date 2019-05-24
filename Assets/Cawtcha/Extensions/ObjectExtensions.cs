using System;

public static class ObjectExtensions
{

    public static void IfNotNull<T>(this T @this, Action<T> action) where T : class
    {
        if (@this != null)
        {
            action(@this);
        }
    }

    public static TResult IfNotNull<T, TResult>(this T @this, Func<T, TResult> func) where T : class
    {
        return @this != null ? func(@this) : default(TResult);
    }

    public static TResult IfNotNull<T, TResult>(this T @this, Func<T, TResult> func, TResult defaultValue) where T : class
    {
        return @this != null ? func(@this) : defaultValue;
    }

    public static TResult IfNotNull<T, TResult>(this T @this, Func<T, TResult> func, Func<TResult> defaultValueFactory) where T : class
    {
        return @this != null ? func(@this) : defaultValueFactory();
    }

    public static bool In<T>(this T @this, params T[] values)
    {
        return Array.IndexOf(values, @this) != -1;
    }

    public static bool IsNotNull<T>(this T @this) where T : class
    {
        return @this != null;
    }

    public static bool IsNull<T>(this T @this) where T : class
    {
        return @this == null;
    }
    
}
