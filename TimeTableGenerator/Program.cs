using TimetableGenerator.Factories;
using TimetableGenerator.Models;
using TimetableGenerator.Services;
using TimetableGenerator.Utilities;

namespace TimetableGenerator;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Dynamic Timetable Generator ===");

        var input = new TimetableInput();

        input.WorkingDays = PromptInt("Enter number of working days (1–7): ", 1, 7);
        input.SubjectsPerDay = PromptInt("Enter subjects per day (<9): ", 1, 8);
        input.TotalSubjects = PromptInt("Enter total number of subjects: ", 1, 100);

        Console.WriteLine($"\n➡️ Total weekly slots = {input.TotalHours}");

        for (int i = 0; i < input.TotalSubjects; i++)
        {
            Console.Write($"\nEnter subject {i + 1} name: ");
            string name = Console.ReadLine() ?? $"Subject{i + 1}";

            int hours = PromptInt($"Enter hours for {name}: ", 1, input.TotalHours);

            input.Subjects.Add(new Subject { Name = name, Hours = hours });
        }

        int totalEnteredHours = input.Subjects.Sum(s => s.Hours);
        if (totalEnteredHours != input.TotalHours)
        {
            Console.WriteLine($"\n Total hours entered ({totalEnteredHours}) do not match expected weekly hours ({input.TotalHours}). Exiting.");
            return;
        }

        Console.Write("\nChoose placement mode (random): ");
        string mode = Console.ReadLine() ?? "random";

        var strategy = StrategyFactory.Create(mode);
        var generator = new TimeTableGenerator(strategy);

        var grid = generator.Generate(input);

        TimeTablePrinter.Print(grid);
    }

    static int PromptInt(string message, int min, int max)
    {
        int value;
        do
        {
            Console.Write(message);
        } while (!int.TryParse(Console.ReadLine(), out value) || value < min || value > max);

        return value;
    }
}
