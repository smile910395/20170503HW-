namespace WebApplication1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ConnectDatabase : DbContext
    {
        public ConnectDatabase()
            : base("name=ConnectDatabase")
        {
        }

        public virtual DbSet<AccountBook> AccountBook { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
