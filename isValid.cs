namespace LeetCodeExam;

public class IsValid
{
    bool IsValidS1(string s)
    {
        var numOfa = s.Where(x => x == '(').Select(x => x).Count();
        var numOfb = s.Where(x => x == '[').Select(x => x).Count();
        var numOfc = s.Where(x => x == '{').Select(x => x).Count();
        var numOfa1 = s.Where(x => x == ')').Select(x => x).Count();
        var numOfb1 = s.Where(x => x == ']').Select(x => x).Count();
        var numOfc1 = s.Where(x => x == '}').Select(x => x).Count();
        return (numOfa + numOfa1)/2 != 0 || (numOfb + numOfb1)/2 != 0 || (numOfc1 + numOfc) /2 != 0;
    }
}