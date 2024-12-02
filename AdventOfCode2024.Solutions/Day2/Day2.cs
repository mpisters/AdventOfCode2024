namespace AdventOfCode2024.Solutions.Day2;

public class Day2
{
    public int GetTotalSaveReports(string fileName)
    {
        var lines = FileParser.GetLines("Day2", fileName);
        var totalSafeReports = 0;
        foreach (var line in lines)
        {
            var report = line.Split(" ").Select(int.Parse).ToList();
            var newSortedReportIncreased = report.OrderBy(x => x).ToList();
            var newSortedReportDecreased = report.OrderByDescending(x => x).ToList();
            var isIncreased = report.ElementAt(0) < report.ElementAt(1);
            if (isIncreased)
            {
                if (!report.SequenceEqual( newSortedReportIncreased))
                {
                    continue;
                }
            }

            if (!isIncreased)
            {
                if (!report.SequenceEqual( newSortedReportDecreased))
                {
                    continue;
                }
            }

            var previous = report.ElementAt(0);
            var isValid = false;
            for (int i = 1; i < report.Count(); i++)
            {
                var currentItem = report.ElementAt(i);
                if (Math.Abs(currentItem - previous) >= 1 &&
                    Math.Abs(currentItem - previous) <= 3)
                {
                    isValid = true;
                }
                else
                {
                    isValid = false;
                    break;
                }
                previous = currentItem;
            }

            if (isValid)
            {
                totalSafeReports++;
            }
        }

        return totalSafeReports;
    }
}