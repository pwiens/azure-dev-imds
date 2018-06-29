using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ImdsApi
{
    public class TokenService
    {
        private readonly string _filePath;
        private readonly List<AzureCliTokenInfo> _tokens = new List<AzureCliTokenInfo>();

        public TokenService() : this($@"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\.azure\accessTokens.json")
        {
        }


        public TokenService(string filePath)
        {
            _filePath = filePath ?? throw new ArgumentNullException(nameof(filePath));

            if (File.Exists(_filePath))
                throw new ArgumentException($"The azure cli access token file doesn't exist");
        }
    }
}
