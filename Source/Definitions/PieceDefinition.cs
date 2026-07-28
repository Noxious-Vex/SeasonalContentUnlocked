namespace SeasonalContentUnlocked.Definitions
{
    /// <summary>
    /// Defines a vanilla build piece that can be restored.
    /// </summary>
    public class PieceDefinition
    {
        /// <summary>
        /// Determines whether SeasonalContentUnlocked should restore this piece.
        /// </summary>
        public bool RestoreEnabled { get; set; } = true;


        /// <summary>
        /// Internal Unity prefab name.
        /// </summary>
        public string PrefabName { get; set; } = string.Empty;


        /// <summary>
        /// User-facing display name.
        /// </summary>
        public string DisplayName { get; set; } = string.Empty;
    }
}