# NetCoreAI - 20 AI Integration Projects with .NET
This repository contains 20 hands-on projects developed with C#, ASP.NET Core, OpenAI APIs, Google Cloud Vision, RapidAPI and various AI technologies.
Throughout these projects, I gained practical experience in:

* ASP.NET Core Web API Development
* API Consumption with HttpClient
* OpenAI API Integration
* DALL·E Image Generation
* Whisper Speech-to-Text
* Text-to-Speech Applications
* OCR Technologies
* Google Cloud Vision
* Sentiment Analysis
* Text Summarization
* PDF Analysis
* Web Scraping
* RSS News Processing
* Prompt Engineering
* AI-Powered Application Development

Technologies Used:

* C#
* .NET 8
* ASP.NET Core MVC
* ASP.NET Core Web API
* Entity Framework Core
* SQL Server
* OpenAI API
* Google Cloud Vision API
* RapidAPI
* HtmlAgilityPack
* PdfPig
* Tesseract OCR
* JSON
* HttpClient
* Dependency Injection
* Service Layer Architecture

---
## Project 01 - API Demo
Bu projede ASP.NET Core Web API kullanılarak temel CRUD işlemleri gerçekleştirildi. Entity Framework Core ile SQL Server bağlantısı kurularak müşteri verilerinin listeleme, ekleme, silme, güncelleme ve detay getirme işlemleri geliştirildi. HTTP metodlarının (GET, POST, PUT, DELETE) çalışma mantığı öğrenildi.
## Project 02 - API Consume UI
Bu projede ASP.NET Core MVC kullanılarak harici bir Web API tüketildi. HttpClient ve IHttpClientFactory yapıları ile API istekleri gönderildi. JSON verileri DTO sınıfları yardımıyla deserialize edilerek kullanıcı arayüzünde görüntülendi ve CRUD işlemleri gerçekleştirildi.
## Project 03 - RapidAPI Integration
Bu projede RapidAPI platformu kullanılarak IMDb Top 100 dizi verileri çekildi. HTTP istekleri, API anahtarı kullanımı ve JSON verilerinin C# nesnelerine dönüştürülmesi konuları uygulamalı olarak öğrenildi.
## Project 04 - OpenAI Chat Integration
Bu projede OpenAI Chat API kullanılarak konsol üzerinden çalışan bir yapay zeka sohbet uygulaması geliştirildi. Kullanıcıdan alınan sorular OpenAI modeline gönderildi ve üretilen cevaplar ekrana yazdırıldı. API entegrasyonu, HTTP istekleri ve JSON veri işleme süreçleri öğrenildi.
## Project 05 - OpenAI Whisper Audio Transcription
Bu projede OpenAI Whisper modeli kullanılarak ses dosyaları metne dönüştürüldü. MP3 formatındaki dosyalar API'ye gönderilerek otomatik transkripsiyon işlemi gerçekleştirildi. Dosya yükleme, multipart form-data yapısı ve Speech-to-Text teknolojileri uygulamalı olarak öğrenildi.
## Project 06 - DALL·E Image Generation
Bu projede OpenAI'nin DALL·E modeli kullanılarak metinden görsel üretimi gerçekleştirildi. Kullanıcının girdiği prompt API'ye gönderildi, dönen Base64 formatındaki görsel verisi PNG dosyasına dönüştürülerek bilgisayara kaydedildi. Text-to-Image teknolojisinin çalışma mantığı öğrenildi.
## Project 07 - Tesseract OCR
Bu projede Tesseract OCR kütüphanesi kullanılarak görseller içerisindeki metinler okunmuştur. Görsel işleme, karakter tanıma (OCR) ve metin çıkarma süreçleri uygulamalı olarak öğrenilmiştir.
## Project 08 - Google Cloud Vision OCR
Bu projede Google Cloud Vision API kullanılarak görseller içerisindeki metinler tespit edilmiştir. Bulut tabanlı görüntü işleme servisleri, API kimlik doğrulama süreçleri ve OCR teknolojileri uygulamalı olarak öğrenilmiştir.
## Project 09 - OpenAI Translation
Bu projede OpenAI Chat API kullanılarak metin çeviri uygulaması geliştirildi. Kullanıcı tarafından girilen metinler İngilizceye çevrilerek doğal dil işleme (NLP) ve yapay zeka destekli çeviri süreçleri öğrenildi.
## Project 10 - Text To Speech
Bu projede .NET'in SpeechSynthesizer sınıfı kullanılarak metinler sese dönüştürülmüştür. Text-to-Speech teknolojisinin temel çalışma mantığı öğrenilmiş ve kullanıcıdan alınan metinlerin sesli olarak okunması sağlanmıştır.
## Project 11 - Text To Speech With OpenAI
Bu projede OpenAI Text-to-Speech API kullanılarak metinler ses dosyasına dönüştürülmüştür. Kullanıcıdan alınan metin API’ye gönderilmiş, dönen ses verisi .wav formatında kaydedilmiştir.
## Project 12 - Sentiment Analysis AI App
Bu projede OpenAI Chat API kullanılarak kullanıcıdan alınan metinlerin duygu analizi yapılmıştır. Metinler Positive, Negative veya Neutral olarak sınıflandırılmıştır.
## Project 13 - Advanced Sentiment Analysis AI App
Bu projede OpenAI API kullanılarak metinler üzerinde gelişmiş duygu analizi yapılmıştır. Joy, Sadness, Anger, Fear, Surprise ve Neutral gibi duygular yüzdesel olarak analiz edilmiştir.
## Project 14 - Article Summarize AI
Bu projede OpenAI API kullanılarak uzun metinlerin farklı seviyelerde özetlenmesi sağlanmıştır. Kısa, orta ve detaylı özet seçenekleriyle metin özetleme mantığı uygulanmıştır.
## Project 15 - Web Scraping With OpenAI API
Bu projede HtmlAgilityPack kullanılarak web sayfası içeriği alınmış ve OpenAI API ile analiz edilerek Türkçe özetlenmiştir. Web scraping ve yapay zeka destekli metin analizi birlikte uygulanmıştır.
## Project 16 - PDF Analysis With OpenAI
Bu projede PDF dosyalarının içeriği PdfPig kütüphanesi ile okunmuş ve elde edilen metinler OpenAI API kullanılarak analiz edilip özetlenmiştir. PDF işleme ve yapay zeka destekli doküman analizi uygulamalı olarak gerçekleştirilmiştir.
## Project 17 - Google Cloud Vision Object Detection
Bu projede Google Cloud Vision API kullanılarak görseller içerisindeki nesneler tespit edilmiştir. LABEL_DETECTION özelliği ile görüntü işleme ve nesne tanıma teknolojileri uygulanmıştır.
## Project 18 - AI News Summarizer With RSS
Bu projede RSS kaynaklarından güncel haberler çekilmiş ve OpenAI API kullanılarak kısa özetler oluşturulmuştur. XML veri işleme, RSS entegrasyonu ve yapay zeka destekli haber özetleme süreçleri uygulanmıştır.
## Project 19 - Story Generation With AI
Bu projede OpenAI GPT modeli kullanılarak kullanıcı tercihleri doğrultusunda özgün hikayeler oluşturulmuştur. Prompt Engineering, içerik üretimi ve Generative AI kavramları uygulamalı olarak kullanılmıştır.
## Project 20 - Recipe Suggestion With OpenAI
Bu projede ASP.NET Core MVC mimarisi kullanılarak OpenAI API entegrasyonu gerçekleştirilmiştir. Kullanıcının sahip olduğu malzemelere göre yapay zeka destekli yemek tarifleri oluşturulmuş, Service Layer ve Dependency Injection yapıları uygulanmıştır.



