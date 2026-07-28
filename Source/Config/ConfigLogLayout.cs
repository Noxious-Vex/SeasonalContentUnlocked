namespace SeasonalContentUnlocked.Config
{
    /// <summary>
    /// Main configuration layout for SeasonalContentUnlocked.
    /// </summary>
    public class ConfigLayout
    {
        /// <summary>
        /// Internal runtime path to the active BepInEx configuration file.
        /// This is metadata only and is not written to the user configuration.
        /// </summary>
        public string ConfigPath { get; set; } = string.Empty;


        /// <summary>
        /// Advanced and experimental configuration settings.
        /// </summary>
        public ConfigAdvancedOptions Advanced { get; set; } = new ConfigAdvancedOptions();


        /// <summary>
        /// Yule restoration settings.
        /// </summary>
        public ConfigYuleOptions Yule { get; set; } = new ConfigYuleOptions();


        /// <summary>
        /// Halloween restoration settings.
        /// </summary>
        public ConfigHalloweenOptions Halloween { get; set; } = new ConfigHalloweenOptions();


        /// <summary>
        /// Midsummer restoration settings.
        /// </summary>
        public ConfigMidsummerOptions Midsummer { get; set; } = new ConfigMidsummerOptions();
    }
}