using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LolaSoft.WebShop.Web.ViewModel.Category
{
    public class CreateCategoryViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int ParentCategoryId { get; set; }

        [Display(Name = "Parent Category")]
        public List<SelectListItem> ParentCategory { get; set; }
    }
}
