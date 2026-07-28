using SeasonalContentUnlocked.Definitions;
using SeasonalContentUnlocked.Registry;
using UnityEngine;

namespace SeasonalContentUnlocked.Managers
{
    /// <summary>
    /// Handles restoration and registration of item recipes.
    /// </summary>
    public static class ItemManager
    {
        private static int RecipesAttempted;
        private static int RecipesRestored;
        private static int RecipesAlreadyEnabled;
        private static int RecipesFailed;


        /// <summary>
        /// Initializes recipe item restoration.
        /// </summary>
        public static void Initialize()
        {
            ResetStatistics();

            RestoreItems();

            LogSummary();
        }


        /// <summary>
        /// Resets restoration statistics.
        /// </summary>
        private static void ResetStatistics()
        {
            RecipesAttempted = 0;
            RecipesRestored = 0;
            RecipesAlreadyEnabled = 0;
            RecipesFailed = 0;
        }


        /// <summary>
        /// Restores all registered item recipes.
        /// </summary>
        private static void RestoreItems()
        {
            if (ObjectDB.instance == null)
            {
                LogManager.LogError(
                    "ObjectDB instance unavailable. Cannot restore items."
                );

                return;
            }


            foreach (ItemDefinition definition in ItemRegistry.GetRecipes())
            {
                if (!definition.RestoreEnabled)
                {
                    continue;
                }


                RecipesAttempted++;

                RestoreItem(definition);
            }
        }


        /// <summary>
        /// Restores a single item recipe.
        /// </summary>
        private static void RestoreItem(ItemDefinition definition)
        {
            foreach (Recipe recipe in ObjectDB.instance.m_recipes)
            {
                if (recipe == null || recipe.m_item == null)
                {
                    continue;
                }


                if (recipe.m_item.name != definition.ItemName)
                {
                    continue;
                }


                if (recipe.m_enabled)
                {
                    RecipesAlreadyEnabled++;

                    LogManager.LogDebug(
                        $"Recipe already enabled: {definition.DisplayName}"
                    );

                    return;
                }


                recipe.m_enabled = true;

                RecipesRestored++;

                LogManager.LogDebug(
                    $"Restored recipe: {definition.DisplayName} ({definition.ItemName})"
                );

                return;
            }


            RecipesFailed++;

            LogManager.LogWarn(
                $"Could not find recipe: {definition.ItemName}"
            );
        }


        /// <summary>
        /// Logs recipe restoration summary.
        /// </summary>
        private static void LogSummary()
        {
            LogManager.LogDebug(
                "========================================"
            );

            LogManager.LogDebug(
                "Recipe Restoration Summary:"
            );

            LogManager.LogDebug(
                $"Attempted: {RecipesAttempted}"
            );

            LogManager.LogDebug(
                $"Restored: {RecipesRestored}"
            );

            LogManager.LogDebug(
                $"Already Enabled: {RecipesAlreadyEnabled}"
            );

            LogManager.LogDebug(
                $"Failed: {RecipesFailed}"
            );

            LogManager.LogDebug(
                "========================================"
            );
        }
    }
}