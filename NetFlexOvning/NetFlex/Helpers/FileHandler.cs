namespace NetFlex
{
    using Newtonsoft.Json;

    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// Defines the <see cref="FileHandler" />.
    /// </summary>
    public static class FileHandler
    {
        /// <summary>
        /// Save Movies list.
        /// </summary>
        /// <param name="filename">The filename<see cref="string"/>.</param>
        /// <param name="movies">The movies<see cref="List{Movie}"/> list.</param>
        public static void SaveMovies(string filename, List<Movie> movies) => File.WriteAllText(filename + ".json", JsonConvert.SerializeObject(movies, Formatting.Indented));

        /// <summary>
        /// Save Series list.
        /// </summary>
        /// <param name="filename">The filename<see cref="string"/>.</param>
        /// <param name="series">The series<see cref="List{Serie}"/> list.</param>
        public static void SaveSeries(string filename, List<Serie> series) => File.WriteAllText(filename + ".json", JsonConvert.SerializeObject(series, Formatting.Indented));

        /// <summary>
        /// Load Movies.
        /// </summary>
        /// <param name="filename">The filename<see cref="string"/>.</param>
        /// <returns>The <see cref="List{Movie}"/>.</returns>
        internal static List<Movie> LoadMovies(string filename)
        {
            var data = GetData(filename);
            if (data == "") data = Seeder.CreateMovies();
            return (List<Movie>)JsonConvert.DeserializeObject<List<Movie>>(data);
        }

        /// <summary>
        /// Load Series.
        /// </summary>
        /// <param name="filename">The filename<see cref="string"/>.</param>
        /// <returns>The <see cref="List{Serie}"/>.</returns>
        internal static List<Serie> LoadSeries(string filename)
        {
            var data = GetData(filename);
            if (data == "") data = Seeder.CreateSeries();
            return (List<Serie>)JsonConvert.DeserializeObject<List<Serie>>(data);
        }

        /// <summary>
        /// Load the JsonFile.
        /// </summary>
        /// <param name="filename">The filename<see cref="string"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        private static string GetData(string filename)
        {
            var data = string.Empty;
            if (File.Exists(filename + ".json"))
            {
                try
                {
                    data = File.ReadAllText(filename + ".json");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error reading movies");
                    Console.WriteLine(ex.Message);
                    data = "";
                }
            }
            return data;
        }
    }
}
