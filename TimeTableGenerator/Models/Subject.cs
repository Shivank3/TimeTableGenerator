namespace TimetableGenerator.Models
{
    /// <summary>
    ///     Subject
    /// </summary>
    public class Subject
    {
        /// <summary>
        ///     Name
        /// </summary>
        public string Name { get; set; } = string.Empty; // Name must always be a  string, even if empty

        /// <summary>
        ///     Hours
        /// </summary>
        public int Hours { get; set; }
    }
}
