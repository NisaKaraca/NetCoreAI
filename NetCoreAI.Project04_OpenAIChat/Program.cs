
using System.Text.Json;

class Program
{
    static async Task Main(string[] args)
    {
        var apiKey = "YOUR_API_KEY";
        Console.WriteLine("Lütfen sorunuzu yazınız: (örnek: 'Merhaba bugün İstanbul'da hava kaç derece?)");

        var prompt = Console.ReadLine();
        using var httpClient = new HttpClient();
        httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

        var requestBody = new
        {
            model = "gpt-3.5-turbo",
            messages = new[]
            {
                new { role = "system", content = "You are a helpful assistant." },
                new { role = "user", content = prompt }
            },
            max_tokens = 500
        };

        var json = JsonSerializer.Serialize(requestBody);
        var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
        try
        {
            var response = await httpClient.PostAsync("https://api.openai.com/v1/chat/completions", content);
            var responseString = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                var result = JsonSerializer.Deserialize<JsonElement>(responseString);
                var answer = result.GetProperty("choices")[0].GetProperty("message").GetProperty("content").GetString();
                Console.WriteLine("Cevap: " + answer);
            }
            else
            {
                Console.WriteLine("API isteği başarısız oldu. Durum Kodu: " + response.StatusCode);
                Console.WriteLine("Hata: " + responseString);
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine("API isteği sırasında bir hata oluştu: " + ex.Message);
        }
    }
}