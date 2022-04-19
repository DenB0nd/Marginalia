namespace Tools_And_Practice.Algorithms;

public static class MathAlgorithms
{
    public static int GCD(int firstNumber, int secondNumber)
    {
        while (firstNumber != 0 && secondNumber != 0)
        {
            if (firstNumber > secondNumber)
            {
                firstNumber %= secondNumber;
            }
            else
            {
                secondNumber %= firstNumber;
            }
        }

        return firstNumber | secondNumber;
    }

    public static int GCD(IEnumerable<int> enumerable)
    {
        int[] array = enumerable.ToArray();

        if (!array.Any())
        {
            return 0;
        }

        array = array.Distinct().ToArray();

        if (array.Length == 1)
        {
            return array[0];
        }

        for (int i = 1; i < array.Length; i++)
        {
            array[i] = GCD(array[i], array[i - 1]);
        }

        return array[^1];
    }

    public static int LCM(int firstNumber, int secondNumber)
    {
        return (firstNumber * secondNumber) / GCD(firstNumber, secondNumber);
    }

    public static int LCM(IEnumerable<int> enumerable)
    {
        int[] array = enumerable.ToArray();

        if (!array.Any())
        {
            return 0;
        }

        array = array.Distinct().ToArray();

        if (array.Length == 1)
        {
            return array[0];
        }

        for (int i = 1; i < array.Length; i++)
        {
            array[i] = LCM(array[i], array[i - 1]);
        }

        return array[^1];
    }
}
