namespace LeetCodeExam;

public static class IsPalindromeChar
{
    public static bool IsPalindromeCharS1(string s)
    {
        var s1 = s.Where(char.IsLetter).Select(x => x);
        if (s1.Equals(s1.Reverse()))
        {
            return true;
        }

        return false;
    }
}