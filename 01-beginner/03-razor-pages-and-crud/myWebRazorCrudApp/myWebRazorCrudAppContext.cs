using System;
using Microsoft.EntityFrameworkCore;

namespace myWebRazorCrudApp
{
    public class myWebRazorCrudAppContext : DbContext {
        public myWebRazorCrudAppContext(DbContextOptions options)
            : base(options) {
                
        }

        public DbSet<Cliente> Cliente { get; set; }

    }
}