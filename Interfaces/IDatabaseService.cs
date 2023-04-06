using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseworkApp.Models;

namespace CourseworkApp.Interfaces
{
    public interface IDatabaseService
    {
        // Get all exercises
        List<ExerciseModel> GetExercises();
    }
}
