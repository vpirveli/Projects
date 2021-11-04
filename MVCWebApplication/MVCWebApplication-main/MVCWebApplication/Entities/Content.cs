﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebApplication.Entities
{
    public class Content
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 2)]
        [Display(Name = "სახელი")]
        public string Title { get; set; }

        [Display(Name ="აღწერა (HTML)")]
        public string HTMLContent { get; set; }

        [Display(Name ="ვიდეო ლინკი")]
        public string VideoLink { get; set; }

        public CategoryItem CategoryItem { get; set; }

        [NotMapped]
        public int CatItemId { get; set; }

        [NotMapped]
        public int CategoryId { get; set; }
        
    }
}
