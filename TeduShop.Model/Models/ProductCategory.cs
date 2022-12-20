using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("ProductCategories")]
    internal class ProductCategory : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Alas { get; set; }
        public string Description { get; set; }
        public int ParentID { get; set; }
        public int DisplayOrder { get; set; }
        public string? Image { get; set; }
        public bool? HomeFlag { get; set; }

        public virtual IEnumerable<ProductCategory> ProductCategories { get;set; }
    }
}
