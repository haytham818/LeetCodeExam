namespace LeetCodeExam;

public static class NumDecodings
{
    public static int NumDecodingsS1(string s) {
        if (s[0] == '0') {
            return 0;
        }
        int n = s.Length;
        int[] dp = new int[n + 1];
        dp[0] = 1;
        dp[1] = 1;
        for (int i = 2; i <= n; i++) {
            int digit0 = s[i - 2] - '0', digit1 = s[i - 1] - '0';
            if (digit0 != 0 && digit0 * 10 + digit1 <= 26) {
                    dp[i] += dp[i - 2];
            }
            if (digit1 != 0) {
                    dp[i] += dp[i - 1];
            }
        }
        return dp[n];
    }
}