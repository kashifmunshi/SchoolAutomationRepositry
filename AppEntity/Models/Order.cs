using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppEntity.Models
{
    public class Order : BaseModel
    {
        public int OrderId { get; set; }

        [Required]
        [NotMapped]
        [DisplayName("Department")]
        [Range(1, int.MaxValue, ErrorMessage = "The Department field is required.")]
        public int DepartmentId { get; set; }
        
        [Required]
        [ForeignKey("Product")]
        [DisplayName("Product")]
        [Range(1, int.MaxValue, ErrorMessage = "The Product field is required.")]
        public int ProductId { get; set; }

        public virtual Product Product{ get; set; }
    }
}
