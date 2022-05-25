namespace Marginalia.Extensions;

public static class RandomExtensions
{
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
