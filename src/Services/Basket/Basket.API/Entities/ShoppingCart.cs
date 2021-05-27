using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basket.API.Entities
{
    public class ShoppingCart
    {
		public string Username { get; set; }
		public List<ShoppingCartItem> Items { get; set; } = new List<ShoppingCartItem>();

		public ShoppingCart()
		{

		}

		public ShoppingCart(string userName)
		{
			Username = userName;
		}

		public decimal TotalPrice {
			get
			{
				decimal totalprice = 0;
				foreach (ShoppingCartItem item in Items)
				{
					totalprice += item.Price * item.Quantity;
				}
				return totalprice;
			}
		}
	}
}
