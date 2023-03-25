using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace CourseworkApp.Models
{
    [Table("Bodyparts")]
    class BodypartModel
    {
        [PrimaryKey, AutoIncrement, Column("ID")]
        public int Id { get; set; }

        [MaxLength(250), Column("name")]
        public string Name { get; set; }
    }
}
