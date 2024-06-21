
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Core.Entities
{
    public class Product : BaseEntity
    {
        [Required]
        public string Name { get; set; } 
        [Required]
        [StringLength(200)]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string PictureUrl { get; set; }
        [Required]
        public ProductType ProductType { get; set; }
        public int ProductTypeId { get; set; }
        [Required]
        
        public ProductBrand ProductBrand { get; set; }
        public int ProductBrandId { get; set; }
    }

} 