﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("Products")]
    internal class Product : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Alias { get; set; }
        public int CategoryID { get; set; }
        [ForeignKey(nameof(CategoryID))]
        public virtual ProductCategory ProductCategory { get; set; }
        public string Image { get; set; }
        public XElement MoreImage { get; set; }

        [Required]
        public decimal Price { get; set; }
        public decimal? Promotion { get; set;}
        public int? Warranty { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public bool? HomeFlag { get; set; }
        public bool? HotFlag { get; set;}
        public int? ViewCount { get; set; }
        

    }
}