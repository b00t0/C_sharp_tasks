// 1480. Running Sum of 1d Array
// Given an array nums. We define a running sum of an array as 
// runningSum[i] = sum(nums[0]…nums[i]).
// Return the running sum of nums.

// Example 1:
// Input: nums = [1,2,3,4]
// Output: [1,3,6,10]
// Explanation: Running sum is obtained as follows: [1, 1+2, 1+2+3, 1+2+3+4].

Console.Clear();

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }

    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t");
    }
}

void RunningSum(int[] array)
{
    for (int i = 1; i < array.Length; i++)
    {
        array[i] = array[i]+ array[i-1];
    }
}

int[] newArray = CreateArrayRndInt(8, 0, 20);
PrintArray(newArray);

Console.WriteLine();

RunningSum(newArray);
PrintArray(newArray);


