using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ImdsApi
{
    public class AzureCliTokenInfo
    {
        [JsonProperty("tokenType")]
        public string TokenType { get; set; }
        [JsonProperty("expiresIn")]
        public ulong ExpiresIn { get; set; }
        [JsonProperty("expiresOn")]
        public DateTimeOffset ExpiresOn { get; set; }
        [JsonProperty("resource")]
        public string Resource { get; set; }
        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }
        [JsonProperty("refreshToken")]
        public string RefreshToken { get; set; }
        [JsonProperty("oid")]
        public string Oid { get; set; }
        [JsonProperty("userId")]
        public string UserId { get; set; }
        [JsonProperty("isMRRT")]
        public string IsMrrt { get; set; }
        [JsonProperty("_clientId")]
        public string ClientId { get; set; }
        [JsonProperty("_authority")]
        public string Authority { get; set; }
    }
}
