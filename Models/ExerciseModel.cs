using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace CourseworkApp.Models
{
    [Table("Exercises")]
    class ExerciseModel
    {
        [PrimaryKey, AutoIncrement, Column("ID")]
        public int Id { get; set; }
        
        [MaxLength(250), Column("name")]
        public string Name { get; set; }

        [MaxLength(250), Column("instructions")]
        public string Instructions { get; set; }

        [MaxLength(250), Column("imageURL")]
        public string ImageURL { get; set; }

        [Column("bodypartID")]
        public int BodypartId { get; set; }
    }
}
