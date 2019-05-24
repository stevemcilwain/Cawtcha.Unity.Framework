using System;
using System.Collections.Generic;

public static class ListExtensions
{

    public static void Shuffle<T>(this IList<T> @this)
    {
        Random rng = new Random();
        int n = @this.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            T value = @this[k];
            @this[k] = @this[n];
            @this[n] = value;
        }
    }

    public static T RandomItem<T>(this IList<T> @this)
    {
        if (@this.Count == 0) throw new System.IndexOutOfRangeException("Cannot select a random item from an empty list");
        return @this[UnityEngine.Random.Range(0, @this.Count)];
    }

    public static T RemoveRandom<T>(this IList<T> @this)
    {
        if (@this.Count == 0) throw new System.IndexOutOfRangeException("Cannot remove a random item from an empty list");
        int index = UnityEngine.Random.Range(0, @this.Count);
        T item = @this[index];
        @this.RemoveAt(index);
        return item;
    }
}