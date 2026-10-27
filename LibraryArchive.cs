using System;

namespace Lab10
{
    internal static class LibraryArchive
    {
        // Статичне поле
        public static string libraryName = "Національний цифровий архів";
        
        // Статична властивість
        public static int TotalItems { get; set; } = 0;

        // Статичний метод
        public static void ShowArchiveInfo()
        {
            Console.WriteLine($"\n[Статистика Архіву] Бібліотека: '{libraryName}'. Всього зареєстровано видань: {TotalItems}");
        }
    }
}