/*
Given two strings s and t, return true if t is an anagram of s, 
and false otherwise.

An Anagram is a word or phrase formed by rearranging 
the letters of a different word or phrase, 
typically using all the original letters exactly once.

Example 1:

Input: s = "anagram", t = "nagaram"
Output: true
Example 2:

Input: s = "rat", t = "car"
Output: false


*/

public class Solution {
    public bool IsAnagram(string s, string t) {
        // Check if the lengths of the two input strings are different.
        if (s.Length != t.Length)
            return false;

        // Check if the two strings are the same. If they are, they are anagrams.
        if (s == t)
            return true;

        // Create dictionaries to store character counts for both strings.
        Dictionary<char, int> sCounts = new Dictionary<char, int>();
        Dictionary<char, int> tCounts = new Dictionary<char, int>();

        // Count the occurrences of each character in the 's' and 't' strings.
        for (int i = 0; i < s.Length; i++){
            // Increment the count of the current character in the 's' string.
            sCounts[s[i]] = 1 + (sCounts.ContainsKey(s[i]) ? sCounts[s[i]] : 0);
            
            // Increment the count of the current character in the 't' string.
            tCounts[t[i]] = 1 + (tCounts.ContainsKey(t[i]) ? tCounts[t[i]] : 0);
        }

        // Compare the character counts between 's' and 't'.
        foreach (char c in sCounts.Keys) {
            int tCount = tCounts.ContainsKey(c) ? tCounts[c] : 0;
            if (sCounts[c] != tCount)
                return false; // If character counts don't match, return false.
        }
        
        // If all character counts match, return true (they are anagrams).
        return true;
    }
}