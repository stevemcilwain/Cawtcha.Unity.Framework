using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ComponentExtensions
{

    public static T Get<T>(this GameObject @this) where T : Component
    {
        T result = @this.GetComponent<T>();
        return result;
    }

}
