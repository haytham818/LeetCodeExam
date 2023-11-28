namespace LeetCodeExam;

public static class StrStr
{
    public static int StrStrS1(string haystack, string needle)
    {
        if (!haystack.Contains(needle))
        {
            return -1;
        }
        return haystack.IndexOf(needle, StringComparison.Ordinal);
    }
}