﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(100)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [Range(1,100,ErrorMessage ="Please enter between 1 and 100")]
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; } //test
    }
}
