namespace NetFlex
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    /// <summary>
    /// Defines the <see cref="MenuHelper" />.
    /// </summary>
    public static class MenuHelper
    {
        /// <summary>
        /// Show a Menu and ask for response.
        /// </summary>
        /// <param name="menu">The menu<see cref="string"/>.</param>
        /// <param name="maxVal">The maxVal<see cref="int"/>.</param>
        /// <returns>The <see cref="int"/>.</returns>
        public static int ShowMenu(string menu, int maxVal)
        {
            Console.Clear();
            Console.WriteLine(menu);
            Console.WriteLine(new string('-', 110));

            return GetChoice(maxVal);
        }

        /// <summary>
        /// Display a Movie.
        /// </summary>
        /// <param name="movie">The movie<see cref="Movie"/>.</param>
        internal static void DisplayMovie(Movie movie)
        {
            DisplayTitle(movie);
            Console.WriteLine("Length   : " + movie.Length);
            Console.WriteLine("Year     : " + movie.Year);
            DisplayUrl(movie);
        }

        /// <summary>
        /// Display list of Movies.
        /// </summary>
        /// <param name="movies">The movies<see cref="List{Movie}"/>.</param>
        /// <returns>The <see cref="int"/>.</returns>
        internal static int DisplayMovies(List<Movie> movies)
        {
            for (int i = 0; i < movies.Count; i++)
            {
                OutputMovieData(i + 1, movies[i]);
            }
            Console.Write("Välj film:");
            return GetChoice(movies.Count);
        }

        /// <summary>
        /// Display a aSerie.
        /// </summary>
        /// <param name="serie">The serie<see cref="Serie"/>.</param>
        internal static void DisplaySerie(Serie serie)
        {
            DisplayTitle(serie);
            Console.WriteLine("Episodes : " + serie.Episodes);
            Console.WriteLine("Seasons  : " + serie.Seasons);
            DisplayUrl(serie);
        }

        /// <summary>
        /// Display list of Series.
        /// </summary>
        /// <param name="series">The series<see cref="List{Serie}"/>.</param>
        /// <returns>The <see cref="int"/>.</returns>
        internal static int DisplaySeries(List<Serie> series)
        {
            for (int i = 0; i < series.Count; i++)
            {
                OutputMovieData(i + 1, series[i]);
            }
            Console.Write("Välj serie:");
            return GetChoice(series.Count);
        }

        /// <summary>
        /// Show Create Movie/Serie Menu.
        /// </summary>
        /// <returns>The <see cref="int"/>.</returns>
        internal static int ShowCreateMenu()
        {
            var sb = new System.Text.StringBuilder();
            sb.AppendLine("Välkommen till Netflex!");
            sb.AppendLine("Välj någon av följande alternativ för att skapa");
            sb.AppendLine("1: Serier");
            sb.AppendLine("2: Filmer");
            sb.AppendLine("3: Gå vidare");
            return ShowMenu(sb.ToString(), 3);
        }

        /// <summary>
        /// Show Display list Menu.
        /// </summary>
        /// <returns>The <see cref="int"/>.</returns>
        internal static int ShowDisplayMenu()
        {
            var sb = new System.Text.StringBuilder(110);
            sb.AppendLine("Välj vad du vill titta på");
            sb.AppendLine("1: Visa alla serier");
            sb.AppendLine("2: Visa alla filmer");
            return ShowMenu(sb.ToString(), 2);
        }

        /// <summary>
        /// Display movie/Serie Title.
        /// </summary>
        /// <param name="movie">The movie<see cref="Show"/>.</param>
        private static void DisplayTitle(Show movie)
        {
            Console.WriteLine(GetMovieTitle(movie));
            Console.WriteLine("Genre    : " + movie.Genre);
        }

        /// <summary>
        /// Display an IMDB search Url.
        /// </summary>
        /// <param name="serie">The serie<see cref="Show"/>.</param>
        private static void DisplayUrl(Show serie)
        {
            var url = "https://www.imdb.com/find?q=" + GetMovieTitle(serie).Replace(' ', '+').Replace("&", "^&");
            Console.WriteLine(url);

            // Overkill, opens a webbrowser withe the URL
            // var processes = Process.GetProcessesByName("Chrome");
            // var path = processes.FirstOrDefault()?.MainModule?.FileName;
            // Process.Start(path, url);
            // Code borrowed from https://stackoverflow.com/a/55572459

        }

        /// <summary>
        /// Asks for a nummeric choice and keeps asking until the needed value is given
        /// </summary>
        /// <param name="maxVal">The maxValue<see cref="int"/>.</param>
        /// <returns>The <see cref="int"/>.</returns>
        private static int GetChoice(int maxVal)
        {
            var input = 0;
            do
            {
                int.TryParse(Console.ReadLine(), out input);
            } while (input < 1 || input > maxVal);
            return input;
        }

        /// <summary>
        /// Get Movie Title.
        /// </summary>
        /// <param name="movie">The movie<see cref="Show"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        private static string GetMovieTitle(Show movie) => movie.Name + " (" + movie.Year + ")";

        /// <summary>
        /// Output Movie Data.
        /// </summary>
        /// <param name="position">The position<see cref="int"/>.</param>
        /// <param name="movie">The movie<see cref="Show"/>.</param>
        private static void OutputMovieData(int position, Show movie) => Console.WriteLine($"{position} : {movie.Name}({movie.Year})");
    }
}
