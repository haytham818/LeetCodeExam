namespace LeetCodeExam;

public static class FindMedianSortedArrays
{
    public static double FindMedianSortedArraysS1(int[] nums1, int[] nums2)
    {
        var nums = nums1.Concat(nums2).ToArray();
        Array.Sort(nums);
        if (nums.Length%2 == 0)
        {
            return (double)(nums[nums.Length / 2] + nums[nums.Length / 2 - 1]) / 2;
        }
        return nums[(nums.Length - 1)/2];
    }
}