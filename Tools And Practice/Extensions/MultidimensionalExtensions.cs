namespace Marginalia.Extensions;
public static class MultidimensionalExtensions
{
    public static T[,] ToTwoDimensional<T>(this T[][] jaggedArray)
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

    public static T[][] ToJagged<T>(this T[,] twoDimensionalArray)
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

    
    public static T[,] ToTwoDimensional<T>(this T[] array, int columns)
    {
        int rows = array.Length / columns + (array.Length % columns == 0 ? 0 : 1);

        T[,] twoDimensionalArray = new T[rows, columns];

        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < columns; j++)
            {
                twoDimensionalArray[i, j] = default(T);
                int index = i * columns + j;
                if (index < array.Length)
                {
                    twoDimensionalArray[i, j] = array[index];
                }            
            }
        }

        return twoDimensionalArray;
    }
}
