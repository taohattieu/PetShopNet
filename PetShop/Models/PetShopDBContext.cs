﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PetShop.Models
{
    public class PetShopDBContext:DbContext
    {
        public PetShopDBContext():base("name=ChuoiKN") { }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Contact> Contacts { get;set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Orderdetail> OrderDetails { get; set; }
        public DbSet<Post> Posts { get; set; } 
        public DbSet<Product> Products { get; set;}
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Topic> Topic { get; set; } 
        public DbSet<User> Users { get;set; }
    }
}