namespace Airlines.Business.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Session4Entities : DbContext
    {
        public Session4Entities()
            : base("name=Session4Entities")
        {
        }

        public virtual DbSet<Airline> Airlines { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
