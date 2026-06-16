
using System.Text;
using System.Text.Json;

class Poragram
{
    private static readonly string googleApiKey = "YOUR_API_KEY";
    private static readonly string imagePath = "C:\\Users\\nisak\\OneDrive\\Masaüstü\\3.jpg";

    static async Task Main()
    {
        Console.WriteLine("Google Vision Api ile Görsel Nesne Tespiti Yapılıyor...");
        string response = await DetectObjects(imagePath);
        Console.WriteLine("--------Tespit Edilen Nesneler--------\n");
        Console.WriteLine(response); 

        static async Task<string> DetectObjects(string path)
        {
            using var client = new HttpClient();
            string apiUrl = $"https://vision.googleapis.com/v1/images:annotate?key={googleApiKey}";

            byte[] imageBytes = File.ReadAllBytes(path);
            string base64Image = Convert.ToBase64String(imageBytes);

            var requestBody = new
            {
                requests = new[]
                {
                    new
                    {
                        image = new {content = base64Image},
                        features = new [] {new {type = "LABEL_DETECTION", maxResults = "10"}}
                    }
                }
            };

            var jsonContent = new StringContent(JsonSerializer.Serialize(requestBody),Encoding.UTF8,"application/json");
            HttpResponseMessage response = await client.PostAsync(apiUrl, jsonContent);
            string responseContent = await response.Content.ReadAsStringAsync();

            return responseContent;
        }
    }
}