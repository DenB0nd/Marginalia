using System.Collections.Generic;

namespace Marginalia.Extensions;

public static class EnumerableExtensions
{
    public static IEnumerable<T> GetColumn<T>(this T[,] matrix, int columnNumber)
    {
        ArgumentNullException.ThrowIfNull(matrix, nameof(matrix));

        if (columnNumber < 0 || columnNumber >= matrix.GetLength(1))
        {
            return Enumerable.Empty<T>();
        }
        
        return Enumerable.Range(0, matrix.GetLength(0))
            .Select(x => matrix[x, columnNumber]);
    }

    public static IEnumerable<T> GetRow<T>(this T[,] matrix, int rowNumber)
    {
        ArgumentNullException.ThrowIfNull(matrix, nameof(matrix));

        if (rowNumber < 0 || rowNumber >= matrix.GetLength(0))
        {
            return Enumerable.Empty<T>();
        }

        return Enumerable.Range(0, matrix.GetLength(1))
                .Select(x => matrix[rowNumber, x]);
    }

    public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> enumerable)
    {
        ArgumentNullException.ThrowIfNull(enumerable, nameof(enumerable));

        var buffer = enumerable.ToArray();
        for (int i = 0; i < buffer.Length; i++)
        {
            int j = Random.Shared.Next(i, buffer.Length);
            yield return buffer[j];

            buffer[j] = buffer[i];
        }
    }

    public static string ConvertToString<T>(this IEnumerable<T> enumerable, string separator = "")
    {
        ArgumentNullException.ThrowIfNull(enumerable);
        ArgumentNullException.ThrowIfNull(separator);

        return string.Join(separator, enumerable.Select(x => x?.ToString()));
    }

    public static IEnumerable<T> IntersectWithDuplicates<T>(this IEnumerable<T> first, IEnumerable<T> second)
    {
        ArgumentNullException.ThrowIfNull(first);
        ArgumentNullException.ThrowIfNull(second);
        
        var buff = second.ToList();
        return first.Where(s => buff.Remove(s));
    }


    public static bool IsSorted<T>(this IEnumerable<T> values) where T : IComparable<T>
    {
        ArgumentNullException.ThrowIfNull(values);

        if(!values.Any())
        {
            return true;
        }

        var prev = values.First();
        foreach (var item in values.Skip(1))
        {
            if(prev.CompareTo(item) > 0)
            {
                return false;
            }
            prev = item;
        }
        return true;
    }
}
