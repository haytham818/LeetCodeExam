namespace LeetCodeExam;

public static class SearchRange
{
    public static int[] SearchRangeS1(int[] nums, int target) {
        if (!nums.Contains(target))
        {
            return new[] { -1, -1 };
        }
        var first = nums.ToList().IndexOf(target);
        var last = nums.ToList().LastIndexOf(target);
        return new[] { first, last };
    }
}