namespace InfernitasSE.Projects.OpenIssueTracker.Backend.Models
{
    /// <summary>
    /// Base-Class for all Table-related Models.
    /// </summary>
    public abstract class TableModel
    {
        /// <summary>
        /// Primary Key in all Tables. 
        /// </summary>
        public long Id { get; set; }
    }
}
