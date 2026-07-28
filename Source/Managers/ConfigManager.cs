using BepInEx.Configuration;
using SeasonalContentUnlocked.Config;
using SeasonalContentUnlocked.Definitions;

namespace SeasonalContentUnlocked.Managers
{
    public static class ConfigManager
    {
        public static ConfigLayout Current { get; private set; } = new ConfigLayout();


        public static void Initialize(ConfigFile config)
        {
            Current.ConfigPath = config.ConfigFilePath;


            Current.Advanced.EnableExperimentalFeatures =
                config.Bind(
                    "Advanced Features",
                    "Enable Experimental Features",
                    false,
                    "Enables experimental features that are not considered stable."
                ).Value;


            Current.Advanced.Logging =
                config.Bind(
                    "Advanced Features",
                    "Logging",
                    ConfigLogOptions.Standard,
                    "Console Logging verbosity level."
                ).Value;


            Current.Yule.EnableXmasCrown =
                config.Bind(
                    "Yule Seasonal Objects",
                    "Enable Christmas Crown",
                    true,
                    "Restores the Christmas Crown Prefab as a permanently available build piece."
                ).Value;


            Current.Yule.EnableXmasGarland =
                config.Bind(
                    "Yule Seasonal Objects",
                    "Enable Christmas Garland",
                    true,
                    "Restores the Christmas Garland Prefab as a permanently available build piece."
                ).Value;


            Current.Yule.EnableMistletoe =
                config.Bind(
                    "Yule Seasonal Objects",
                    "Enable Mistletoe",
                    true,
                    "Restores the Mistletoe Prefab as a permanently available build piece."
                ).Value;


            Current.Yule.EnableGiftSmall =
                config.Bind(
                    "Yule Seasonal Objects",
                    "Enable Small Gift",
                    true,
                    "Restores the small Christmas Gift Prefab as a permanently available build piece."
                ).Value;


            Current.Yule.EnableGiftMedium =
                config.Bind(
                    "Yule Seasonal Objects",
                    "Enable Medium Gift",
                    true,
                    "Restores the medium Christmas Gift Prefab as a permanently available build piece."
                ).Value;


            Current.Yule.EnableGiftLarge =
                config.Bind(
                    "Yule Seasonal Objects",
                    "Enable Large Gift",
                    true,
                    "Restores the large Christmas Gift Prefab as a permanently available build piece."
                ).Value;


            Current.Yule.EnableXmasTree =
                config.Bind(
                    "Yule Seasonal Objects",
                    "Enable Christmas Tree",
                    true,
                    "Restores the Christmas Tree Prefab as a permanently available build piece."
                ).Value;


            Current.Halloween.EnableJackOTurnip =
                config.Bind(
                    "Halloween Seasonal Objects",
                    "Enable Jack-O-Turnip",
                    true,
                    "Restores the Jack-O-Turnip Prefab as a permanently available build piece."
                ).Value;


            Current.Midsummer.EnableMaypole =
                config.Bind(
                    "Midsummer Seasonal Objects",
                    "Enable Maypole",
                    true,
                    "Restores the Maypole Prefab as a permanently available build piece."
                ).Value;
        }
    }
}