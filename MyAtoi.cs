namespace LeetCodeExam;

public static class MyAtoi
{
    public static int MyAtoiS1(string s)
    {
        bool isNegative = s.Contains('-');
        if (s.IndexOf(s.FirstOrDefault(x => x == '-')) > s.IndexOf(s.FirstOrDefault(x => x is >= '0' and <= '9')))
        {
            isNegative = false;
        }
        if (string.IsNullOrWhiteSpace(s))
        {
            return 0;
        }

        var isNum = long.TryParse(s, out var result);
        if (isNum)
        {
            if (result is >= int.MinValue and <= int.MaxValue)
            {
                return (int)result;
            }
            switch (result)
            {
                case >= int.MaxValue:
                    return int.MaxValue;
                case <= int.MinValue:
                    return int.MinValue;
            }
        }
        var list = new List<char>();
        s = s.TrimStart();
        foreach (var t in s)
        {
            if (t is >= '0' and <= '9')
            {
                list.Add(t);
            }
            else if (t == '-')
            {
                _ = t;
            }
            else
            {
                break;
            }
        }
        var str = string.Join("", list.ToArray());
        if (string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str))
        {
            return 0;
        }
        var res = long.TryParse(str, out var temp);
        if (isNegative)
        {
            return -Convert.ToInt32(str);
        }
        return Convert.ToInt32(str);
    }
}