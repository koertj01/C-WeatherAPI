using System;

namespace SupabaseApi.Controllers
{
    public class SupabaseConfig
    {
        public string Url { get; set; }
        public string ApiKey { get; set; }

        public SupabaseConfig(string url, string apiKey)
        {
            Url = url;
            ApiKey = apiKey;
        }
    }
}
