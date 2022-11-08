using DomainModel.Models;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FlightManagementBlazorServer.Services
{
    public class DocumentService
    {
        private readonly HttpClient _httpClient;
        private readonly string BaseApiUrl = "https://localhost:44334/api/Document";
        public DocumentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<Document> GetDocumentAsync(int passengerId)
        {
            return await _httpClient.GetFromJsonAsync<Document>($"{BaseApiUrl}/EditDocument/{passengerId}");         
        }
        public async Task UpdateDocument(Document document)
        {
            var request = new HttpRequestMessage(HttpMethod.Put, BaseApiUrl);
            request.Content = new StringContent(JsonSerializer.Serialize(document),
                Encoding.UTF8, "application/json");
            await _httpClient.SendAsync(request);
        }
        public async Task AddDocumentAsync(Document document)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, BaseApiUrl);
            request.Content = new StringContent(JsonSerializer.Serialize(document),
                Encoding.UTF8, "application/json");
            await _httpClient.SendAsync(request);
        }
    }
}
