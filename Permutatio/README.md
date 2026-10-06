# HSE Entrance Exam - Expected Inversions

This folder contains a solution for a combinatorial problem from the Higher School of Economics (HSE) entrance exam.

## Problem Description

Given a permutation of $n$ natural numbers from 1 to n (2 <= n <= 2000). An **inversion** is defined as a situation where a number x appears to the left of y, but x > y.

We choose two distinct elements uniformly at random and swap them. The goal is to find the **expected (average) number of inversions** across all possible pairs of elements that can be swapped.

### Input Format
* The first line contains an integer n (2 <= n <= 2000).
* The second line contains n distinct integers representing the initial permutation.

### Output Format
* Print the irreducible fraction a/b representing the average number of inversions.

## Examples

### Example 1
**Input:**
5
1 2 3 4 5
**Output:**
3/1
### Example 2
**Input:**
3
3 1 2
**Output:**
5/3
