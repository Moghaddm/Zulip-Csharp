using Newtonsoft.Json;
using System.Collections.Generic;

namespace ZulipAPI
{
    public class ResponseBase
    {
        public string Message { get; set; }
        public string Result { get; set; }
    }
}
