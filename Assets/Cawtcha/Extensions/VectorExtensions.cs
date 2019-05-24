
using UnityEngine;

public static class VectorExtensionMethods {

	public static Vector2 ToVector2(this Vector3 v) {
		return new Vector2(v.x, v.y);
	}

    public static Vector3 ToVector3(this Vector2 v, float z)
    {
        return new Vector3(v.x, v.y, z);
    }

    public static Vector3 SetX(this Vector3 v, float x) {
		return new Vector3(x, v.y, v.z);
	}

	public static Vector3 SetY(this Vector3 v, float y) {
		return new Vector3(v.x, y, v.z);
	}

	public static Vector3 SetZ(this Vector3 v, float z) {
		return new Vector3(v.x, v.y, z);
	}

	public static Vector2 SetX(this Vector2 v, float x) {
		return new Vector2(x, v.y);
	}
	
	public static Vector2 SetY(this Vector2 v, float y) {
		return new Vector2(v.x, y);
	}

    public static Vector2 PlusX(this Vector2 vector, float plusX)
    {
        return new Vector2(vector.x + plusX, vector.y);
    }

    public static Vector2 PlusY(this Vector2 vector, float plusY)
    {
        return new Vector2(vector.x, vector.y + plusY);
    }

    public static Vector2 TimesX(this Vector2 vector, float timesX)
    {
        return new Vector2(vector.x * timesX, vector.y);
    }

    public static Vector2 TimesY(this Vector2 vector, float timesY)
    {
        return new Vector2(vector.x, vector.y * timesY);
    }

    public static Vector2 Rotate(this Vector2 vector, float degrees)
    {
        float sin = Mathf.Sin(degrees * Mathf.Deg2Rad);
        float cos = Mathf.Cos(degrees * Mathf.Deg2Rad);

        float tx = vector.x;
        float ty = vector.y;
        vector.x = (cos * tx) - (sin * ty);
        vector.y = (sin * tx) + (cos * ty);
        return vector;
    }

    public static Vector3 PlusX(this Vector3 vector, float plusX)
    {
        return new Vector3(vector.x + plusX, vector.y, vector.z);
    }

    public static Vector3 PlusY(this Vector3 vector, float plusY)
    {
        return new Vector3(vector.x, vector.y + plusY, vector.z);
    }

    public static Vector3 PlusZ(this Vector3 vector, float plusZ)
    {
        return new Vector3(vector.x, vector.y, vector.z + plusZ);
    }

    public static Vector3 TimesX(this Vector3 vector, float timesX)
    {
        return new Vector3(vector.x * timesX, vector.y, vector.z);
    }

    public static Vector3 TimesY(this Vector3 vector, float timesY)
    {
        return new Vector3(vector.x, vector.y * timesY, vector.z);
    }

    public static Vector3 TimesZ(this Vector3 vector, float timesZ)
    {
        return new Vector3(vector.x, vector.y, vector.z * timesZ);
    }
    
}
