namespace Tools_And_Practice.Extentions;

public static class EnumerableExtensions
{
    public static T[,] JaggedToMultidimensional<T>(this T[][] jaggedArray)
    {
        int rows = jaggedArray.Length;
        int columns = jaggedArray.Max(subArray => subArray.Length);

        T[,] twoDimensionalArray = new T[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                twoDimensionalArray[i, j] = jaggedArray[i][j];
            }
        }

        return twoDimensionalArray;
    }

    public static T[][] TwoDimensionalToJagged<T>(this T[,] twoDimensionalArray)
    {
        int rowsFirstIndex = twoDimensionalArray.GetLowerBound(0);
        int rowsLastIndex = twoDimensionalArray.GetUpperBound(0);
        int numberOfRows = rowsLastIndex - rowsFirstIndex + 1;

        int columnsFirstIndex = twoDimensionalArray.GetLowerBound(1);
        int columnsLastIndex = twoDimensionalArray.GetUpperBound(1);
        int numberOfColumns = columnsLastIndex - columnsFirstIndex + 1;

        T[][] jaggedArray = new T[numberOfRows][];
        for (int i = 0; i < numberOfRows; i++)
        {
            jaggedArray[i] = new T[numberOfColumns];

            for (int j = 0; j < numberOfColumns; j++)
            {
                jaggedArray[i][j] = twoDimensionalArray[i + rowsFirstIndex, j + columnsFirstIndex];
            }
        }

        return jaggedArray;
    }

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
}
