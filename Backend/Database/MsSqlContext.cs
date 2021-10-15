using Microsoft.EntityFrameworkCore;
using InfernitasSE.Projects.OpenIssueTracker.Backend.Models;

namespace InfernitasSE.Projects.OpenIssueTracker.Backend.Database
{
    public class MsSqlContext : DbContext 
    {

        public DbSet<User> Users { get; set; }

        public MsSqlContext(){}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){}

        protected override void OnModelCreating(ModelBuilder modelBuilder){}
    }
}