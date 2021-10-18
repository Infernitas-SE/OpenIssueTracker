namespace InfernitasSE.Projects.OpenIssueTracker.Backend.Models
{
    /// <summary>
    /// User-Model.
    /// </summary>
    public class User : TableModel
    {
        /// <summary>
        /// Username. (LDAP IAM)
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Name. 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Surname.
        /// </summary>
        public string Surname { get; set; }
    }
}
