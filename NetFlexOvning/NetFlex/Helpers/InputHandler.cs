namespace NetFlex
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="InputHandler" />.
    /// </summary>
    public static class InputHandler
    {
        /// <summary>
        /// Ask For Movies Data.
        /// </summary>
        /// <param name="movies">The movies<see cref="List{Movie}"/>.</param>
        public static void AskForMovieData(List<Movie> movies)
        {
            if (movies == null) movies = new List<Movie>();
            var OneMore = true;
            do
            {
                Console.Clear();
                Console.Write("Namn på filmen:");
                var title = Console.ReadLine();
                Console.Write("Årtal:");
                int.TryParse(Console.ReadLine(), out int year);
                Console.Write("Kategori (ex. Horror, Musical, Komedi):");
                var genre = Console.ReadLine();
                Console.Write("Längd (minuter):");
                int.TryParse(Console.ReadLine(), out int length);

                movies.Add(new Movie(title) { Year = year, Length = length, Genre = genre });

                OneMore = KeepGoing();
            } while (OneMore);
        }

        public static bool KeepGoing()
        {
            bool OneMore;
            Console.WriteLine("En till? (J/N)");
            var choice = Console.ReadKey();
            OneMore = choice.Key == ConsoleKey.J;
            return OneMore;
        }

        /// <summary>
        /// Ask For Series Data.
        /// </summary>
        /// <param name="series">The series<see cref="List{Serie}"/>.</param>
        internal static void AskForSerieData(List<Serie> series)
        {
            if (series == null) series = new List<Serie>();
            var OneMore = true;
            do
            {
                Console.Clear();
                Console.Write("Namn på serien:");
                var title = Console.ReadLine();
                Console.Write("Årtal:");
                int.TryParse(Console.ReadLine(), out int year);
                Console.Write("Kategori (ex. Horror, Musical, Komedi):");
                var genre = Console.ReadLine();
                Console.Write("Avsnitt:");
                int.TryParse(Console.ReadLine(), out int episodes);
                Console.Write("Säsonger:");
                int.TryParse(Console.ReadLine(), out int seasons);

                series.Add(new Serie(title) { Year = year, Genre = genre, Episodes = episodes, Seasons = seasons });

                OneMore = KeepGoing();
            } while (OneMore);
        }
    }
}
