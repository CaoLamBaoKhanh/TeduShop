using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("Orders")]
    internal class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        public string CustomerName { get; set; }
        [Required]
        [StringLength(50)]
        public string CustomerAddress { get; set; }
        [Required]
        [StringLength(50)]
        public string CustomerEmail { get; set; }
        [Required]
        [StringLength(50)]
        public string CustomerMobile { get; set; }
        [Required]
        [StringLength(50)]
        public string CustomerMessage { get; set; }
        [Required]
        [StringLength(50)]
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? PaymentMethod { get; set; }
        public string? PaymentStatus { get; set; }
        public bool? Status { get; set; }

        public virtual IEnumerable<OrderDetail> Details { get;set; }
    }
}
