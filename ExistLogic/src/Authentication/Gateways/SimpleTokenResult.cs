using System;
using System.ComponentModel.DataAnnotations;

namespace ExistLogic.Authentication.Gateways
{
    [Serializable]
    public class SimpleTokenResult : ISimpleTokenResult
    {
        [DataType("token")]
        public string Token { get; set; }
    }
}