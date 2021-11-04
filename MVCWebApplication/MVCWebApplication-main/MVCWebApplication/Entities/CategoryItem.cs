
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebApplication.Entities
{
    public class CategoryItem
    {
        private DateTime _releaseDate = DateTime.MinValue;

        public int Id { get; set; }

        [Required]
        [StringLength(200,MinimumLength =2)]
        [Display(Name = "სახელი")]
        public string Title { get; set; }
        [Display(Name = "აღწერა")]
        public string Description { get; set; }

        public int CategoryId { get; set; }

        [Required(ErrorMessage ="Please select a valid item from the '{0}' dropdown list")]
        [Display(Name = "ღონისძიების სახეობა")]
        public int MediaTypeId { get; set; }

        [NotMapped]
        public virtual ICollection<SelectListItem> MediaTypes { get; set; }
        [Display(Name = "ღონისძიების თარიღი")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime DateTimeItemReleased 
        {
            get 
            {
                return (_releaseDate == DateTime.MinValue) ? DateTime.Now : _releaseDate;
            }
            set {
                _releaseDate = value;
            }
        
        }

        [NotMapped]
        public int ContentId { get; set; }

    }
}
