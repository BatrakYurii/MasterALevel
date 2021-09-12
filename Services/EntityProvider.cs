using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterALevel.Services
{
    class EntityProvider
    {
        public List<User> GetUsers()
        {
            return new List<User>
            {
                new User()
                {
                    FirstName="Jhon",LastName="Snow", Email="JhonSnow@wolf.com",Age=17
                },
                new User()
                {
                    FirstName="Cersei",LastName="Lannister", Email="Cersei123@lion.com",Age=3
                },
                new User()
                {
                    FirstName="Robert",LastName="Baratheon", Email="RobKing2008@deer.com",Age=45
                },
                new User()
                {
                    FirstName="Teon",LastName="greyjoy", Email="Teon777@fish.com",Age=18
                },           

            };
        }

        public List<Product> GetProduct()
        {
            return new List<Product>
            {
                new Product()
                {
                    Name="iPhone XR",Price=800,CategoryId=1,
                },
                new Product()
                {
                    Name="Xiaomi MI 3",Price=349,CategoryId=1
                },
                new Product()
                {
                    Name="Lenovo ideaPad500",Price=990,CategoryId=2
                },
                new Product()
                {
                    Name="iMac Pro",Price=2500,CategoryId=2
                },
                new Product()
                {
                    Name="AppleWatch 6",Price=400,CategoryId=3
                },
                    
            };
        }

        public List<Category> GetCategory()
        {
            return new List<Category>
            {
                new Category
                {
                    Name="Smartphone"
                },
                new Category
                {
                    Name="PC"
                },
                new Category
                {
                    Name="Smartwatch"
                }
            };
        }

        public List<Cart> GetCart()
        {
            return new List<Cart>
            {
                new Cart
                {
                    UserId=1,DiscountId=1
                },
                new Cart
                {
                    UserId=2,DiscountId=2
                },
                new Cart
                {
                    UserId=3,DiscountId=3
                },
                new Cart
                {
                    UserId=4,DiscountId=1
                }
            };
        }

        public List<Discount> GetDiscount()
        {
            return new List<Discount>
            {
                new Discount
                {
                    Value=10
                },
                new Discount
                {
                    Value=20
                },
                new Discount
                {
                    Value=5
                }
            };
        }

        public List<UserAddress> GetUserAddress()
        {
            return new List<UserAddress>
            {
                new UserAddress
                {
                    UserId=1,CountryCode="355",City="Tirana",Address="Chkalova str",PhoneNumber="+12345678"
                },
                new UserAddress
                {
                    UserId=2,CountryCode="1",State="New York",City="New York",Address="Chkalova str",PhoneNumber="+975139234"
                },
                new UserAddress
                {
                    UserId=2,CountryCode="1",State="California",City="Los Angeles",Address="Pavlova str",PhoneNumber="983508753"
                },
                new UserAddress
                {
                    UserId=3,CountryCode="38",City="Odessa",Address="Shevchnko str",PhoneNumber="983280361"
                } ,
                new UserAddress
                {
                    UserId=4,CountryCode="7",City="Sochi",Address="Lenina str",PhoneNumber="977513518",id=5
                }
            };
        }

        public List<CartItem> GetCartItem()
        {
            return new List<CartItem>
            {
                new CartItem
                {
                    CartId=1,ProductId=1,Count=2
                },
                new CartItem
                {
                    CartId=1,ProductId=5,Count=3
                },
                new CartItem
                {
                    CartId=2,ProductId=4,Count=1
                },
                new CartItem
                {
                    CartId=3,ProductId=2,Count=5
                },
                new CartItem
                {
                    CartId=3,ProductId=1,Count=1
                },
                new CartItem
                {
                    CartId=4,ProductId=3,Count=6
                }
            };
        }

        public List<Order> GetOrder()
        {
            return new List<Order>
            {
                new Order
                {
                    UserId=1,DiscountId=1,Total=500
                },
                new Order
                {
                    UserId=2,DiscountId=3,Total=1700
                },
                new Order
                {
                    UserId=3,DiscountId=3,Total=800
                },
                new Order
                {
                    UserId=4,DiscountId=2,Total=1700
                }
            };
        }

        public List<OrderItem> GetOrderItem()
        {
            return new List<OrderItem>
            {
                new OrderItem
                {
                    OrderId=1,ProductId=2,Count=1,id=1
                },
                new OrderItem
                {
                    OrderId=2,ProductId=5,Count=5,id=2
                },
                new OrderItem
                {
                    OrderId=3,ProductId=2,Count=3,id=3
                },
                new OrderItem
                {
                    OrderId=4,ProductId=1,Count=2,id=4
                },
            };
        }
    }
}
