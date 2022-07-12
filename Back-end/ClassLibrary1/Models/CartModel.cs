using BookStore8.Models.DataModels;
using System.Collections.Generic;

namespace BookStore8.Models.Models
{
    public class CartModel
    {
        public CartModel() { }

        public CartModel(Cart cart)
        {
            Id = (int)cart.Id;
            UserId = (int)cart.Userid;
            BookId = (int)cart.Bookid;
            Quantity = (int)cart.Quantity;
#pragma warning disable CS8601 // Possible null reference assignment.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            BookName = cart.Book.Name;
#pragma warning restore CS8602 // Dereference of a possibly null reference.
#pragma warning restore CS8601 // Possible null reference assignment.
            Price = (decimal)cart.Book.Price;
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public int Quantity { get; set; }
        public string BookName { get; set; }
        public decimal Price { get; set; }
    }
}
