using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZulipAPI
{
    public class ZulipClient
    {
        internal RestClient restClient;
        public string ServerApiURL { get; internal set; }

        public ZulipClient(string userEmail, string apiKey)
        {
            UserEmail = userEmail;
            ApiKey = apiKey;
            restClient = new RestClient();
            restClient.Authenticator = new HttpBasicAuthenticator(UserEmail, ApiKey);
        }

        public string UserEmail { get; }
        public string ApiKey { get; }

        public Users.UserEndPoint GetUserEndPoint()
            => new Users.UserEndPoint(this);

        public Streams.StreamEndPoint GetStreamEndPoint()
            => new Streams.StreamEndPoint(this);

        public Messages.MessageEndPoint GetMessageEndPoint()
            => new Messages.MessageEndPoint(this);
    }
}
