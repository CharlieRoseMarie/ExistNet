namespace ExistLogic.Authentication
{
    public interface IAuthenticationCredentials
    {
        string Username { get; set; }
        string Password { get; set; }
    }
}