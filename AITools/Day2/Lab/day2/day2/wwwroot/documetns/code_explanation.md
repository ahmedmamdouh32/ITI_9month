# Quick Sort Implementation Explanation

This document explains the quick sort implementation used in `HomeController`.

- Purpose: The controller parses user input into `model.Original`, clones that array, calls `QuickSort` on the clone, and stores the result in `model.Sorted`. Cloning preserves the original order for display.

- `QuickSort(int[] a, int left, int right)`:
  - Recursive, in-place implementation.
  - Base case: `if (left >= right) return;` — when the subarray has zero or one element.
  - Calls `Partition` to place the pivot in its final position and get `pivotIndex`.
  - Recursively sorts the left subarray `left..pivotIndex-1` and the right `pivotIndex+1..right`.

- `Partition(int[] a, int left, int right)`:
  - Chooses the pivot as `a[right]` (the last element of the subarray).
  - Uses index `i` initialized to `left - 1`. `i` tracks the boundary of elements <= pivot.
  - Iterates `j` from `left` to `right - 1`. For each `a[j]`:
    - If `a[j] <= pivot`, increments `i` and swaps `a[i]` and `a[j]`. That moves smaller-or-equal items to the left side.
  - After the loop, swaps `a[i+1]` with the pivot at `a[right]` so pivot sits between smaller and larger elements.
  - Returns `i + 1` (the pivot final index).

- `Swap(int[] a, int i, int j)`:
  - Simple element swap with a temporary variable; does nothing if `i == j`.

- Behavior and properties:
  - In-place: sorts the array without creating a new array (aside from recursion stack).
  - Not stable: equal elements may change relative order.
  - Pivot choice: last element. That is simple but can cause worst-case O(n^2) on already sorted or specially arranged input.
  - Time complexity: average O(n log n), worst-case O(n^2).
  - Space complexity: O(log n) average recursion depth, O(n) worst-case recursion depth.

- Example walkthrough (array `[3, 1, 4, 2]`):
  - Pivot = 2 (last element).
  - Partition moves 1 left of pivot and places pivot between `[1]` and `[3,4]`, pivot index becomes 1.
  - Recurse on `[3]` (left) and `[4,3]` (right) until fully sorted → `[1,2,3,4]`.

Notes / Suggestions:
- Consider changing pivot selection (median-of-three or random) to reduce worst-case risk.
- An iterative version can avoid recursion depth issues for very large arrays.
- For production code, validate input sizes and consider using `Array.Sort` for general use unless demonstrating algorithms.
