using System;

namespace Lab10
{
    internal sealed class AudioBook : Book
    {
        public int DurationMinutes { get; set; }
        public string Narrator { get; set; }

        // Реалізація абстрактної властивості
        public override string ContentType 
        {
            get { return "Аудіоформат"; }
        }

        public AudioBook(string author, string title, string publisher, int year, double price, int durationMinutes, string narrator)
            : base(author, title, publisher, year, price)
        {
            DurationMinutes = durationMinutes;
            Narrator = narrator;
        }

        // Реалізація абстрактного методу
        public override void DisplayInfo()
        {
            Console.WriteLine($"--- Інформація про видання ({ContentType}) ---");
            Console.WriteLine($"Назва: {Title}");
            Console.WriteLine($"Автор: {Author}");
            Console.WriteLine($"Читець: {Narrator}");
            Console.WriteLine($"Тривалість: {DurationMinutes} хвилин");
            Console.WriteLine($"Ціна: {Price} грн");
            ShowCopyright(); 
        }
    }
}