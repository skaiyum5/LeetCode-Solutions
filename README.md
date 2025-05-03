# LeetCode Solutions

A collection of my solutions to various LeetCode problems, organized by difficulty and topic.

![LeetCode Stats](https://leetcode-stats-six.vercel.app/?username=YOUR_LEETCODE_USERNAME&theme=dark)

## Repository Structure

```
├── README.md
├── Easy
│   ├── Arrays
│   ├── Strings
│   ├── Linked Lists
│   └── ...
├── Medium
│   ├── Arrays
│   ├── Dynamic Programming
│   ├── Trees
│   └── ...
└── Hard
    ├── Arrays
    ├── Graphs
    ├── Dynamic Programming
    └── ...
```

## Solution Format

Each solution file follows this format:

```
# Problem Title
# Problem Number: XXX
# Difficulty: Easy/Medium/Hard
# URL: https://leetcode.com/problems/problem-slug/

# Problem Description
"""
Brief description of the problem...
"""

# Approach
"""
My approach to solving this problem...
"""

# Complexity Analysis
"""
- Time Complexity: O(...)
- Space Complexity: O(...)
"""

# Solution
class Solution:
    def functionName(self, params):
        # Implementation
        pass

# Test Cases
"""
Input: ...
Output: ...
"""
```

## Stats

| Difficulty | Solved |
|------------|--------|
| Easy       | 0      |
| Medium     | 0      |
| Hard       | 0      |
| Total      | 0      |

## Topics Covered

- Arrays & Strings
- Hash Tables
- Linked Lists
- Trees & Graphs
- Dynamic Programming
- Sorting & Searching
- Recursion & Backtracking
- Design

## My LeetCode Profile

[View My LeetCode Profile](https://leetcode.com/YOUR_LEETCODE_USERNAME/)

## License

This repository is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.



# 1. Two Sum
# Problem Number: 1
# Difficulty: Easy
# URL: https://leetcode.com/problems/two-sum/

# Problem Description
"""
Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
You may assume that each input would have exactly one solution, and you may not use the same element twice.
You can return the answer in any order.

Example:
Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
"""

# Approach
"""
Use a hash table to store the values we've seen so far along with their indices.
For each number, check if (target - current number) exists in our hash table.
If it does, we've found our pair and return the indices.
This gives us O(n) time complexity using a single pass through the array.
"""

# Complexity Analysis
"""
- Time Complexity: O(n) where n is the length of the input array
- Space Complexity: O(n) for the hash table
"""

# Solution
class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        # Create a dictionary to store values and their indices
        seen = {}
        
        # Iterate through the array
        for i, num in enumerate(nums):
            # Calculate the complement we need to find
            complement = target - num
            
            # Check if the complement exists in our hash table
            if complement in seen:
                # Return the indices of the two numbers
                return [seen[complement], i]
            
            # Store the current number and its index
            seen[num] = i
        
        # No solution found (though problem states there will always be one)
        return []

# Test Cases
"""
Test Case 1:
Input: nums = [2,7,11,15], target = 9
Output: [0,1]

Test Case 2:
Input: nums = [3,2,4], target = 6
Output: [1,2]

Test Case 3:
Input: nums = [3,3], target = 6
Output: [0,1]
"""