
using System;

public static class StringExtensionMethods
{

    public static Int32 CompareOrdinal(this String @this, String other)
    {
        return String.CompareOrdinal(@this, other);
    }

    public static String Format(this String @this, Object arg0)
    {
        return String.Format(@this, arg0);
    }

    public static String Format(this String @this, Object arg0, Object arg1)
    {
        return String.Format(@this, arg0, arg1);
    }

    public static String Format(this String @this, Object arg0, Object arg1, Object arg2)
    {
        return String.Format(@this, arg0, arg1, arg2);
    }

    public static String Format(this String @this, params Object[] args)
    {
        return String.Format(@this, args);
    }

    public static bool IsNullOrEmpty(this string @this)
    {
        return string.IsNullOrEmpty(@this);
    }

    public static bool IsNotNullOrEmpty(this string @this)
    {
        return !string.IsNullOrEmpty(@this);
    }

    public static Boolean IsEmpty(this string @this)
    {
        return @this == "";
    }

    public static bool IsNotEmpty(this string @this)
    {
        return @this != "";
    }

    public static T ToEnum<T>(this string @this)
    {
        Type enumType = typeof(T);
        return (T)Enum.Parse(enumType, @this);
    }

}