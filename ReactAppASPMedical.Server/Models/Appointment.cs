using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FullStackApp.Server.Models
{
    [Table("appointments")]
    public class Appointment
    {
        [Key]
        [Column("id")]
        public required int Id { get; set; }

        [Column("patient")]
        public required string Patient { get; set; }

        [Column("doctor")]
        public required string Doctor { get; set; }

        [Column("room")]
        public required string Room { get; set; }

        [Column("time")]
        public required string Time { get; set; }

        [Column("next")]
        public required string Next { get; set; }
    }
}
