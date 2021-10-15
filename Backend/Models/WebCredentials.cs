namespace InfernitasSE.Projects.OpenIssueTracker.Backend.Models
{
    public class WebCredential
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public WebCredential(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }

        public WebCredential(){}
    }
}