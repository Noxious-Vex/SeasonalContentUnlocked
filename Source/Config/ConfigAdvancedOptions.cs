using SeasonalContentUnlocked.Definitions;

namespace SeasonalContentUnlocked.Config
{
    /// <summary>
    /// Advanced and experimental configuration settings.
    /// </summary>
    public class ConfigAdvancedOptions
    {
        /// <summary>
        /// Enables experimental features that are not considered stable.
        /// </summary>
        public bool EnableExperimentalFeatures { get; set; } = false;


        /// <summary>
        /// Controls the amount of information displayed in the log.
        /// </summary>
        public ConfigLogOptions Logging { get; set; } =
            ConfigLogOptions.Standard;
    }
}