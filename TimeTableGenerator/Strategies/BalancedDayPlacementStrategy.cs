//// File: Strategies/BalancedDayPlacementStrategy.cs
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace TimetableGenerator.Strategies
//{
//    public class BalancedDayPlacementStrategy : ITimetablePlacementStrategy
//    {
//        public string[,] PlaceSubjects(string[] subjectSlots, int rows, int cols)
//        {
//            if (subjectSlots.Length != rows * cols)
//                throw new ArgumentException(
//                    $"Slot count ({subjectSlots.Length}) must equal rows*cols ({rows * cols}).");

//            // Build counts
//            var counts = subjectSlots
//                         .GroupBy(s => s)
//                         .ToDictionary(g => g.Key, g => g.Count());

//            var grid = new string[rows, cols];

//            for (int r = 0; r < rows; r++)
//            {
//                // Track which subjects are in this row
//                var usedInRow = new HashSet<string>();

//                for (int c = 0; c < cols; c++)
//                {
//                    // Pick the subject with max remaining count that isn't in usedInRow
//                    var candidate = counts
//                        .Where(kv => kv.Value > 0 && !usedInRow.Contains(kv.Key))
//                        .OrderByDescending(kv => kv.Value)
//                        .Select(kv => kv.Key)
//                        .FirstOrDefault();

//                    // If all remaining subjects are already in row, just pick the one with most slots left
//                    if (candidate == null)
//                        candidate = counts
//                            .Where(kv => kv.Value > 0)
//                            .OrderByDescending(kv => kv.Value)
//                            .First().Key;

//                    grid[r, c] = candidate;
//                    counts[candidate]--;
//                    usedInRow.Add(candidate);
//                }
//            }

//            return grid;
//        }
//    }
//}
