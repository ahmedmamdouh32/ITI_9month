using Day3.Models;
namespace Day3.Services
{
    public class DepartmentService : IServices<Department>
    {

        HttpClient _httpClient;

        public DepartmentService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:7960");
        }
        public async Task Add(Department entity)
        {
            await _httpClient.PostAsJsonAsync("/api/Department", entity);
        }

        public async Task Delete(int id)
        {
            await _httpClient.DeleteAsync($"/api/Department/{id}");
        }

        public Task<List<Department>> GetAll()
        {
            return _httpClient.GetFromJsonAsync<List<Department>>("/api/Department");
        }

        public async Task<Department> GetById(int id)
        {
            return await _httpClient.GetFromJsonAsync<Department>($"/api/Department/{id}");
        }

        public async Task Update(int id, Department entity)
        {
            await _httpClient.PutAsJsonAsync($"/api/Department/{id}", entity);
        }
    }
}
