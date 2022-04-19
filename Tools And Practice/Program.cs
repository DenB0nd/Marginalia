using Tools_And_Practice.Algorithms;

int[] nums = Enumerable.Repeat(0, 30).Select(x => Random.Shared.Next(50)).ToArray();

SortingAlgorithms.QuickSort(ref nums, 0, nums.Length - 1);

foreach (int i in nums)
{
    Console.WriteLine(i);
}