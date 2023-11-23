using System.Text;

namespace LeetCodeExam;

public class LongestCommonPrefix
{
    //LeetCode14
    public static string LongestCommonPrefixS1(string[] strs)
    {
        if (strs.Length == 0)
            return "";
        int minLength = strs.Min(s => s.Length);
        StringBuilder commonPrefix = new StringBuilder();
        for (int i = 0; i < minLength; i++)
        {
            char currentChar = strs[0][i];
            if (strs.All(s => s[i] == currentChar))
            {
                commonPrefix.Append(currentChar);
            }
            else
            {
                break;
            }
        }
        return commonPrefix.ToString();
    }
    //Todo:另外方法；
}