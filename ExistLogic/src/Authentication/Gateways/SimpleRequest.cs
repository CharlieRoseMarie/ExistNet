using RestSharp;

namespace ExistLogic.Authentication.Gateways
{
    public class SimpleRequest : IExistAuthGateway
    {
        private const string GatewayUrl = "https://exist.io/api/1/auth/simple-token/";
        public ISimpleTokenResult Authenticate(IAuthenticationCredentials credentials)
        {
            var client = new RestClient(GatewayUrl);
            var request = new RestRequest(Method.POST);
            request.AddParameter("username", credentials.Username);
            request.AddParameter("password", credentials.Password);
            var response = client.Execute<SimpleTokenResult>(request);
            return response.Data;
        }
    }
}