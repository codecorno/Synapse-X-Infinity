using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Synapse_X_Infinity
{
    class APITypes
    {
        public class Posts
        {
            [JsonPropertyName("id")]
            public int id { get; set; }

            [JsonPropertyName("title")]
            public string title { get; set; }

            [JsonPropertyName("content")]
            public string content { get; set; }

            [JsonPropertyName("script")]
            public string script { get; set; }

            [JsonPropertyName("created_at")]
            public DateTime created_at { get; set; }
        }
    }
    class APIWrapper
    {
        public async static Task<List<APITypes.Posts>> GetPost()
        {
            HttpClient postsClient = new HttpClient();
            postsClient.DefaultRequestHeaders.Accept.Clear();
            postsClient.DefaultRequestHeaders.Add("User-Agent", "Synapse X Infinity UserAgent");

            var streamTask = postsClient.GetStreamAsync("https://synapse-database.vercel.app/api/posts");
            return await JsonSerializer.DeserializeAsync<List<APITypes.Posts>>(await streamTask);
        }
    }
}
