using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseworkApp.Interfaces;
using CourseworkApp.Models;

namespace CourseworkApp.ViewModels
{
    public class ExercisesPageViewModel : BaseViewModel
    {
        public Models.LogWorkoutPageModel LogWorkoutPageModel { get; set; }
        private readonly IDatabaseService database;
        public ObservableCollection<ExerciseModel> Items { get; private set; }

        public ExercisesPageViewModel(IDatabaseService database)
        {
            this.database = database;
            var res = database.GetExercises();
            Items = new ObservableCollection<ExerciseModel>(res);
        }















    }
}
