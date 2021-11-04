using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using MVCWebApplication.Interfaces;

namespace MVCWebApplication.Entities
{
    public class Category:IPrimaryProperties
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(200, MinimumLength = 2)]
        [Display(Name = "სახელი")]
        public string Title { get; set; }

        [Display(Name = "აღწერა")]
        public string Description { get; set; }
        
        [Required]
        [Display(Name = "სურათის მისამართი")]
        public string ThumbnailImagePath { get; set; }

        [ForeignKey("CategoryId")]
        public virtual ICollection<CategoryItem> CategoryItems { get; set; }

        [ForeignKey("CategoryId")]
        public virtual ICollection<UserCategory> UserCategory { get; set; }
    }
}
