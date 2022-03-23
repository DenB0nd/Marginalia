namespace Tools_And_Practice
{
    internal static class EnumerableExtensions
    {
        internal static T[,] JaggedToMultidimensional<T>(this T[][] jaggedArray)
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

        internal static T[][] TwoDimensionalToJagged<T>(this T[,] twoDimensionalArray)
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
    }

}
