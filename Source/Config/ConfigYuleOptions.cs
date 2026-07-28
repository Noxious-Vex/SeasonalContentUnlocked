namespace SeasonalContentUnlocked.Config
{
    /// <summary>
    /// Configuration settings for Yule restoration.
    /// </summary>
    public class ConfigYuleOptions
    {
        /// <summary>
        /// Restores the Christmas Tree as a permanently available build piece.
        /// </summary>
        public bool EnableXmasTree { get; set; } = true;


        /// <summary>
        /// Restores the Christmas Crown as a permanently available build piece.
        /// </summary>
        public bool EnableXmasCrown { get; set; } = true;


        /// <summary>
        /// Restores the Christmas Garland as a permanently available build piece.
        /// </summary>
        public bool EnableXmasGarland { get; set; } = true;


        /// <summary>
        /// Restores Mistletoe as a permanently available build piece.
        /// </summary>
        public bool EnableMistletoe { get; set; } = true;


        /// <summary>
        /// Restores the small Christmas Gift as a permanently available build piece.
        /// </summary>
        public bool EnableGiftSmall { get; set; } = true;


        /// <summary>
        /// Restores the medium Christmas Gift as a permanently available build piece.
        /// </summary>
        public bool EnableGiftMedium { get; set; } = true;


        /// <summary>
        /// Restores the large Christmas Gift as a permanently available build piece.
        /// </summary>
        public bool EnableGiftLarge { get; set; } = true;
    }
}