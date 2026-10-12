public class Solution
{
    public int MaxVowels(string s, int k)
    {
        int count = 0;
        int maxVowels = 0;

        // Count vowels in the first window
        for (int i = 0; i < k; i++)
        {
            if ("aeiou".Contains(s[i]))
                count++;
        }

        maxVowels = count;

        for (int i = k; i < s.Length; i++)
        {
            // Remove the character leaving the window
            if ("aeiou".Contains(s[i - k]))
                count--;

            // Add the new character entering the window
            if ("aeiou".Contains(s[i]))
                count++;

            maxVowels = Math.Max(maxVowels, count);

            // Maximum possible answer is k
            if (maxVowels == k)
                return k;
        }

        return maxVowels;
    }
}