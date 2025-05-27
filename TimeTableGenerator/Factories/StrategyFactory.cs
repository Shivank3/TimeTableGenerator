using TimetableGenerator.Strategies;

namespace TimetableGenerator.Factories
{
    public class StrategyFactory
    {
        public static ITimetablePlacementStrategy Create(string mode)
        {
            return mode.ToLower() switch
            {
                "random" => new RandomPlacementStrategy(),
                //"balanced" => new BalancedDayPlacementStrategy(),
                _ => throw new ArgumentException($"Invalid mode: {mode}")
            };
        }
    }

}

