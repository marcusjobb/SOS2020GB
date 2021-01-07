namespace NetFlex
{
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Program" />.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Defines the Movies.
        /// </summary>
        internal static List<Movie> Movies;

        /// <summary>
        /// Defines the Series.
        /// </summary>
        internal static List<Serie> Series;

        /// <summary>
        /// Main method.
        /// </summary>
        internal static void Main()
        {
            // Load data
            Movies = FileHandler.LoadMovies("AllMovies");
            Series = FileHandler.LoadSeries("AllSeries");

            if (Series == null) Series = new List<Serie>();
            if (Movies == null) Movies = new List<Movie>();

            var choice = MenuHelper.ShowCreateMenu();
            if (choice == 1) InputHandler.AskForSerieData(Series);
            if (choice == 2) InputHandler.AskForMovieData(Movies);

            var KeepDisplaying = true;

            while (KeepDisplaying)
            {
                choice = MenuHelper.ShowDisplayMenu();
                if (choice == 1)
                {
                    choice = MenuHelper.DisplaySeries(Series);
                    MenuHelper.DisplaySerie(Series[choice - 1]);
                }
                if (choice == 2)
                {
                    choice = MenuHelper.DisplayMovies(Movies);
                    MenuHelper.DisplayMovie(Movies[choice - 1]);
                }
                KeepDisplaying = InputHandler.KeepGoing();
            }
            // Save data
            FileHandler.SaveMovies("AllMovies", Movies);
            FileHandler.SaveSeries("AllSeries", Series);
        }
    }
}
