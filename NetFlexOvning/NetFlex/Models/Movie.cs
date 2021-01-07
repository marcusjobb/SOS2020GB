namespace NetFlex
{
    /// <summary>
    /// Defines the <see cref="Movie" />.
    /// </summary>
    public class Movie : Show
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Movie"/> class.
        /// </summary>
        /// <param name="name">The name<see cref="string"/>.</param>
        public Movie(string name) : base(name)
        {
        }

        /// <summary>
        /// Gets or sets the Length.
        /// </summary>
        public int Length { get; set; }
    }
}
