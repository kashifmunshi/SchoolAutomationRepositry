using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppEntity.Models
{
    public class Product : BaseModel
    {
        [Key] 
        public int ProductId { get; set; }

        [Required]
        [ForeignKey("Department")]
        [DisplayName("Department Id")]
        public int DepartmentId { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Product Name")]
        public string Name { get; set; }

        [Required]
        [StringLength(250)]
        [DisplayName("Product Description")]
        public string Description { get; set; }

        [Required]
        [StringLength(1)]
        [DisplayName("Is Active")]
        public string IsActive { get; set; }

        public virtual Department Department { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}