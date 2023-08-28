using Entities.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace MovieWebUI.Models
{
    public class CategoryListViewModel
    {
        public List<Category> ?Categories { get; set; }
    }
}
