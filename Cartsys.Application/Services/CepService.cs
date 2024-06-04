using Cartsys.Domain.Entities;
using Newtonsoft.Json;
using System.Text.Json;

namespace Cartsys.Applications.Services
{
    public class CepService
    {
        private readonly HttpClient _httpClient;

        public CepService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<CepDados> ConsultarCepAsync(string cep)
        {
            string cepLocal = cep.Replace(".", "").Replace(" ", "");
            var url = $"https://viacep.com.br/ws/{cepLocal}/json/";
            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var endereco = JsonConvert.DeserializeObject<CepDados>(json);
                return endereco;
            }
            else
            {
                throw new Exception("Não foi possível consultar o CEP.");
            }
        }
    }
}
