namespace AdventOfCode2024.Solutions.Day2;

public class Day2
{
        public int GetTotalSaveReports(string fileName)
        {
                var lines = FileParser.GetLines("Day2", fileName);
                var totalSafeReports = 0;
                foreach (var line in lines)
                {
                        var report = line.Split(" ").Select(int.Parse);
                        var previous = report.ElementAt(0);
                        bool? isSafeIncrease = null;
                        var startPoint = report.ElementAt(0);
                        var isIncrease = startPoint < report.ElementAt(1);
                        for (var i = 1; i < report.Count() - 1; i++)
                        {
                                var currentItem = report.ElementAt(i);
                                if (!(Math.Abs(previous - currentItem) >= 1 && Math.Abs(previous - currentItem) <= 3))
                                {
                                        isSafeIncrease = false;
                                        break;
                                }

                                if (isIncrease && previous >= currentItem|| !isIncrease && previous <= currentItem)
                                {
                                        isSafeIncrease = false;
                                        break;
                                }
                                previous = currentItem;
                                isSafeIncrease = true;
                        }

                        if (isSafeIncrease is true)
                        {
                                totalSafeReports++;
                        }
                        
                        
                }

                return totalSafeReports;
        }
}