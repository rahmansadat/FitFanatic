using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkApp
{
    class Constants
    {
        public static string apiEndpoint = "https://api.fisenko.net/v1/quotes/en/random";

        public const string WorkoutLogFilename = "workoutLog.txt";

        public static string WorkoutLogPath =>
            Path.Combine(FileSystem.AppDataDirectory, WorkoutLogFilename);
    }
}
