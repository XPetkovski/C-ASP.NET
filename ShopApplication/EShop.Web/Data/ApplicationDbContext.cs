﻿using EShop.Web.Models.Domain;
using EShop.Web.Models.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EShop.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<EShopApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public virtual DbSet<ProductInShoppingCart> ProductInShoppingCarts { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Product>().Property(z => z.Id).ValueGeneratedOnAdd();
            builder.Entity<ShoppingCart>().Property(z => z.Id).ValueGeneratedOnAdd();
            builder.Entity<ProductInShoppingCart>().HasKey(z => new { z.ProductId, z.ShoppingCartID });
            builder.Entity<ProductInShoppingCart>().HasOne(z => z.product).WithMany(z => z.ProductInShoppingCarts)
                .HasForeignKey(z => z.ShoppingCartID);
            builder.Entity<ProductInShoppingCart>().HasOne(z => z.shoppingcart).WithMany(z => z.ProductInShoppingCarts)
                .HasForeignKey(z => z.ProductId);

            builder.Entity<ShoppingCart>().HasOne<EShopApplicationUser>(z => z.Owner)
                .WithOne(z => z.UserCart).HasForeignKey<ShoppingCart>(z => z.OwnerID);

        }

        internal void Add(ProductInShoppingCart itemToAdd)
        {
            throw new NotImplementedException();
        }
    }
}
