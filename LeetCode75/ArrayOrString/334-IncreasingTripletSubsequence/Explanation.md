# 334 · Increasing Triplet Subsequence

## Problem

Given an integer array `nums`, return `true` if there exist three indices `i < j < k` such that:

```
nums[i] < nums[j] < nums[k]
```

Return `false` otherwise.

---

## Algorithm Overview

The core idea is to greedily track the **two smallest candidate values** for the first two elements of a triplet using just two variables.

```
min1 = smallest value seen so far
min2 = smallest value seen that is greater than some earlier min1
```

When you find any value greater than `min2`, a valid triplet exists — you don't need to know *which* index `min1` came from.