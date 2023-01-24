using System.ComponentModel.DataAnnotations;

namespace FutureManagmentSystemApi.Models.Bussiness
{
    public class State
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="This field is required")]
        public string StateName { get; set; }
    }
}
