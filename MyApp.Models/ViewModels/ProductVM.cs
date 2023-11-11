using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MyApp.Models.ViewModels
{
    public class ProductVM
    {
        public Product Product { get; set; }  
        public IEnumerable <Product> Products { get; set; } = new List<Product>();
        public IEnumerable<SelectListItem> Categories { get; set; }
    }
}
