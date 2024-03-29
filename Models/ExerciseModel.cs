﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace CourseworkApp.Models
{
    [Table("Exercises")]
    public class ExerciseModel
    {
        [PrimaryKey, AutoIncrement, Column("id")]
        public int Id { get; set; }
        
        [MaxLength(250), Column("name")]
        public string Name { get; set; }

        [MaxLength(250), Column("instructions")]
        public string Instructions { get; set; }

        [MaxLength(250), Column("imageURL")]
        public string ImageURL { get; set; }

        [MaxLength(250), Column("bodypart")]
        public string Bodypart { get; set; }
    }
}
