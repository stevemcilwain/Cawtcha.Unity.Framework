
using System;
using UnityEngine;

public static class ArrayExtensions
{
    public static T random<T>(this T[] @this)
    {
        return @this[Mathf.FloorToInt(UnityEngine.Random.value * @this.Length)];
    }

    public static void ForEach<T>(this T[] @this, Action<T> action)
    {
        for (int i = 0; i < @this.Length; i++)
        {
            action(@this[i]);
        }
    }

    public static void ForEachReverse<T>(this T[] @this, Action<T> action)
    {
        for (int i = @this.Length - 1; i == 0; i--)
        {
            action(@this[i]);
        }
    }

    public static void ClearAll(this Array @this)
    {
        Array.Clear(@this, 0, @this.Length);
    }

    public static Int32 IndexOf(this Array @this, System.Object value)
    {
        return Array.IndexOf(@this, value);
    }

    public static void Reverse(this Array @this)
    {
        Array.Reverse(@this);
    }

    public static T Find<T>(this T[] @this, Predicate<T> match)
    {
        return Array.Find(@this, match);
    }

    public static T[] FindAll<T>(this T[] array, Predicate<T> match)
    {
        return Array.FindAll(array, match);
    }

}
