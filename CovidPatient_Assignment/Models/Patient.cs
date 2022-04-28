using System.ComponentModel.DataAnnotations;

namespace CovidPatient_Assignment.Models
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Patient Name")]
        public string Name { get; set; }
        public int PassportNumber { get; set; }

        public int Emirates_ID { get; set; }

        public string Emirate { get; set; }

        // [DataType(DataType.MultilineText)]
        public string Address { get; set; }

        public string FirstDose { get; set; }

        public string SecondDose { get; set; }

        public string ThirdDose { get; set; }
        public string ForthDose { get; set; }
        public DateTime? RecordCreatedOn { get; set; }
    }
}
