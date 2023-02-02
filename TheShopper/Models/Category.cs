﻿using System.ComponentModel.DataAnnotations;

namespace TheShopper.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now; //default value
    }
}
