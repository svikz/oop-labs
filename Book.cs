using System;

namespace Lab10
{
    public abstract class Book
    {
        // Неабстрактне поле
        private string publisher = "Не вказано";

        // Неабстрактна властивість
        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }

        // Автореалізовані властивості
        public string Author { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }

        // Абстрактна властивість
        public abstract string ContentType { get; }

        // Неабстрактний конструктор
        public Book(string author, string title, string publisher, int year, double price)
        {
            Author = author;
            Title = title;
            Publisher = publisher;
            Year = year;
            Price = price;
            
            // Звернення до статичної властивості при створенні об'єкта
            LibraryArchive.TotalItems++; 
        }

        // Абстрактний метод
        public abstract void DisplayInfo();

        // Неабстрактний (захищений) метод
        protected void ShowCopyright()
        {
            Console.WriteLine($"[Copyright] Всі права на видання належать: {Publisher}, {Year} рік.");
        }
    }
}