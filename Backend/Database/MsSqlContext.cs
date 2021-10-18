namespace InfernitasSE.Projects.OpenIssueTracker.Backend.Database
{
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Microsoft SQL Database Context
    /// </summary>
    public class MsSqlContext : DbContext
    {
        /// <summary>
        /// Constructor. 
        /// </summary>
        public MsSqlContext() { }

        /// <summary>
        /// Model Configurator
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

        /// <summary>
        /// Model Creator
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder) { }
    }
}
