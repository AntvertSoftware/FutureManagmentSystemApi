using System.ComponentModel.DataAnnotations;

namespace FutureManagmentSystemApi.Models.Dtos
{
    public class StateDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="This field is required")]
        public string StateName { get; set; }
    }
}
