using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FullStackApp.Server.Models
{
    [Table("patients")]
    public class Patient
    {
        [Column("name")]
        public required string Name { get; set; }

        [Key]
        [Column("email")]
        public required string Email { get; set; }

        [Column("phonenumber")]
        public required string PhoneNumber { get; set; }

        [Column("age")]
        public required int Age { get; set; }

        [Column("gender")]
        public required string Gender { get; set; }

        [Column("address")]
        public required string Address { get; set; }

        [Column("city")]
        public required string City { get; set; }

        [Column("region")]
        public required string Region { get; set; }

        [Column("postalcode")]
        public required string PostalCode { get; set; }

        [Column("country")]
        public required string Country { get; set; }

        [Column("bloodtype")]
        public required string BloodType { get; set; }

        [Column("allergies")]
        public required string Allergies { get; set; }

        [Column("medications")]
        public required string Medications { get; set; }

        [Column("history")]
        public required string History { get; set; }

    }
}
