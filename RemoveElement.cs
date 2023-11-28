using System.Collections;

namespace LeetCodeExam;

public static class RemoveElement
{
    public static IEnumerable RemoveElementS1(int[] nums, int val)
    {
        return nums.Where(x => x != val).Select(x => x);
    }
}