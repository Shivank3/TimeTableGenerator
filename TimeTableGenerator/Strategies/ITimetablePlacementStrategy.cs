namespace TimetableGenerator.Strategies
{
    public interface ITimetablePlacementStrategy
    {
        /// <summary>
        ///     Takes a flat array of subject names (length = rows * cols)
        ///     and returns a filled 2D grid [rows, cols].
        /// </summary>
        /// <param name="subjectSlots"></param>
        /// <param name="rows"></param>
        /// <param name="cols"></param>
        /// <returns></returns>
        string[,] PlaceSubjects(string[] subjectSlots, int rows, int cols);
    }
}
