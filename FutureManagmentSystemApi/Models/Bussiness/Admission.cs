namespace FutureManagmentSystemApi.Models.Bussiness
{
    public class Admission
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string MyProperty { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public long Mobile { get; set; }
        public string Dob { get; set; }
        public string Class { get; set; }
        public string Address { get; set; }
        public int City { get; set; }
        public int State { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
