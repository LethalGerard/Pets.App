using Pets.App.Interfaces;
using System.Net.Http.Json;
using System.Net.Http;
using System.Net.Http.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pets.App.Classes
{
    public class PetStore 
    {
        private HttpClient _http = new HttpClient();
        public string Message { get; private set; } = string.Empty;
        public List<IPet> Pets { get; private set; } = new();

        IPet[] dog = new IPet[];
        IPet[] cat = new();

        public async Task<List<IPet>> LoadPets() 
        {
            var cat = _http.GetFromJsonAsync<IPet[]>("sample-data/cats.json");
            var dog = _http.GetFromJsonAsync<IPet[]>("sample-data/dogs.json");
            Pets.AddRange(cat);
            Pets.AddRange(dog);
            return Pets;
        }


        public PetStore(HttpClient http) => _http = http;

    }
}

