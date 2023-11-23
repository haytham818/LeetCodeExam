namespace LeetCodeExam;

public class TwoSum
{
    //LeetCode1
    public static int[] TwoSumS1(int[] nums, int target) {
        var map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            var key = target - nums[i];
            if (map.ContainsKey(key))
            {
                return new int[] {map[key],i};
            } 
            map[nums[i]] = i;
        }
        return new int[] { 0 };
    }
}