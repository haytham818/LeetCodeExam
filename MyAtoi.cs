namespace LeetCodeExam;

public static class MyAtoi {
    public static int MyAtoiS1(string s) {
        int i = 0, sign = 1;
        long res = 0;
        while (i < s.Length && s[i] == ' ') {
            i++;
        }
        if (i < s.Length && (s[i] == '-' || s[i] == '+')) {
            if (s[i] == '-') {
                sign = -1;
            }
            i++;
        }
        while (i < s.Length && s[i] >= '0' && s[i] <= '9') {
            res = res * 10 + (s[i] - '0');
            if (sign == 1 && res > int.MaxValue) {
                return int.MaxValue;
            }
            if (sign == -1 && -res < int.MinValue) {
                return int.MinValue;
            }
            i++;
        }
        return sign * (int)res;
    }
}