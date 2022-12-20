﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("Tags")]
    internal class Tag
    {
        [Key]
        public string ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Type { get; set; }
    }
}