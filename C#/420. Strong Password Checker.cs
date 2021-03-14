/*
 * Link: https://leetcode.com/problems/strong-password-checker/
 * Author: Dung Nguyen Tien (Chris)
 * Idea
*/

public class Solution {
    public int StrongPasswordChecker(string s)
        {
            int requiredChar = GetRequiredChar(s);
            if (s.Length < 6) return Math.Max(requiredChar, 6 - s.Length);

            // only need replacement and deletion now when s.Length >= 6
            int replace = 0; // total replacements for repeated chars. e.g. "aaa" needs 1 replacement to fix
            int oned = 0; // total deletions for 3n repeated chars. e.g. "aaa" needs 1 deletion to fix
            int twod = 0; // total deletions for 3n+1 repeated chars. e.g. "aaaa" needs 2 deletions to fix.

            for (int i = 0; i < s.Length;)
            {
                int len = 1; // repeated len
                while (i + len < s.Length && s[i + len] == s[i + len - 1]) len++;
                if (len >= 3)
                {
                    replace += len / 3;
                    if (len % 3 == 0) oned += 1;
                    if (len % 3 == 1) twod += 2;
                }
                i += len;
            }

            // no need deletion when s.Length <= 20
            if (s.Length <= 20) return Math.Max(requiredChar, replace);

            int deleteCount = s.Length - 20;

            // deleting 1 char in (3n) repeated chars will save one replacement
            replace -= Math.Min(deleteCount, oned);

            // deleting 2 chars in (3n+1) repeated chars will save one replacement
            replace -= Math.Min(Math.Max(deleteCount - oned, 0), twod) / 2;

            // deleting 3 chars in (3n+2) repeated chars will save one replacement
            replace -= Math.Max(deleteCount - oned - twod, 0) / 3;

            return deleteCount + Math.Max(requiredChar, replace);
        }

        int GetRequiredChar(string s)
        {
            int lowercase = 1, uppercase = 1, digit = 1;
            foreach (var c in s)
            {
                if (char.IsLower(c)) lowercase = 0;
                else if (char.IsUpper(c)) uppercase = 0;
                else if (char.IsDigit(c)) digit = 0;
            }

            return lowercase + uppercase + digit;
        }
}