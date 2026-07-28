namespace SeasonalContentUnlocked.Config
{
    /// <summary>
    /// Configuration settings for Halloween restoration.
    /// </summary>
    public class ConfigHalloweenOptions
    {
        /// <summary>
        /// Restores Jack-o-Turnip as a permanently available build piece.
        /// </summary>
        public bool EnableJackOTurnip { get; set; } = true;

        /// <summary>
        /// Restores the PointyHat as a permanently available item craftable.
        /// </summary>
        public bool EnablePointyHat { get; set; } = true;
    }
}