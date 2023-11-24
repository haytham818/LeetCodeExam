namespace LeetCodeExam;

public static class Reverse
{
    public static int ReverseS1(int x)
    {
        try
        {
            if (x >=0)
            {
                var str = x.ToString();
                var RevStr = string.Join("", str.Reverse().ToArray());
                var result = Convert.ToInt32(RevStr);
                return result;
            }

            var str1 = Math.Abs(x).ToString();
            var RevStr1 = string.Join("", str1.Reverse().ToArray());
            var result1 = -Convert.ToInt32(RevStr1);
            return result1;
        }
        catch (OverflowException e)
        {
            return 0;
        }
    }
}