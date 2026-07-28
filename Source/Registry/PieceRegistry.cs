using System.Collections.Generic;
using SeasonalContentUnlocked.Definitions;
using SeasonalContentUnlocked.Managers;

namespace SeasonalContentUnlocked.Registry
{
    /// <summary>
    /// Registry containing all restored build pieces.
    /// </summary>
    public static class PieceRegistry
    {
        private static readonly List<PieceDefinition> Pieces =
            new List<PieceDefinition>();


        /// <summary>
        /// Initializes all registered pieces.
        /// </summary>
        public static void Initialize()
        {
            Pieces.Clear();

            RegisterPieces();
        }


        /// <summary>
        /// Registers all supported build pieces.
        /// </summary>
        private static void RegisterPieces()
        {
            RegisterPiece(
                new PieceDefinition
                {
                    PrefabName = "piece_maypole",
                    DisplayName = "Maypole",
                    RestoreEnabled = ConfigManager.Current.Midsummer.EnableMaypole
                }
            );


            RegisterPiece(
                new PieceDefinition
                {
                    PrefabName = "piece_jackoturnip",
                    DisplayName = "Jack-o-Turnip",
                    RestoreEnabled = ConfigManager.Current.Halloween.EnableJackOTurnip
                }
            );


            RegisterPiece(
                new PieceDefinition
                {
                    PrefabName = "piece_xmastree",
                    DisplayName = "Christmas Tree",
                    RestoreEnabled = ConfigManager.Current.Yule.EnableXmasTree
                }
            );


            RegisterPiece(
                new PieceDefinition
                {
                    PrefabName = "piece_xmascrown",
                    DisplayName = "Christmas Crown",
                    RestoreEnabled = ConfigManager.Current.Yule.EnableXmasCrown
                }
            );


            RegisterPiece(
                new PieceDefinition
                {
                    PrefabName = "piece_xmasgarland",
                    DisplayName = "Christmas Garland",
                    RestoreEnabled = ConfigManager.Current.Yule.EnableXmasGarland
                }
            );


            RegisterPiece(
                new PieceDefinition
                {
                    PrefabName = "piece_mistletoe",
                    DisplayName = "Mistletoe",
                    RestoreEnabled = ConfigManager.Current.Yule.EnableMistletoe
                }
            );


            RegisterPiece(
                new PieceDefinition
                {
                    PrefabName = "piece_gift1",
                    DisplayName = "Small Christmas Gift",
                    RestoreEnabled = ConfigManager.Current.Yule.EnableGiftSmall
                }
            );


            RegisterPiece(
                new PieceDefinition
                {
                    PrefabName = "piece_gift2",
                    DisplayName = "Medium Christmas Gift",
                    RestoreEnabled = ConfigManager.Current.Yule.EnableGiftMedium
                }
            );


            RegisterPiece(
                new PieceDefinition
                {
                    PrefabName = "piece_gift3",
                    DisplayName = "Large Christmas Gift",
                    RestoreEnabled = ConfigManager.Current.Yule.EnableGiftLarge
                }
            );
        }


        /// <summary>
        /// Adds a piece definition to the registry.
        /// </summary>
        private static void RegisterPiece(PieceDefinition definition)
        {
            Pieces.Add(definition);
        }


        /// <summary>
        /// Returns all registered pieces.
        /// </summary>
        public static List<PieceDefinition> GetPieces()
        {
            return Pieces;
        }
    }
}