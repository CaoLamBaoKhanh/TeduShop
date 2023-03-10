using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("SupportOnlines")]
    internal class SupportOnline
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Deparment { get; set; }
        [MaxLength(50)]
        public string? Skype { get; set; }
        [Required]
        [MaxLength(50)]
        public string Mobile { get; set; }
        [MaxLength(50)]
        public string? Email { get; set; }
        [MaxLength(50)]
        public string? Facebook { get; set; }
        [MaxLength(50)]
        public bool? Status { get; set; }

        public int? DisplayOrder { get; set; }
    }
}
