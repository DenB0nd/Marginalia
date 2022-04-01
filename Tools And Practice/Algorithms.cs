namespace Tools_And_Practice
{
    internal static class Algorithms
    {
        public static int BinarySearch<T>(T[] array, T num) where T : IComparable<T>
        {
            int first = 0;
            int last = array.Length;
            int mid;
            while (last > first)
            {
                mid = first + (last - first) / 2;
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

        public static int BinarySearchLowerBound<T>(T[] array, T num) where T : IComparable<T>
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

        public static int BinarySearchUpperBound<T>(T[] array, int num) where T : IComparable
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
                        matrix[i - 1, j - 1] + (firstWord[j - 1] == secondWord[i - 1] ? 0 : 1) * replaceValue

                    }.Min();
                }
            }

            return matrix[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
        }

        public static void QuickSort<T>(ref T[] array, int left, int right) where T : IComparable<T>
        {
            if (right <= left)
            {
                return;
            }

            int pivot = Partion(ref array, left, right);
            QuickSort(ref array, left, pivot);
            QuickSort(ref array, pivot + 1, right);

        }
        public static void Swap<T>(ref T firstElemrnt, ref T secondElement)
        {
            T buffer = firstElemrnt;
            firstElemrnt = secondElement;
            secondElement = buffer;
        }

        private static int Partion<T>(ref T[] array, int left, int right) where T : IComparable<T>
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
}
