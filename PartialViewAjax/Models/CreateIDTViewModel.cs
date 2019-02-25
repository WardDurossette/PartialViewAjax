using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialViewAjax.Models
{
    public class CreateIDTViewModel
    {

        public int CategoryId { get; set; }

        public List<Product> Products { get; set; }

        public List<Category> CategoryList { get; set; }


    }
}
