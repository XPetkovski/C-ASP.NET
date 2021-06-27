using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Web.Models.Domain
{
    public class ProductInShoppingCart
    {
        public Guid ProductId { get; set; }
        public Guid ShoppingCartID { get; set; }
        public Product product { get; set; }
        public ShoppingCart shoppingcart { get; set; }
        public int Quantity { get; set; }

    }
}
