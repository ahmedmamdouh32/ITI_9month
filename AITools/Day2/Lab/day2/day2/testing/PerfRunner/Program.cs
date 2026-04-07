using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

namespace PerfRunner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = new[] { 1000, 5000, 10000, 20000 };
            int iterations = 5;

            var controllerType = typeof(day2.Controllers.HomeController);
            var quickSortMethod = controllerType.GetMethod("QuickSort", BindingFlags.NonPublic | BindingFlags.Static);
            if (quickSortMethod == null)
            {
                Console.WriteLine("QuickSort method not found");
                return;
            }

            var rand = new Random(42);
            var sb = new System.Text.StringBuilder();
            sb.AppendLine("# Performance testing: QuickSort vs Array.Sort");
            sb.AppendLine($"Date: {DateTime.UtcNow:O} (UTC)");
            sb.AppendLine();
            sb.AppendLine("| Size | QuickSort avg ms | Array.Sort avg ms | QuickSort faster? |");
            sb.AppendLine("|---:|---:|---:|:---:|");

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

                    // sanity
                    Array.Sort(a1);
                    if (!a1.SequenceEqual(a2))
                    {
                        Console.WriteLine("Mismatch in sorting results");
                        return;
                    }
                }

                double avgQuick = totalQuick / (double)iterations;
                double avgArray = totalArray / (double)iterations;
                sb.AppendLine($"| {n} | {avgQuick:F2} | {avgArray:F2} | {(avgQuick < avgArray ? "Yes" : "No")} |");
                Console.WriteLine($"Size {n}: QuickSort avg {avgQuick:F2} ms, Array.Sort avg {avgArray:F2} ms");
            }

            var outPath = Path.Combine(Directory.GetCurrentDirectory(), "..", "..", "wwwroot", "documetns");
            outPath = Path.GetFullPath(outPath);
            Directory.CreateDirectory(outPath);
            var filePath = Path.Combine(outPath, "performanceTesting.md");
            File.WriteAllText(filePath, sb.ToString());
            Console.WriteLine($"Wrote results to {filePath}");
        }
    }
}
