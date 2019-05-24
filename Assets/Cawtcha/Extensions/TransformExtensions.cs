

using UnityEngine;

public static class TransformExtensions
{
    public static void SetParentAndReset(this Transform @this, Transform parent)
    {
        @this.parent = parent;
        @this.localPosition = Vector3.zero;
        @this.localRotation = Quaternion.identity;
        @this.localScale = Vector3.one;
    }

    public static T GetComponentOrInterface<T>(this Transform @this) where T : class
    {
        return @this.GetComponent(typeof(T)) as T;
    }

    public static void SetLocalPositionX(this Transform @this, float value)
    {
        var localPosition = @this.localPosition;
        localPosition.x = value;
        @this.localPosition = localPosition;
    }

    public static void SetLocalPositionY(this Transform @this, float value)
    {
        var localPosition = @this.localPosition;
        localPosition.y = value;
        @this.localPosition = localPosition;
    }

    public static void SetLocalPositionZ(this Transform @this, float value)
    {
        var localPosition = @this.localPosition;
        localPosition.z = value;
        @this.localPosition = localPosition;
    }

    public static void SetPositionX(this Transform @this, float value)
    {
        var position = @this.position;
        position.x = value;
        @this.position = position;
    }

    public static void SetPositionY(this Transform @this, float value)
    {
        var position = @this.position;
        position.y = value;
        @this.position = position;
    }

    public static void SetPositionZ(this Transform @this, float value)
    {
        var position = @this.position;
        position.z = value;
        @this.position = position;
    }
}
