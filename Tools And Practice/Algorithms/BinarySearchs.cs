namespace Tools_And_Practice.Algorithms;

public static class BinarySearchs
{
    public static int BinarySearch<T>(T[] array, T num)
        where T : IComparable<T>
    {
        int first = 0;
        int last = array.Length;
        int mid;
        while (last > first)
        {
            mid = first + ((last - first) / 2);
            if (num.Equals(array[mid]))
            {
                return mid;
            }

            if (num.CompareTo(array[mid]) > 0)
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

    public static int BinarySearchLowerBound<T>(T[] array, T num)
        where T : IComparable<T>
    {
        int first = 0;
        int last = array.Length;
        int mid;
        while (last > first)
        {
            mid = (first + last) / 2;
            if (num.CompareTo(array[mid]) > 0)
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

    public static int BinarySearchUpperBound<T>(T[] array, int num) 
        where T : IComparable
    {
        int first = 0;
        int last = array.Length;
        int mid;
        while (last > first)
        {
            mid = (first + last) / 2;
            if (num.CompareTo(array[mid]) < 0)
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
