using System.Net.Http.Json;


namespace APIKlient {
    class Program {
        static async Task Main(string[] args) {
            await Get_Async();
            Button_Click_1();
        }

        private static async Task Get_Async() {
            HttpClient client = new HttpClient();
            try {
                Car x = await client.GetFromJsonAsync<Car>("https://localhost:7079/api/Car/GetById?id=0");
                Console.WriteLine("Make:" + x.Make + ", Model:" + x.Model);
            }
            catch (Exception ex) {
                Console.WriteLine("Fejl:" + ex.Message);
            }
        }

        private static void Button_Click_1() {
            HttpClient client = new HttpClient();
            Car car = new Car("Swasticar", "3", 4);
            var stringTask = client.PostAsJsonAsync("https://localhost:7079/api/Car", car);

            HttpResponseMessage result = stringTask.Result;
            if (result.StatusCode == System.Net.HttpStatusCode.Created) {
                Console.WriteLine("Oprettet");
            }
            else {
                Console.WriteLine("Fejl:" + result.StatusCode);
            }
        }
    }
}