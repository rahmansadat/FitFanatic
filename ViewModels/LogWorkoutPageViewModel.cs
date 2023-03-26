using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CourseworkApp.Interfaces;
using CourseworkApp.Models;
using CourseworkApp.Views;

namespace CourseworkApp.ViewModels
{
    public class LogWorkoutPageViewModel : BaseViewModel
    {
        public Models.LogWorkoutPageModel LogWorkoutPageModel { get; set; }
        public ICommand ClickAndSee { get; set; }
        public ICommand SubmitWorkoutCommand { get; set; }

        private readonly IDatabaseService database;

        List<ExerciseModel> databaseResult;

        // the following is a quick workaround that allows Binding to recognise the list
        private List<ExerciseModel> items;
        public List<ExerciseModel> Items { get => items; set => items = value; }

        public LogWorkoutPageViewModel(IDatabaseService database)
        {
            Console.WriteLine("PROMPT NUMBER: 2");
            LogWorkoutPageModel = new Models.LogWorkoutPageModel();
            this.database = database;
            SubmitWorkoutCommand = new Command(async () => await SubmitWorkout());

            items = new List<ExerciseModel>();

            databaseResult = database.GetExercises();

            foreach (var exercise in databaseResult)
            {
                items.Add(exercise);
            }
        }

        public int Reps1
        {
            get => LogWorkoutPageModel.reps1;
            set
            {
                LogWorkoutPageModel.reps1 = value;
            }
        }
        public int Reps2
        {
            get => LogWorkoutPageModel.reps2;
            set
            {
                LogWorkoutPageModel.reps2 = value;
            }
        }
        public int Reps3
        {
            get => LogWorkoutPageModel.reps3;
            set
            {
                LogWorkoutPageModel.reps3 = value;
            }
        }
        public int Reps4
        {
            get => LogWorkoutPageModel.reps4;
            set
            {
                LogWorkoutPageModel.reps4 = value;
            }
        }
        public int Reps5
        {
            get => LogWorkoutPageModel.reps5;
            set
            {
                LogWorkoutPageModel.reps5 = value;
            }
        }
        public int Reps6
        {
            get => LogWorkoutPageModel.reps6;
            set
            {
                LogWorkoutPageModel.reps6 = value;
            }
        }

        public int Sets1
        {
            get => LogWorkoutPageModel.sets1;
            set
            {
                LogWorkoutPageModel.sets1 = value;
            }
        }
        public int Sets2
        {
            get => LogWorkoutPageModel.sets2;
            set
            {
                LogWorkoutPageModel.sets2 = value;
            }
        }
        public int Sets3
        {
            get => LogWorkoutPageModel.sets3;
            set
            {
                LogWorkoutPageModel.sets3 = value;
            }
        }
        public int Sets4
        {
            get => LogWorkoutPageModel.sets4;
            set
            {
                LogWorkoutPageModel.sets4 = value;
            }
        }
        public int Sets5
        {
            get => LogWorkoutPageModel.sets5;
            set
            {
                LogWorkoutPageModel.sets5 = value;
            }
        }
        public int Sets6
        {
            get => LogWorkoutPageModel.sets6;
            set
            {
                LogWorkoutPageModel.sets6 = value;
            }
        }

        public ExerciseModel Exercise1
        {
            get => LogWorkoutPageModel.exercise1;
            set
            {
                LogWorkoutPageModel.exercise1 = value;
            }
        }
        public ExerciseModel Exercise2
        {
            get => LogWorkoutPageModel.exercise2;
            set
            {
                LogWorkoutPageModel.exercise2 = value;
            }
        }
        public ExerciseModel Exercise3
        {
            get => LogWorkoutPageModel.exercise3;
            set
            {
                LogWorkoutPageModel.exercise3 = value;
            }
        }
        public ExerciseModel Exercise4
        {
            get => LogWorkoutPageModel.exercise4;
            set
            {
                LogWorkoutPageModel.exercise4 = value;
            }
        }
        public ExerciseModel Exercise5
        {
            get => LogWorkoutPageModel.exercise5;
            set
            {
                LogWorkoutPageModel.exercise5 = value;
            }
        }
        public ExerciseModel Exercise6
        {
            get => LogWorkoutPageModel.exercise6;
            set
            {
                LogWorkoutPageModel.exercise6 = value;
            }
        }

        private async Task SubmitWorkout()
        {
            string dataToLog = $"Date: {DateTime.Now.Date.ToString(new CultureInfo("en-GB")).Remove(DateTime.Now.Date.ToString(new CultureInfo("en-GB")).Length - 9)}\nTime: {DateTime.Now.ToString("h:mm:ss tt")}\nExercises:";

            if (Reps1 != 0 && Sets1 != 0 && Exercise1 != null)
            {
                dataToLog += $"\n{Exercise1.Name} - Sets: {Sets1}, Reps: {Reps1}";
            }
            if (Reps2 != 0 && Sets2 != 0 && Exercise2 != null)
            {
                dataToLog += $"\n{Exercise2.Name} - Sets: {Sets2}, Reps: {Reps2}";
            }
            if (Reps3 != 0 && Sets3 != 0 && Exercise3 != null)
            {
                dataToLog += $"\n{Exercise3.Name} - Sets: {Sets3}, Reps: {Reps3}";
            }
            if (Reps4 != 0 && Sets4 != 0 && Exercise4 != null)
            {
                dataToLog += $"\n{Exercise4.Name} - Sets: {Sets4}, Reps: {Reps4}";
            }
            if (Reps5 != 0 && Sets5 != 0 && Exercise5 != null)
            {
                dataToLog += $"\n{Exercise5.Name} - Sets: {Sets5}, Reps: {Reps5}";
            }
            if (Reps6 != 0 && Sets6 != 0 && Exercise6 != null)
            {
                dataToLog += $"\n{Exercise6.Name} - Sets: {Sets6}, Reps: {Reps6}";
            }

            dataToLog += "\n\n";

            // Writing the data to the file
            File.AppendAllText(Constants.WorkoutLogPath, dataToLog); // also creates the file if not exists

            // Reading the file contents for debugging purposes
            //var fileData = File.ReadAllText(Constants.WorkoutLogPath);
            //Console.WriteLine("This is what's in the file: ");
            //Console.WriteLine(fileData);

            await Application.Current.MainPage.DisplayAlert("Success", "Workout has been logged", "OK");
        }
    }
}
