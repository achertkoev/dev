public class TwoSum
{
    /// <summary>
    /// Вернуть индексы двух чисел из массива nums, сумма которых равна target. 
    /// </summary>
    /// <param name="nums">Массив чисел</param>
    /// <param name="target">Целевое значение</param>
    /// <returns></returns> 
    public int[] GetIndices(int[] nums, int target)
    {

        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = 1; j <= nums.Length - 1; j++)
            {
                if (nums[i] + nums[j] == target && i != j)
                    return new int[] { j, i };
            }
        }

        return Array.Empty<int>();

    }
}