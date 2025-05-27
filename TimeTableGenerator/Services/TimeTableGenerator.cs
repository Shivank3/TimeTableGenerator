using TimetableGenerator.Strategies;
using TimetableGenerator.Models;


namespace TimetableGenerator.Services
{
    /// <summary>
    ///    Time table generator
    /// </summary>
    public class TimeTableGenerator
    {
        private readonly ITimetablePlacementStrategy _Strategy;

        public TimeTableGenerator(ITimetablePlacementStrategy strategy)
        {
            _Strategy = strategy;
        }

        public string[,] Generate(TimetableInput input)
        {
            var slots = new List<string>();
            foreach (var subj in input.Subjects)
            {
                for(int i=0; i<subj.Hours; i++)
                {
                    slots.Add(subj.Name);
                }
            }

            // Delegates placement
            return _Strategy.PlaceSubjects(slots.ToArray(),
                                        input.SubjectsPerDay,
                                        input.WorkingDays);
        }
    }
}
