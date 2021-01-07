namespace NetFlex
{
    /// <summary>
    /// Defines the <see cref="Serie" />.
    /// </summary>
    public class Serie : Show
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Serie"/> class.
        /// </summary>
        /// <param name="name">The name<see cref="string"/>.</param>
        public Serie(string name) : base(name)
        {
        }

        /// <summary>
        /// Gets or sets the Episodes.
        /// </summary>
        public int Episodes { get; set; }

        /// <summary>
        /// Gets or sets the Seasons.
        /// </summary>
        public int Seasons { get; set; }
    }
}
