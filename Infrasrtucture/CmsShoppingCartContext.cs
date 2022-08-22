﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication5.Models;

namespace WebApplication5.Infrasrtucture
{
    public class CmsShoppingCartContext: DbContext
    {
        public CmsShoppingCartContext(DbContextOptions<CmsShoppingCartContext> options)
           : base(options)
        {
        }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
