namespace NetFlex
{
    /// <summary>
    /// Defines the <see cref="Seeder" />.
    /// </summary>
    public static class Seeder
    {
        /// <summary>
        /// Create a json string to use as template.
        /// </summary>
        /// <returns>The <see cref="string"/>.</returns>
        public static string CreateMovies() =>
            "[{\"Length\":98,\"Name\":\"Lost Boys\",\"Genre\":\"Horror / Komedi\",\"Year\":1987},{\"Length\":101,\"Name\":\"Labyrinth\",\"Genre\":\"Musical\",\"Year\":1986},{\"Length\":89,\"Name\":\"Ouija\",\"Genre\":\"Horror, Mystery, Thriller\",\"Year\":2014},{\"Length\":116,\"Name\":\"Sweeney Todd: The Demon Barber of Fleet Street\",\"Genre\":\"Drama, Horror, Musical\",\"Year\":2007}]"
            ;

        /// <summary>
        /// Create a json string to use as template.
        /// </summary>
        /// <returns>The <see cref="string"/>.</returns>
        public static string CreateSeries() =>
            "[{\"Episodes\":55,\"Seasons\":3,\"Name\":\"Shadowhunters\",\"Genre\":\"Action, Drama, Fantasy\",\"Year\":2016},{\"Episodes\":27,\"Seasons\":3,\"Name\":\"Penny Deadful\",\"Genre\":\" Drama, Fantasy, Horror\",\"Year\":2014},{\"Episodes\":56,\"Seasons\":6,\"Name\":\"Vikings\",\"Genre\":\"Action, Adventure, Drama \",\"Year\":2013},{\"Episodes\":12,\"Seasons\":2,\"Name\":\"The Frankenstein Chronicles\",\"Genre\":\" Crime, Drama, Fantasy \",\"Year\":2015}]"
            ;
    }
}
