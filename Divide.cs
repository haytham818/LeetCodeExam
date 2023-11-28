namespace LeetCodeExam;

public static class Divide
{
    public static int DivideS1(int dividend, int divisor)
    {
        long newDividend = Math.Abs((long)dividend);
        long newDivisor = Math.Abs((long)divisor);
        bool isNegative = (dividend < 0) ^ (divisor < 0);
        if (divisor == 0)
        {
            throw new DivideByZeroException();
        }
        if (dividend == int.MinValue && divisor == -1)
        {
            return int.MaxValue;
        }
        long result = 0;
        for (int bit = 31; bit >= 0; bit--)
        {
            if ((newDividend >> bit) >= newDivisor)
            {
                result = (result << 1) | 1;
                newDividend -= newDivisor << bit;
            }
            else
            {
                result <<= 1;
            }
        }
        result = isNegative ? -result : result;
        if (result is > int.MaxValue or < int.MinValue)
        {
            throw new OverflowException();
        }
        return (int)result;
    }
}