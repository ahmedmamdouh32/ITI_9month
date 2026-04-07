using BlazorApp1.Models;
using System.Net.Http.Json;


namespace BlazorApp1.Services
{
    public class EmployeeService : IServices<Employee>
    {
        new HttpClient _httpClient;

        public EmployeeService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:7960");
        }

        public async Task Add(Employee entity)
        {
            await _httpClient.PostAsJsonAsync("/api/Emp", entity);
        }

        public async Task Delete(int id)
        {
            await _httpClient.DeleteAsync($"api/emp/{id}");
        }

        public async Task<List<Employee>> GetAll()
        {
           var result = await _httpClient.GetFromJsonAsync<List<Employee>>("/api/Emp");

            return result;
        }

        public async Task<Employee> GetById(int id)
        {
            return await _httpClient.GetFromJsonAsync<Employee>($"api/emp/{id}");
        }

        public async Task Update(int id, Employee entity)
        {
            await _httpClient.PutAsJsonAsync($"/api/Emp/{id}", entity);
        }
    }
}
