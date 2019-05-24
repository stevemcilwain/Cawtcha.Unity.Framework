

using UnityEngine;

public static class ColorExtensions
{
    public static Color SetAlpha(this Color @this, float alpha)
    {
        return new Color(@this.r, @this.g, @this.b, alpha);
    }

    public static Color FromRGB(this Color @this, int r, int g, int b)
    {
        return new Color(r / 255f, g / 255f, b / 255f, 1f);
    }

    public static Color FromHex(this Color @this, string hex)
    {
        byte r = byte.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
        byte g = byte.Parse(hex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
        byte b = byte.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
        return new Color32(r, g, b, 255);
    }

}
