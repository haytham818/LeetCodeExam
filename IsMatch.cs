
namespace LeetCodeExam;




public static class IsMatch {
    public static bool IsMatchS1(string s, string p) {
        if (s == null || p == null) return false;
        var dp = new bool[s.Length + 1, p.Length + 1];
        dp[0, 0] = true;
        for (var i = 0; i < p.Length; i++) {
            if (p[i] == '*' && dp[0, i - 1]) {
                dp[0, i + 1] = true;
            }
        }
        for (var i = 0; i < s.Length; i++) {
            for (var j = 0; j < p.Length; j++) {
                if (p[j] == '.') {
                    dp[i + 1, j + 1] = dp[i, j];
                }
                if (p[j] == s[i]) {
                    dp[i + 1, j + 1] = dp[i, j];
                }
                if (p[j] == '*') {
                    if (p[j - 1] != s[i] && p[j - 1] != '.') {
                        dp[i + 1, j + 1] = dp[i + 1, j - 1];
                    } else {
                        dp[i + 1, j + 1] = (dp[i + 1, j] || dp[i, j + 1] || dp[i + 1, j - 1]);
                    }
                }
            }
        }
        return dp[s.Length, p.Length];
    }
}