using System;
using System.Collections.Generic;
using System.Text;

namespace LolaSoft.WebShop.Services.Dto
{
    public class CategoryDto
    {
        public int Id { get; set; }

        public int? ParentCategoryId { get; set; }

        public CategoryDto ParentCategory { get; set; }

        public string Name { get; set; }
    }
}
