namespace InfernitasSE.Projects.OpenIssueTracker.Backend.Models
{
    /// <summary>
    /// Web Credential Model
    /// </summary>
    public class WebCredential
    {
        /// <summary>
        /// Username.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Password.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Constructor. 
        /// </summary>
        /// <param name="username">Username.</param>
        /// <param name="password">Password.</param>
        public WebCredential(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        /// <summary>
        /// Constructor. 
        /// </summary>
        public WebCredential() { }
    }
}
