using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkApp.Models
{
    public class LogWorkoutPageModel
    {
        public ExerciseModel exercise1 { get; set; } = null;
        public ExerciseModel exercise2 { get; set; } = null;
        public ExerciseModel exercise3 { get; set; } = null;
        public ExerciseModel exercise4 { get; set; } = null;
        public ExerciseModel exercise5 { get; set; } = null;
        public ExerciseModel exercise6 { get; set; } = null;

        public int sets1 { get; set; } = 0;
        public int sets2 { get; set; } = 0;
        public int sets3 { get; set; } = 0;
        public int sets4 { get; set; } = 0;
        public int sets5 { get; set; } = 0;
        public int sets6 { get; set; } = 0;

        public int reps1 { get; set; } = 0;
        public int reps2 { get; set; } = 0;
        public int reps3 { get; set; } = 0;
        public int reps4 { get; set; } = 0;
        public int reps5 { get; set; } = 0;
        public int reps6 { get; set; } = 0;

        public LogWorkoutPageModel()
        {

        }
    }
}
