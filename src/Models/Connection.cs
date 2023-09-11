using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LifeHarmony.src.Models
{
    internal class Connection
    {
        private readonly HttpClient _httpClient;
        string coneccion = "https://localhost:7150/api/";
        public Connection()
        {
            _httpClient = new HttpClient();
        }
        public async Task<List<PlanAlimentacion>> GetPlanAPI()
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(coneccion + "PlanAlimentacion/SelectManyPlanAlimentacion");
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();

                List<PlanAlimentacion> plan = JsonConvert.DeserializeObject<List<PlanAlimentacion>>(responseBody);

                return plan;
            }
            catch (Exception)
            {
                // Manejo de errores
                return null;
            }
        }
    }
    
}
