using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LolaSoft.WebShop.Web.ViewModel.Category
{
    public class DetailsCategoryViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Display(Name="Parent Category Name")]
        public string ParentCategoryName { get; set; }
    }
}
