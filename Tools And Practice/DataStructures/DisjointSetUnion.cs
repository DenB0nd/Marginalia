namespace Marginalia.Structures;

public class DisjointSetUnion
{
    private readonly int[] _sets;
    private readonly Random _random = new Random();

    public int SetsCount { get; private set; }

    public DisjointSetUnion(int size) => _sets = new int[size];

    public void MakeSet(int x)
    {
        _sets[x] = x;
        SetsCount++;
    }

    public int Find(int x)
    {
        if (_sets[x] == x)
        {
            return x;
        }

        return _sets[x] = Find(_sets[x]);
    }

    public void Unite(int x, int y)
    {
        x = Find(x);
        y = Find(y);

        if (x != y)
        {
            SetsCount--;
        }

        if (_random.Next() % 2 == 0)
        {
            (x, y) = (y, x);
        }

        _sets[x] = y;
    }
}
