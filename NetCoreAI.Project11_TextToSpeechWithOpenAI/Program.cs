
using System.Text;
using Newtonsoft.Json;

class Program
{
    private static readonly string apiKey = "YOUR_API_KEY";
    static async Task Main(String[] args)
    {
        Console.Write("Metni Giriniz: ");
        string input;
        input = Console.ReadLine();

        if (!string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Metin işleniyor...");
            await GenerateSpeech(input);
            Console.WriteLine("Ses dosyası 'output.wav' olarak kaydedildi!");
            System.Diagnostics.Process.Start("explorer.exe", "output.wav");
        }
    }
    static async Task GenerateSpeech(string text)
    {
        using (HttpClient client = new HttpClient())
        {
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");
            var requestBody = new
            {
                model = "tts-1",
                input = text,
                voice = "alloy",
            };

            string jsonBody = JsonConvert.SerializeObject(requestBody);
            HttpContent content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync("https://api.openai.com/v1/audio/speech", content);

            if (response.IsSuccessStatusCode)
            {
                byte[] audioData = await response.Content.ReadAsByteArrayAsync();
                await File.WriteAllBytesAsync("output.wav", audioData);
            }
            else
            {
                Console.WriteLine($"Hata: {response.StatusCode}");
            }
        }
    }
}