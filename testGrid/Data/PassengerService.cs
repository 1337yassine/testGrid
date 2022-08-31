using Microsoft.AspNetCore.Http.Metadata;
using static MudBlazor.CategoryTypes;
using System.Net.Http;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.Reflection.Metadata.Ecma335;

namespace testGrid.Data
{
    public class PassengerService
    {
     
        public async Task<RootPassenger> GetPassengersAsync(string page , string size)
        {
            HttpClient client = new();
            HttpResponseMessage response = await client.GetAsync($"https://api.instantwebtools.net/v1/passenger?page={page}&size={size}");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<RootPassenger>(responseBody);
        }
    }
}

