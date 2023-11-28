namespace LeetCodeExam;

public static class IsValid
{
    public static bool IsValidS1(string s)
    {
        var list1 = s.Where(item => item == '(').ToList();
        var list12 = s.Where(item => item == ')').ToList();
        var list21 = s.Where(item => item == '[').ToList();
        var list22 = s.Where(item => item == ']').ToList();
        var list31 = s.Where(item => item == '{').ToList();
        var list32 = s.Where(item => item == '}').ToList();
        return (list1.Count == list12.Count) && (list21.Count == list22.Count) && (list31.Count == list32.Count);
    }
}