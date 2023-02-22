namespace Marginalia.Extensions;

public static class RandomExtensions
{
    const string ALPHANUMERIC_CHARS = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

    public static string NextAlphanumeric(this Random random, int length = 1)
    {
        var result = new char[length];
        for(int i = 0; i < length; i++)
        {
            result[i] = ALPHANUMERIC_CHARS[random.Next(ALPHANUMERIC_CHARS.Length)];
        }
        return new string (result);
    }

    public static int NextInt32(this Random random)
    {
        int firstBits = Random.Shared.Next(0, 1 << 4) << 28;
        int lastBits = Random.Shared.Next(0, 1 << 28);
        return firstBits | lastBits;
    }

    //Jon Skeet's code doesn't follow a coding convention.
    //It IS the coding convention.
    public static decimal NextDecimal(this Random random)
    {
        byte scale = (byte)random.Next(29);
        bool sign = random.Next(2) == 1;
        return new decimal(random.NextInt32(),
                           random.NextInt32(),
                           random.NextInt32(),
                           sign,
                           scale);
    }
}
