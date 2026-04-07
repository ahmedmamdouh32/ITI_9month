using System;
using System.Collections.Generic;

namespace day2.Models
{
    public class SortViewModel
    {
        // Raw input from the user (e.g. "1 2 3 12 32 45")
        public string Input { get; set; }

        // Sorted result
        public int[] Sorted { get; set; }

        // Original parsed numbers (if needed)
        public int[] Original { get; set; }

        // Error message to show parsing/validation errors
        public string ErrorMessage { get; set; }
    }
}
