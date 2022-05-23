namespace Tools_And_Practice.Algorithms;

public static class BinarySearches
{
    public static int BinarySearch<T>(this IEnumerable<T> enumerable, T value)
        where T : IComparable<T>
    {
        var array = enumerable.ToArray();
        int first = 0;
        int last = array.Length;
        int mid;
        while (last > first)
        {
            mid = first + ((last - first) / 2);
            if (value.Equals(array[mid]))
            {
                return mid;
            }

            if (value.CompareTo(array[mid]) > 0)
            {
                first = mid + 1;
            }
            else
            {
                last = mid;
            }
        }

        return -1;
    }

    public static int BinarySearchLowerBound<T>(this IEnumerable<T> enumerable, T value)
        where T : IComparable<T>
    {
        var array = enumerable.ToArray();
        int first = 0;
        int last = array.Length;
        int mid;
        while (last > first)
        {
            mid = (first + last) / 2;
            if (value.CompareTo(array[mid]) > 0)
            {
                first = mid + 1;
            }
            else
            {
                last = mid;
            }
        }

        return last;
    }

    public static int BinarySearchUpperBound<T>(this IEnumerable<T> enumerable, T value) 
        where T : IComparable
    {
        var array = enumerable.ToArray();
        int first = 0;
        int last = array.Length;
        int mid;
        while (last > first)
        {
            mid = (first + last) / 2;
            if (value.CompareTo(array[mid]) < 0)
            {
                last = mid;
            }
            else
            {
                first = mid + 1;
            }
        }

        return last;
    }
}
