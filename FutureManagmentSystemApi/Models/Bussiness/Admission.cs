using System.ComponentModel.DataAnnotations;

namespace FutureManagmentSystemApi.Models.Bussiness
{
    public class Admission
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string Gender { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public long Mobile { get; set; }
        [Required]
        public string Dob { get; set; }
        public string Class { get; set; }
        public string Address { get; set; }
        public int City { get; set; }
        public int State { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; }

        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        public string ModifiedBy { get; set;}
    }
}
