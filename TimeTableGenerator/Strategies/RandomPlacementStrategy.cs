namespace TimetableGenerator.Strategies
{
    public class RandomPlacementStrategy : ITimetablePlacementStrategy
    {
        public string[,] PlaceSubjects(string[] subjectSlots, int rows, int cols)
        {
            if (subjectSlots.Length != rows * cols)
            {
                throw new ArgumentException("Slot count must be equal rows * cols");
            }

            var random = new Random();
            // using fisher yates suffle 
            for (int i = subjectSlots.Length - 1; i >= 0; i--)
            {
                int j = random.Next(i + 1);
                (subjectSlots[i], subjectSlots[j]) = (subjectSlots[j],  subjectSlots[i]);
            }
            var grid = new string[rows, cols];
            int idx = 0;
            for (int r = 0; r < rows; r++) {
                for (int c = 0; c < cols; c++)
                    grid[r, c] = subjectSlots[idx++];
            }
            return grid;
        }
    }
}
