using day2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace day2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new Models.SortViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(Models.SortViewModel model)
        {
            if (model == null)
            {
                return View(new Models.SortViewModel { ErrorMessage = "Invalid request." });
            }

            if (string.IsNullOrWhiteSpace(model.Input))
            {
                model.ErrorMessage = "Please enter a sequence of numbers (e.g. 1 2 3 12 32 45).";
                return View(model);
            }

            // Parse numbers: allow spaces, commas, or semicolons as separators
            var parts = model.Input.Split(new[] { ' ', ',', ';', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            var nums = new List<int>();
            foreach (var p in parts)
            {
                if (int.TryParse(p, out var v))
                {
                    nums.Add(v);
                }
                else
                {
                    model.ErrorMessage = $"Unable to parse '{p}' as an integer.";
                    return View(model);
                }
            }

            model.Original = nums.ToArray();

            // Perform quick sort on a copy
            var arr = (int[])model.Original.Clone();
            QuickSort(arr, 0, arr.Length - 1);
            model.Sorted = arr;

            return View(model);
        }

        // In-place quick sort implementation
        private static void QuickSort(int[] a, int left, int right)
        {
            if (left >= right) return;
            int pivotIndex = Partition(a, left, right);
            QuickSort(a, left, pivotIndex - 1);
            QuickSort(a, pivotIndex + 1, right);
        }

        private static int Partition(int[] a, int left, int right)
        {
            int pivot = a[right];
            int i = left - 1;
            for (int j = left; j < right; j++)
            {
                if (a[j] <= pivot)
                {
                    i++;
                    Swap(a, i, j);
                }
            }
            Swap(a, i + 1, right);
            return i + 1;
        }

        private static void Swap(int[] a, int i, int j)
        {
            if (i == j) return;
            int t = a[i];
            a[i] = a[j];
            a[j] = t;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
