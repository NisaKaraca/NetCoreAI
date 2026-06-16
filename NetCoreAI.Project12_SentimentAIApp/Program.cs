using System.Text;
using Newtonsoft.Json;

class Program
{
    private static readonly string apiKey = "YOUR_API_KEY";

    static async Task Main(string[] args)
    {
        Console.Write("Metni Giriniz: ");
        string inputText = Console.ReadLine();

        if (!string.IsNullOrEmpty(inputText))
        {
            Console.WriteLine();
            Console.Write("Metin işleniyor...");
            Console.WriteLine();
            string sentiment = await AnalyzeSentiment(inputText);
            Console.WriteLine($"Metin Analizi Sonucu: {sentiment}");
        }
        else
        {
            Console.WriteLine("Lütfen geçerli bir metin girin.");
        }
    }
    static async Task<string> AnalyzeSentiment(string text)
    {
        using (HttpClient client = new HttpClient())
        {
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");
            var requestBody = new
            {
                model = "gpt-3.5-turbo",
                messages = new[]
                {
                    new { role = "system", content = "You are a helpful assistant that analyzes the sentiment of the given text." },
                    new { role = "user", content = $"Analyze the sentiment of the following text: {text} and return only Positive , Negative or Neutral" }
                },
            }; 
            string jsonBody = JsonConvert.SerializeObject(requestBody);
            HttpContent content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync("https://api.openai.com/v1/chat/completions", content);

            string responseJson = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                var result = JsonConvert.DeserializeObject<dynamic>(responseJson);
                return result.choices[0].message.content.ToString();
            }
            else
            {
                Console.WriteLine($"Hata: {responseJson}");
                return "Hata";
            }
        }
    }
}