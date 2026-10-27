using System;

namespace Lab10
{
    internal sealed class Anime : Book
    {
        public string Studio { get; set; }
        public int Episodes { get; set; }

        // Реалізація абстрактної властивості
        public override string ContentType 
        {
            get { return "Анімаційний серіал"; }
        }

        public Anime(string author, string title, string publisher, int year, double price, string studio, int episodes)
            : base(author, title, publisher, year, price)
        {
            Studio = studio;
            Episodes = episodes;
        }

        // Реалізація абстрактного методу
        public override void DisplayInfo()
        {
            Console.WriteLine($"--- Інформація про видання ({ContentType}) ---");
            Console.WriteLine($"Назва: {Title}");
            Console.WriteLine($"Оригінальний автор: {Author}");
            Console.WriteLine($"Студія анімації: {Studio}");
            Console.WriteLine($"Кількість епізодів: {Episodes}");
            Console.WriteLine($"Ціна: {Price} грн");
            ShowCopyright();
        }
    }
}