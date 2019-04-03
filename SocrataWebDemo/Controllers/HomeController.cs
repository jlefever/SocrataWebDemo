using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SocrataWebDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly HttpClient _httpClient;

        public HomeController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [HttpGet]
        [Route("/{resourceId}/{column}")]
        public async Task<IActionResult> GetAsync(string resourceId, string column)
        {
            var url = $"{BaseUrl}/resource/{resourceId}.json?$select={column}";
            var content = await _httpClient.GetAsync(url);
            var json = await content.Content.ReadAsStringAsync();
            return Json(JsonConvert.DeserializeObject(json));
        }

        private const string BaseUrl = "https://data.baltimorecity.gov";
    }
}
