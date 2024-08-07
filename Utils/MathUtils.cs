namespace ETVRTrackingModule.Utils;

public static class MathUtils
{
    public static T Clamp<T>(T val, T min, T max) where T : IComparable<T>
    {
        if (val.CompareTo(min) < 0) return min;
        if(val.CompareTo(max) > 0) return max;
        return val;
    }
    
    public static float SmoothStep(float edge0, float edge1, float x)
    {
        x = Clamp((x - edge0) / (edge1 - edge0), 0, 1);
        return x * x * (3 - 2 * x);
    }  
}