using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LolaSoft.WebShop.Web.ViewModel.Category
{
    public class CategoryViewModel
    {
        [Display(Name = "Category ID")]
        public int Id { get; set; }

        public int? ParentCategoryId { get; set; }

        [Display(Name = " Parent Name")]
        public string ParentCategoryName { get; set; }

        public string Name { get; set; }
    }
}
