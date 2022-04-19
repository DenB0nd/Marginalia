namespace Tools_And_Practice.Structures;

class DSU
{
    private int[] _sets = new int[1];
    private Random _random = new Random();

    public int SetsCount { get; private set; }

    public DSU(int size)
    {
        _sets = new int[size];
    }

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
