namespace Tools_And_Practice.Algorithms;

public static class StringAlgorithms
{
    public static int LevenshteinDistance(string firstWord, string secondWord, int deleteValue = 1, int insertValue = 1, int replaceValue = 1)
    {
        int[,] matrix = new int[secondWord.Length + 1, firstWord.Length + 1];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            matrix[i, 0] = i * insertValue;
        }

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[0, j] = j * deleteValue;
        }

        for (int i = 1; i < matrix.GetLength(0); i++)
        {
            for (int j = 1; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = new[]
                {
                        matrix[i, j - 1] + deleteValue,
                        matrix[i - 1, j] + insertValue,
                        matrix[i - 1, j - 1] + ((firstWord[j - 1] == secondWord[i - 1] ? 0 : 1) * replaceValue)
                }.Min();
            }
        }

        return matrix[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    }
}
