using System.Collections;

namespace LeetCodeExam;

public class SearchInsert
{
    public static int SearchInsertS1(int[] nums, int target)
    {
        var nums1 = nums.ToList();
        if (nums.Contains(target))
        {
            return nums1.IndexOf(target);
        }
        nums1.Add(target);
        nums1.Sort();
        return nums1.IndexOf(target);
    }
}