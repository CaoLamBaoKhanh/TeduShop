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
        public string Name { get; set; }
        public string Deparment { get; set; }
        public string? Skype { get; set; }
        [Required]
        public string Mobile { get; set; }
        public string? Email { get; set; }
        public string? Facebook { get; set; }
        public bool? Status { get; set; }
    }
}
