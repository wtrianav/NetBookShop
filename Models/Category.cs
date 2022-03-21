using System.ComponentModel.DataAnnotations;

namespace NetBookShop.Models 
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [RegularExpression("[A-Za-z ñÑ ÁáÉéÍíÓóÚú]*", ErrorMessage = "Please, only letters are allowed")]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now; 
    }
}