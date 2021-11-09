namespace BackendChallenge.PasswordValidator.Core.Models
{
    public class Password
    {
        public string Content { get; private set; }

        public Password(string content)
        {
            Content = content;
        }
    }
}
