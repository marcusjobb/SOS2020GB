namespace NetFlex
{
    using System;

    /// <summary>
    /// Defines the <see cref="Show" />.
    /// </summary>
    public class Show
    {
        /// <summary>
        /// Gets the Name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets or sets the Genre.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Gets or sets the Year.
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Show"/> class.
        /// </summary>
        /// <param name="name">The name<see cref="string"/>.</param>
        public Show(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Play the movie or show.
        /// </summary>
        public void Play() => Console.WriteLine("Playing " + Name);
    }
}
