using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace CourseworkApp.Models
{
    [Table("Bodyparts")]
    public class BodypartModel
    {
        [PrimaryKey, AutoIncrement, Column("id")]
        public int Id { get; set; }

        [MaxLength(250), Column("name")]
        public string Name { get; set; }
    }
}
