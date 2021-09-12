using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using MasterALevel.Services;

namespace MasterALevel
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigService();
            var creator = new EntityProvider();
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            var option = optionsBuilder.UseSqlServer(config.ConnectionString).Options;
            using (var db = new ApplicationContext(option))
            {
                db.Users.AddRange(creator.GetUsers());
                //db.SaveChanges();
                db.UserAddresses.AddRange(creator.GetUserAddress());
                //db.SaveChanges();
                db.Carts.AddRange(creator.GetCart());
                //db.SaveChanges();
                db.CartItems.AddRange(creator.GetCartItem());
                //db.SaveChanges();
                db.Products.AddRange(creator.GetProduct());
                //db.SaveChanges();
                db.Discounts.AddRange(creator.GetDiscount());
                //db.SaveChanges();
                db.Categories.AddRange(creator.GetCategory());
                //db.SaveChanges();
               
                //db.SaveChanges();
                db.Orders.AddRange(creator.GetOrder());
                //db.SaveChanges();
                db.Products.AddRange(creator.GetProduct());
                db.OrderItems.AddRange(creator.GetOrderItem());
                db.SaveChanges();


                
            }
        }

    }
}
