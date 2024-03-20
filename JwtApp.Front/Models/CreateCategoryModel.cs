using System.ComponentModel.DataAnnotations;

namespace JwtApp.Front.Models
{
    public class CreateCategoryModel
    {
        [Required]
        public string Definition { get; set; }
    }
}
