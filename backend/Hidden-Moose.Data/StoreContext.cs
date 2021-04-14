﻿using Hidden.Moose.Domain.Catalog;
using Microsoft.EntityFrameworkCore;


namespace Hidden_Moose.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) 
            : base(options)
        { }
        
        public DbSet<Item> Items { get; set; }
    }
}
