using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using Xunit;

namespace day2.Tests
{
    public class QuickSortPerformanceTests
    {
        [Fact]
        public void CompareQuickSortWithArraySort_WriteResultsToMd()
        {
            // sizes to test
            int[] sizes = new[] { 1000, 5000, 10000 };
            int iterations = 5;

            var controllerType = typeof(day2.Controllers.HomeController);
            var quickSortMethod = controllerType.GetMethod("QuickSort", BindingFlags.NonPublic | BindingFlags.Static);
            Assert.NotNull(quickSortMethod);

            var rand = new Random(42);

            var results = new System.Text.StringBuilder();
            results.AppendLine("# Performance testing: QuickSort vs Array.Sort\n");
            results.AppendLine($"Date: {DateTime.UtcNow:O} (UTC)\n");
            results.AppendLine("| Size | QuickSort avg ms | Array.Sort avg ms | QuickSort faster? |");
            results.AppendLine("|---:|---:|---:|:---:|");

            foreach (var n in sizes)
            {
                long totalQuick = 0;
                long totalArray = 0;

                for (int it = 0; it < iterations; it++)
                {
                    var data = new int[n];
                    for (int i = 0; i < n; i++) data[i] = rand.Next();

                    var a1 = (int[])data.Clone();
                    var a2 = (int[])data.Clone();

                    var sw = Stopwatch.StartNew();
                    quickSortMethod.Invoke(null, new object[] { a1, 0, a1.Length - 1 });
                    sw.Stop();
                    totalQuick += sw.ElapsedMilliseconds;

                    sw.Restart();
                    Array.Sort(a2);
                    sw.Stop();
                    totalArray += sw.ElapsedMilliseconds;

                    // sanity check
                    Array.Sort(a1);
                    Assert.Equal(a1, a2);
                }

                double avgQuick = totalQuick / (double)iterations;
                double avgArray = totalArray / (double)iterations;

                results.AppendLine($"| {n} | {avgQuick:F2} | {avgArray:F2} | {(avgQuick < avgArray ? "Yes" : "No")} |");
            }

            // determine output path relative to repo root
            string outPath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "wwwroot", "documetns"));
            Directory.CreateDirectory(outPath);
            string filePath = Path.Combine(outPath, "performanceTesting.md");
            File.WriteAllText(filePath, results.ToString());

            // also assert that file exists
            Assert.True(File.Exists(filePath));
        }
    }
}
