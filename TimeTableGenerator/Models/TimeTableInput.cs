namespace TimetableGenerator.Models
{
    /// <summary>
    ///    Time table input
    /// </summary>
    public class TimetableInput
    {
        /// <summary>
        ///    Working days
        /// </summary>
        public int WorkingDays { get; set; }

        /// <summary>
        ///    Subject per day
        /// </summary>
        public int SubjectsPerDay { get; set; }

        /// <summary>
        ///    Total subjects
        /// </summary>
        public int TotalSubjects { get; set; }

        /// <summary>
        ///    Subject
        /// </summary>
        public List<Subject> Subjects { get; set; } = new();
        
        /// <summary>
        ///   Total hours
        /// </summary>
        public int TotalHours => WorkingDays * SubjectsPerDay;
    }
}
