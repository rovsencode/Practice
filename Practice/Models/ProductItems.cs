using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Models
{
    public class ProductItems
    {
        public int Id { get; set; }
        public List<ProductItem>? ProductItem { get; set; }
    }
}
