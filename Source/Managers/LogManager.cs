using BepInEx;
using BepInEx.Logging;
using SeasonalContentUnlocked.Definitions;

namespace SeasonalContentUnlocked.Managers
{
    public static class LogManager
    {
        private static ManualLogSource Logger;

        private static ConfigLogOptions CurrentLevel =
            ConfigLogOptions.Standard;


        public static void Initialize(ManualLogSource logger)
        {
            Logger = logger;
        }


        public static void SetLogLevel(ConfigLogOptions level)
        {
            CurrentLevel = level;
        }


        public static void LogLoad(string message)
        {
            Logger.LogInfo($"[LOAD] {message}");
        }


        public static void LogInfo(string message)
        {
            if (ShouldLog(ConfigLogOptions.Standard))
            {
                Logger.LogInfo($"[INFO] {message}");
            }
        }


        public static void LogWarn(string message)
        {
            if (ShouldLog(ConfigLogOptions.Warnings))
            {
                Logger.LogWarning($"[WARNING] {message}");
            }
        }


        public static void LogError(string message)
        {
            Logger.LogError($"[ERROR] {message}");
        }


        public static void LogDebug(string message)
        {
            if (ShouldLog(ConfigLogOptions.Debug))
            {
                Logger.LogInfo($"[DEBUG] {message}");
            }
        }


        private static bool ShouldLog(ConfigLogOptions messageLevel)
        {
            switch (CurrentLevel)
            {
                case ConfigLogOptions.Minimal:

                    return messageLevel == ConfigLogOptions.Minimal;


                case ConfigLogOptions.Warnings:

                    return messageLevel == ConfigLogOptions.Minimal
                        || messageLevel == ConfigLogOptions.Warnings;


                case ConfigLogOptions.Standard:

                    return messageLevel != ConfigLogOptions.Debug;


                case ConfigLogOptions.Debug:

                    return true;
            }


            return false;
        }
    }
}