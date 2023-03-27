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

        public const string DatabaseFilename = "appDatabase.db3";

        public const SQLite.SQLiteOpenFlags Flags =
            // open the database in read/write mode
            SQLite.SQLiteOpenFlags.ReadWrite |
            // create the database if it doesn't exist
            SQLite.SQLiteOpenFlags.Create |
            // enable multi-threaded database access
            SQLite.SQLiteOpenFlags.SharedCache;

        public const string WorkoutLogFilename = "workoutLog.txt";

        public static string DatabasePath => 
            Path.Combine(FileSystem.AppDataDirectory, DatabaseFilename);

        public static string WorkoutLogPath =>
            Path.Combine(FileSystem.AppDataDirectory, WorkoutLogFilename);
    }
}
