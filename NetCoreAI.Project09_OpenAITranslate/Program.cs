
using System.Text.Json.Serialization;
using Newtonsoft.Json;

class Program
{
    private static async Task Main(string[] args)
    {
        Console.Write("lütfen çevirmek istediğiniz metni giriniz:");
        string inputText = Console.ReadLine();

        string apiKey = "YOUR_API_KEY";
        // OpenAI API anahtarınızı buraya ekleyin

        string translatedText = await TranslateTextToEnglish(inputText, apiKey);

        if (!string.IsNullOrEmpty(translatedText))
        {
            Console.WriteLine();
            Console.WriteLine($"Çeviri (İngilizce): {translatedText}");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Çeviri başarısız oldu.");
        }
    }
    private static async Task<string> TranslateTextToEnglish(string text, string apiKey)
    {
        using(HttpClient client = new HttpClient())
        {
            client.DefaultRequestHeaders.Add("Authorization",$"Bearer {apiKey}");
            var requestBody = new
            {
                model = "gpt-3.5-turbo",
                messages = new[]
                {
                    new { role = "system", content = "You are a helpful assistant that translates text to English." },
                    new { role = "user", content = $"Translate the following text to English: {text}" }
                },
            };
            string jsonBody = JsonConvert.SerializeObject(requestBody);
            var content = new StringContent(jsonBody, System.Text.Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await client.PostAsync("https://api.openai.com/v1/chat/completions", content);
                string responseString = await response.Content.ReadAsStringAsync();
                dynamic responseObject = JsonConvert.DeserializeObject(responseString);
                string translation = responseObject.choices[0].message.content;

                return translation;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }

    }
}