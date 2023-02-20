using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TheShopper.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        [DisplayName("Category Name")]
        //[Range(1,100)]
        public string Name { get; set; }

        [Required]
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.Now; //default value
    }
}
