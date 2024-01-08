namespace Marginalia.Algorithms;

public static class SortingAlgorithms
{
    public static void QuickSort<T>(ref T[] array, int left, int right)
        where T : IComparable<T>
    {
        if (right <= left)
        {
            return;
        }

        int pivot = Partion(ref array, left, right);
        QuickSort(ref array, left, pivot);
        QuickSort(ref array, pivot + 1, right);
    }

    private static int Partion<T>(ref T[] array, int left, int right)
        where T : IComparable<T>
    {
        T pivot = array[Random.Shared.Next(left, right + 1)];
        while (true)
        {
            while (array[left].CompareTo(pivot) < 0)
            {
                left++;
            }

            while (array[right].CompareTo(pivot) > 0)
            {
                right--;
            }

            if (left >= right)
            {
                break;
            }

            (array[left], array[right]) = (array[right], array[left]);
            left++;
            right--;
        }

        return right;
    }

}
