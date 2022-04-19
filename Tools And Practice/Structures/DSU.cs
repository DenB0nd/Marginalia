namespace Tools_And_Practice.Structures;

class DSU
{
    private Dictionary<int, int> _sets = new Dictionary<int, int>();

    public int SetsCount => _sets.Where(s => s.Key == s.Value).Count();

    public void MakeSet(int x)
    {
        _sets[x] = x;
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

        if (Random.Shared.Next() % 2 == 0)
        {
            (x, y) = (y, x);
        }
        _sets[x] = y;
    }
}
