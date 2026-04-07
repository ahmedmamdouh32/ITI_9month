# Sorting Algorithms Comparison: QuickSort, MergeSort, HeapSort

This document summarizes time and space complexity, stability, memory behavior, and practical notes for QuickSort, MergeSort, and HeapSort.

---

## QuickSort

- Summary: In-place, comparison-based, divide-and-conquer; typically chooses a pivot and partitions array into elements less-than-or-equal and greater-than pivot, then recursively sorts partitions.
- Time complexity:
  - Best: O(n log n)
  - Average: O(n log n)
  - Worst: O(n^2) (e.g., already sorted input with poor pivot choice)
- Space complexity:
  - Extra space: O(log n) average stack space for recursion; O(n) worst-case recursion depth without tail-call elimination
  - In-place: yes (sorts the array itself, no auxiliary array required)
- Stability: Not stable (equal elements may change relative order)
- Notes:
  - Very fast in practice due to good cache locality and small constant factors.
  - Pivot choice matters: using random pivot or median-of-three reduces worst-case likelihood.
  - Not ideal for large linked lists (no random access) or for stable sorting needs.

---

## MergeSort

- Summary: Stable, divide-and-conquer algorithm that splits array into halves, recursively sorts both, and merges sorted halves using an auxiliary array.
- Time complexity:
  - Best: O(n log n)
  - Average: O(n log n)
  - Worst: O(n log n)
- Space complexity:
  - Extra space: O(n) for a typical top-down implementation (auxiliary array for merging)
  - There are in-place variants with worse constants and complexity; those are rarely used in practice.
- Stability: Stable (preserves relative order of equal elements)
- In-place: Not typically in-place (requires auxiliary memory for merge)
- Notes:
  - Predictable running time; good for large datasets and external sorting (merge-based external algorithms).
  - Parallelizes well (merge steps can run concurrently).
  - Slightly worse cache locality than QuickSort, but often chosen when stability or guaranteed O(n log n) time is required.

---

## HeapSort

- Summary: Builds a binary heap from the array then repeatedly extracts the maximum (or minimum) to produce a sorted sequence. Comparison-based and in-place.
- Time complexity:
  - Best: O(n log n)
  - Average: O(n log n)
  - Worst: O(n log n)
- Space complexity:
  - Extra space: O(1) auxiliary (in-place)
  - Recursion: typically iterative; constant extra memory beyond input
- Stability: Not stable (heap operations change relative order of equal elements)
- In-place: Yes
- Notes:
  - Guarantees O(n log n) worst-case time without extra memory.
  - Poorer cache performance than QuickSort due to non-sequential memory access patterns.
  - Often used when guaranteed worst-case time and O(1) aux memory are required.

---

## Practical Comparison / When to use

- QuickSort:
  - Use when average-case performance and low memory overhead are desired.
  - Choose randomized or median-of-three pivot to avoid worst-case patterns.

- MergeSort:
  - Use when stable sort is required or when worst-case guarantees are important.
  - Preferable for linked lists or external sorting where merge is efficient.

- HeapSort:
  - Use when O(1) auxiliary space and guaranteed O(n log n) time are required.
  - Less common in practice for in-memory sorts due to larger constant factors and cache behavior.

---

## Summary table (high level)

- QuickSort: Avg O(n log n), Worst O(n^2), Space O(log n), In-place yes, Stable no
- MergeSort: Avg/Worst O(n log n), Space O(n), In-place no (usually), Stable yes
- HeapSort: Avg/Worst O(n log n), Space O(1), In-place yes, Stable no

---

Notes: For production code, prefer well-tested library implementations (e.g., `Array.Sort` / `List<T>.Sort`) unless implementing or demonstrating a specific algorithm for learning or special constraints.
