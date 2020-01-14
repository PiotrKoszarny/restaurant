using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace SwaggerGenerator
{
    class Program
    {
        static readonly HttpClient _httpClient = new HttpClient();
        private const string _url = "http://localhost:65278/swagger/v1/swagger.json";

        static async Task Main(string[] args)
        {
            
            Console.WriteLine("press key to generate file");
            Console.ReadKey();

            var response = await _httpClient.GetAsync(_url);

            var body = response.Content.ReadAsStringAsync();

            Console.WriteLine(body);
            Console.ReadKey();
        }
    }
}
