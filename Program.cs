using System.Text;

namespace LeetCodeExam;

internal static class Program
{
    static void Main(string[] args)
    {
        var strs = new string[] { "repadafda", "replace", "refoidpasf" };
        var result = LeetCodeExam.LongestCommonPrefix.LongestCommonPrefixS1(strs);
        Console.WriteLine(result);
    }
}