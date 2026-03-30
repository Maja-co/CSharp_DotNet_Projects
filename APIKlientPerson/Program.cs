using System.Net.Http.Json;
using PersonWebAPI.Models;

namespace APIKlientPerson {
    class Program {
        static async Task Main(string[] args) {
            await Button_Click_1();
            await Get_Async();
            await GetEarthquakes_Async();
            await GetEarthquakes2_Async();
        }

        private static async Task GetEarthquakes_Async() {
            HttpClient client = new HttpClient();
            try {
                string jsonRaw = await client.GetStringAsync("https://earthquake.usgs.gov/earthquakes/feed/v1.0/summary/4.5_week.geojson");
                string snippet = jsonRaw.Substring(0, 200);
        
                Console.WriteLine("\n--- Data fra USGS (Jordskælv) ---");
                Console.WriteLine(snippet + "...");
            }
            catch (Exception ex) {
                Console.WriteLine("Fejl ved hentning af jordskælv: " + ex.Message);
            }
        }
        
        private static async Task GetEarthquakes2_Async() {
            HttpClient client = new HttpClient();
            try {
                var response = await client.GetFromJsonAsync<EarthquakeResponse>("https://earthquake.usgs.gov/earthquakes/feed/v1.0/summary/4.5_week.geojson");

                Console.WriteLine("\n--- Data fra USGS (Model-baseret) ---");

                if (response?.Features != null) {
                    foreach (var quake in response.Features.Take(5)) {
                        Console.WriteLine($"Styrke: {quake.Properties.Magnitude} | Sted: {quake.Properties.Place}");
                    }
                }
            }
            catch (Exception ex) {
                Console.WriteLine("Fejl: " + ex.Message);
            }
        }

        private static async Task Get_Async() {
            HttpClient client = new HttpClient();
            try {
                List<Person>? personer =
                    await client.GetFromJsonAsync<List<Person>>("http://localhost:5109/api/Person/GetAll");

                if (personer != null) {
                    foreach (var p in personer) {
                        Console.WriteLine($"Navn: {p.Name}, Efternavn: {p.Surname}, ID: {p.Id}");
                    }
                }
            }
            catch (Exception ex) {
                Console.WriteLine("Fejl:" + ex.Message);
            }
        }

        private static async Task Button_Click_1() {
            HttpClient client = new HttpClient();
            Person person = new Person("Jan", "Jensen", 4);
            var result = await client.PostAsJsonAsync("http://localhost:5109/api/Person", person);

            if (result.IsSuccessStatusCode) {
                Console.WriteLine("Person oprettet med succes!");
            }
            else {
                Console.WriteLine("Fejl:" + result.StatusCode);
            }
        }
        
    }
}