using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZulipAPI
{
    public class FetchApiKeyResult : ApiResult
    {
        public string Email { get; set; }
        [JsonProperty("api_key")]
        public string ApiKey { get; set; }
    }
}
