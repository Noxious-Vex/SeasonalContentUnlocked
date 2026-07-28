using System.Collections.Generic;
using SeasonalContentUnlocked.Definitions;
using SeasonalContentUnlocked.Managers;

namespace SeasonalContentUnlocked.Registry
{
    /// <summary>
    /// Registry containing all restored recipes.
    /// </summary>
    public static class ItemRegistry
    {
        private static readonly List<ItemDefinition> Recipes =
            new List<ItemDefinition>();


        /// <summary>
        /// Initializes all registered recipes.
        /// </summary>
        public static void Initialize()
        {
            Recipes.Clear();

            RegisterRecipes();
        }


        /// <summary>
        /// Registers all supported recipes.
        /// </summary>
        private static void RegisterRecipes()
        {
            RegisterRecipe(
                new ItemDefinition
                {
                    ItemName = "HelmetMidsummerCrown",
                    DisplayName = "Midsummer Crown",
                    RestoreEnabled = ConfigManager.Current.Midsummer.EnableMidsummerCrown
                }
            );


            RegisterRecipe(
                new ItemDefinition
                {
                    ItemName = "HelmetPointyHat",
                    DisplayName = "Pointy Hat",
                    RestoreEnabled = ConfigManager.Current.Halloween.EnablePointyHat
                }
            );
        }


        /// <summary>
        /// Adds a recipe definition to the registry.
        /// </summary>
        private static void RegisterRecipe(ItemDefinition definition)
        {
            Recipes.Add(definition);
        }


        /// <summary>
        /// Returns all registered recipes.
        /// </summary>
        public static List<ItemDefinition> GetRecipes()
        {
            return Recipes;
        }
    }
}