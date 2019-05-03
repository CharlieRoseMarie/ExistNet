namespace ExistLogic.Authentication.Gateways
{
    public interface IExistAuthGateway
    {
        ISimpleTokenResult Authenticate(IAuthenticationCredentials credentials);
    }
}