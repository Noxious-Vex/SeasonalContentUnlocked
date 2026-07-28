namespace SeasonalContentUnlocked.Config
{
    /// <summary>
    /// Configuration settings for Midsummer restoration.
    /// </summary>
    public class ConfigMidsummerOptions
    {
        /// <summary>
        /// Restores the Maypole as a permanently available build piece.
        /// </summary>
        public bool EnableMaypole { get; set; } = true;

        /// <summary>
        /// Restores the MidsummerCrown as a permanently available item craftable.
        /// </summary>
        public bool EnableMidsummerCrown { get; set; } = true;
    }
}