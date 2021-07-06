using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppEntity.Models
{
    public class Department : BaseModel
    {
        [Key] 
        public int DepartmentId { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Department Name")]
        public string Name { get; set; }

        [Required]
        [StringLength(250)]
        [DisplayName("Department Description")]
        public string Description { get; set; }

        [Required]
        [StringLength(1)]
        [DisplayName("Is Active")]
        public string IsActive { get; set; }

        public virtual ICollection<Product> Products{ get; set; }
    }
}