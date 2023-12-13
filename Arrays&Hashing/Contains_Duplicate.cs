/*
Given an integer array nums, return true if any value appears at least twice 
in the array, and return false if every element is distinct.

Example 1:

Input: nums = [1,2,3,1]
Output: true
Example 2:

Input: nums = [1,2,3,4]
Output: false

*/

public class Solution {
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> set = new();

        foreach (int x in nums){
            if (set.Contains(x)) return true;
            set.Add(x); 
        }
        return false;
    }
}