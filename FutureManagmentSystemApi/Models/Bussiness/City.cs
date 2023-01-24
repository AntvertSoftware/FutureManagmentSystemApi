using System.ComponentModel.DataAnnotations;

namespace FutureManagmentSystemApi.Models.Bussiness
{
    public class City
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="This field is required")]
        public string CityName { get; set; }

        public int StateId { get; set; }
    }
}
