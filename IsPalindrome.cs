namespace LeetCodeExam;

static public class IsPalindrome
{
    static public bool IsPalindromeS1(int x)
    {
        var str1 = x.ToString();
        var arr = str1.Reverse().ToArray();
        var str2 = string.Join("", arr);
        return str1 == str2;
    }
}