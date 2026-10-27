using System;
using System.Text;
using Lab10; // Підключення простору імен нашого проєкту

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine(" ЛАБОРАТОРНА РОБОТА 10: ФАЙЛОВА СТРУКТУРА ПРОЄКТУ \n");

        // Звернення до статичного поля
        Console.WriteLine($"Вітаємо у системі: {LibraryArchive.libraryName}\n");

        // Створення об'єктів запечатаних класів 
        AudioBook audio = new AudioBook("Тарас Шевченко", "Кобзар", "Аудіокнига Україна", 2018, 350.00, 360, "Богдан Бенюк");
        audio.DisplayInfo();
        
        Console.WriteLine(new string('-', 50));

        Anime anime = new Anime("Масасі Кісімото", "Наруто", "Shueisha", 2002, 500.00, "Studio Pierrot", 220);
        anime.DisplayInfo();

        // Виклик статичного методу
        LibraryArchive.ShowArchiveInfo();

        Console.WriteLine("\n РОБОТУ ПРОГРАМИ ЗАВЕРШЕНО ");
    }
}