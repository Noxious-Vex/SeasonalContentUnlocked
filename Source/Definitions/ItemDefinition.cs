namespace SeasonalContentUnlocked.Definitions
{
    /// <summary>
    /// Defines a vanilla recipe that can be restored.
    /// </summary>
    public class ItemDefinition
    {
        /// <summary>
        /// Determines whether SeasonalContentUnlocked should restore this recipe.
        /// </summary>
        public bool RestoreEnabled { get; set; } = true;


        /// <summary>
        /// Internal recipe item name.
        /// </summary>
        public string ItemName { get; set; } = string.Empty;


        /// <summary>
        /// User-facing display name.
        /// </summary>
        public string DisplayName { get; set; } = string.Empty;
    }
}