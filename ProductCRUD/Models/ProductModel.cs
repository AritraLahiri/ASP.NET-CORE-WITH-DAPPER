using Microsoft.Build.Framework;

namespace ProductCRUD.Models
{
    public class ProductModel
    {
        [Required]
        public int Price { get; set; }
        [Required]
        public string Name { get; set; } = String.Empty;
        [Required]
        public string Desc { get; set; } = String.Empty;
    }
}
