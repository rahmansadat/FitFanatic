using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseworkApp.Interfaces;
using CourseworkApp.Models;
using SQLite;

namespace CourseworkApp.Services
{
    class HardcodedDatabaseService : IDatabaseService
    {
        public List<ExerciseModel> exercises;
        public List<BodypartModel> bodyparts;

        public HardcodedDatabaseService()
        {
            this.exercises = new List<ExerciseModel>();
            this.bodyparts = new List<BodypartModel>();

            exercises.Add(new ExerciseModel()
            {
                Id = 1,
                Name = "Hammer curls",
                Instructions = "Hold a dumbbell in each hand with your palms facing your thighs, then lift the weights towards your shoulders while keeping your elbows in the same place.",
                ImageURL = "./resources/images/exercise/exercise_hammer_curls",
                BodypartId = 1
            });

            exercises.Add(new ExerciseModel()
            {
                Id = 2,
                Name = "Concentration curls",
                Instructions = "Sit down with one dumbbell and touch your elbow against the inside of your thigh, then curl the weight up toward your shoulder while keeping your elbow in the same place.",
                ImageURL = "./resources/images/exercise/exercise_concentration_curls",
                BodypartId = 1
            });

            exercises.Add(new ExerciseModel()
            {
                Id = 3,
                Name = "Incline curls",
                Instructions = "Lie on an incline bench with a dumbbell in each hand, then curl the weights up toward your shoulders while keeping your elbows in the same place and your palms facing upwards.",
                ImageURL = "./resources/images/exercise/exercise_incline_curls",
                BodypartId = 1
            });

            exercises.Add(new ExerciseModel()
            {
                Id = 4,
                Name = "Rope pushdown",
                Instructions = "Attach a rope to a cable machine, then grab the rope with both hands and extend your arms downward, keeping your elbows in the same place.",
                ImageURL = "./resources/images/exercise/exercise_rope_pushdown",
                BodypartId = 2
            });

            exercises.Add(new ExerciseModel()
            {
                Id = 5,
                Name = "Skullcrashers",
                Instructions = "Lie on a bench with a straight barbell, lower the barbell towards your forehead while keeping your elbows in the same place, then extend your arms upwards to lift the weight back up.",
                ImageURL = "./resources/images/exercise/exercise_skullcrashers",
                BodypartId = 2
            });

            exercises.Add(new ExerciseModel()
            {
                Id = 6,
                Name = "Tricep kickbacks",
                Instructions = "Hold a dumbbell in one hand, hinge your body forward, then extend your arm backwards while keeping your elbow in the same place, and repeat.",
                ImageURL = "./resources/images/exercise/exercise_tricep_kickbacks",
                BodypartId = 2
            });

            exercises.Add(new ExerciseModel()
            {
                Id = 7,
                Name = "Cable flies",
                Instructions = "Grab both the handles of a cable machine and and bring your hands together in front of your chest while keeping your arms straight.",
                ImageURL = "./resources/images/exercise/exercise_cable_flies",
                BodypartId = 3
            });

            exercises.Add(new ExerciseModel()
            {
                Id = 8,
                Name = "Bench press",
                Instructions = "Lie on a bench with your feet on the ground, grab a barbell with your hands, then lower the bar to your chest and push it upwards until your hands have fully extended.",
                ImageURL = "./resources/images/exercise/exercise_bench_press",
                BodypartId = 3
            });

            exercises.Add(new ExerciseModel()
            {
                Id = 9,
                Name = "Push-ups",
                Instructions = "Go into the starting push-up position, then lower your body by bending your arms until your chest touches the ground, and push your body back up to the starting position.",
                ImageURL = "./resources/images/exercise/exercise_push-ups",
                BodypartId = 3
            });

            exercises.Add(new ExerciseModel()
            {
                Id = 10,
                Name = "Lat pulldown",
                Instructions = "Sit on the machine, grab the bar with your hands slightly wider than shoulder-width apart, then pull the bar down toward your chest while keeping your back straight.",
                ImageURL = "./resources/images/exercise/exercise_lat_pulldown",
                BodypartId = 4
            });

            exercises.Add(new ExerciseModel()
            {
                Id = 11,
                Name = "Cable rows",
                Instructions = "Sit on the machine, grab the handles with your palms facing each other, then pull the handles toward your abs while keeping your back straight.",
                ImageURL = "./resources/images/exercise/exercise_cable_rows",
                BodypartId = 4
            });

            exercises.Add(new ExerciseModel()
            {
                Id = 12,
                Name = "Pull-ups",
                Instructions = "Hang from a bar with your palms facing away from you, then pull your body upwards until your chin is above the bar, and finally lower yourself back down.",
                ImageURL = "./resources/images/exercise/exercise_pull-ups",
                BodypartId = 4
            });

            exercises.Add(new ExerciseModel()
            {
                Id = 13,
                Name = "Overhead press",
                Instructions = "Grab a barbell with your hands slightly wider than shoulder-width apart, then lift it above your head until your arms are straight, and then lower it back down.",
                ImageURL = "./resources/images/exercise/exercise_overhead_press",
                BodypartId = 5
            });

            exercises.Add(new ExerciseModel()
            {
                Id = 14,
                Name = "Lateral raises",
                Instructions = "Hold a dumbbell in each hand, then raise your arms out to the sides until they're parallel to the ground, and lower them back down to the starting position.",
                ImageURL = "./resources/images/exercise/exercise_lateral_raises",
                BodypartId = 5
            });

            exercises.Add(new ExerciseModel()
            {
                Id = 15,
                Name = "Face pulls",
                Instructions = "Attach a rope to a cable machine, grab the rope with both hands, then pull it towards your face while keeping your elbows high.",
                ImageURL = "./resources/images/exercise/exercise_face_pulls",
                BodypartId = 5
            });

            exercises.Add(new ExerciseModel()
            {
                Id = 16,
                Name = "Barbell squats",
                Instructions = "Place a barbell on your back, lower your body by bending at the hips until the legs are parallel to the ground, then push back up to your initial position.",
                ImageURL = "./resources/images/exercise/exercise_barbell_squats",
                BodypartId = 6
            });

            exercises.Add(new ExerciseModel()
            {
                Id = 17,
                Name = "Romanian deadlifts",
                Instructions = "Hold a barbell in your hands in front of you, hinge forward and lower the weight towards the ground while keeping your back straight, then go back up once you feel your hamstrings stretching.",
                ImageURL = "./resources/images/exercise/exercise_romanian_deadlifts",
                BodypartId = 6
            });

            exercises.Add(new ExerciseModel()
            {
                Id = 18,
                Name = "Leg press",
                Instructions = "Sit on a leg press machine, push the platform away from you with your feet until your legs are almost fully extended, then return to the starting position.",
                ImageURL = "./resources/images/exercise/leg_press",
                BodypartId = 6
            });

            exercises.Add(new ExerciseModel()
            {
                Id = 19,
                Name = "Hanging leg raises",
                Instructions = "Hang from a bar with your arms straight, then lift your legs upward until they're parallel to the ground and lower them back down.",
                ImageURL = "./resources/images/exercise/exercise_hanging_leg_raises",
                BodypartId = 7
            });

            exercises.Add(new ExerciseModel()
            {
                Id = 20,
                Name = "Cable crunches",
                Instructions = "Attach a rope to a cable machine, kneel down facing away from the machine, then bring your elbows to your knees and then slowly return to the starting position.",
                ImageURL = "./resources/images/exercise/exercise_cable_crunches",
                BodypartId = 7
            });

            exercises.Add(new ExerciseModel()
            {
                Id = 21,
                Name = "Ab wheel rollouts",
                Instructions = "Kneel on the ground with an ab wheel, roll the wheel forward while keeping your back straight until your arms are fully extended, and then roll backwards to your initial position.",
                ImageURL = "./resources/images/exercise/exercise_ab_wheel_rollouts",
                BodypartId = 7
            });

            bodyparts.Add(new BodypartModel()
            {
                Id = 1,
                Name = "Biceps"
            });


            bodyparts.Add(new BodypartModel()
            {
                Id = 2,
                Name = "Triceps"
            });

            bodyparts.Add(new BodypartModel()
            {
                Id = 3,
                Name = "Chest"
            });

            bodyparts.Add(new BodypartModel()
            {
                Id = 4,
                Name = "Back"
            });

            bodyparts.Add(new BodypartModel()
            {
                Id = 5,
                Name = "Shoulders"
            });

            bodyparts.Add(new BodypartModel()
            {
                Id = 6,
                Name = "Legs"
            });

            bodyparts.Add(new BodypartModel()
            {
                Id = 7,
                Name = "Abs"
            });
        }

        // Get all exercises
        public List<ExerciseModel> GetExercises()
        {
            try
            {
                return exercises;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error returning exercises");
                return new List<ExerciseModel>();
            }
        }

        // Get all exercises by bodypart
        public List<ExerciseModel> GetExercisesByBodypart(int bodypartID)
        {

            var filtered_exercises = new List<ExerciseModel>();

            try
            {
                foreach (var exercise in exercises)
                {
                    if (exercise.BodypartId == bodypartID)
                    {
                        filtered_exercises.Add(exercise);
                    }
                }
                return filtered_exercises;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error returning exercises fileted by bodypart");
                return new List<ExerciseModel>();
            }
        }

        // Get all bodyparts
        public List<BodypartModel> GetBodyparts()
        {
            try
            {
                return bodyparts;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error returning bodyparts");
                return new List<BodypartModel>();
            }
        }
    }
}
