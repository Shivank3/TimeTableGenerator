namespace TimetableGenerator.Utilities
{
    public class TimeTablePrinter
    {
        public static void Print(string[,] grid)
        {
            int rows = grid.GetLength(0);
            int cols = grid.GetLength(1);

            Console.WriteLine("\n Generated Timetable:\n");

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    Console.Write($"{grid[r, c],-10} ");
                }
                Console.WriteLine();
            }
        }
    }
}
