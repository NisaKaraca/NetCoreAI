
using System.Speech.Synthesis;

class Program
{
    static void Main(string[] args)
    {
        SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();

        speechSynthesizer.Volume = 100;
        speechSynthesizer.Rate = 0;

        Console.Write("Metni Girin: ");
        string input = Console.ReadLine();

        if(!string.IsNullOrEmpty(input))
        {
            speechSynthesizer.Speak(input);
        }
        else
        {
            Console.WriteLine("Lütfen geçerli bir metin girin.");
        }
        Console.ReadLine();
    }
}