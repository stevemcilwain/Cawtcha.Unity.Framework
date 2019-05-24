
using UnityEngine;

public static class GameObjectExtensions
{
    public static T GetComponentOrInterface<T>(this GameObject @this) where T : class
    {
        return @this.GetComponent(typeof(T)) as T;
    }
}
