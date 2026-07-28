using System.Reflection;
using SeasonalContentUnlocked.Definitions;
using SeasonalContentUnlocked.Registry;
using UnityEngine;

namespace SeasonalContentUnlocked.Managers
{
    public static class PieceManager
    {
        private static FieldInfo EnabledField;

        private static int PiecesAttempted;
        private static int PiecesRestored;
        private static int PiecesAlreadyEnabled;
        private static int PiecesFailed;


        /// <summary>
        /// Initializes piece restoration.
        /// </summary>
        public static void Initialize()
        {
            ResetStatistics();

            RestorePieces();

            LogSummary();
        }


        /// <summary>
        /// Resets restoration statistics.
        /// </summary>
        private static void ResetStatistics()
        {
            PiecesAttempted = 0;
            PiecesRestored = 0;
            PiecesAlreadyEnabled = 0;
            PiecesFailed = 0;
        }


        /// <summary>
        /// Restores all registered pieces.
        /// </summary>
        private static void RestorePieces()
        {
            if (ZNetScene.instance == null)
            {
                LogManager.LogError(
                    "ZNetScene instance unavailable. Cannot restore pieces."
                );

                return;
            }


            foreach (PieceDefinition definition in PieceRegistry.GetPieces())
            {
                if (!definition.RestoreEnabled)
                {
                    continue;
                }


                PiecesAttempted++;

                RestorePiece(definition);
            }
        }


        /// <summary>
        /// Restores a single build piece.
        /// </summary>
        private static void RestorePiece(PieceDefinition definition)
        {
            GameObject prefab =
                ZNetScene.instance.GetPrefab(definition.PrefabName);


            if (prefab == null)
            {
                PiecesFailed++;

                LogManager.LogWarn(
                    $"Could not find prefab: {definition.PrefabName}"
                );

                return;
            }


            Piece piece = prefab.GetComponent<Piece>();


            if (piece == null)
            {
                PiecesFailed++;

                LogManager.LogWarn(
                    $"Prefab {definition.PrefabName} has no Piece component."
                );

                return;
            }


            if (EnabledField == null)
            {
                EnabledField = piece.GetType().GetField(
                    "m_enabled",
                    BindingFlags.Instance |
                    BindingFlags.NonPublic |
                    BindingFlags.Public
                );
            }


            if (EnabledField == null)
            {
                PiecesFailed++;

                LogManager.LogError(
                    "Could not locate Piece.m_enabled field."
                );

                return;
            }


            bool currentValue =
                (bool)EnabledField.GetValue(piece);


            if (currentValue)
            {
                PiecesAlreadyEnabled++;

                LogManager.LogDebug(
                    $"Piece already enabled: {definition.DisplayName}"
                );

                return;
            }


            EnabledField.SetValue(piece, true);

            PiecesRestored++;

            LogManager.LogDebug(
                $"Restored piece: {definition.DisplayName} ({definition.PrefabName})"
            );
        }


        /// <summary>
        /// Logs piece restoration summary.
        /// </summary>
        private static void LogSummary()
        {
            LogManager.LogDebug(
                "========================================"
            );

            LogManager.LogDebug(
                $"Piece Restoration Summary:"
            );

            LogManager.LogDebug(
                $"Attempted: {PiecesAttempted}"
            );

            LogManager.LogDebug(
                $"Restored: {PiecesRestored}"
            );

            LogManager.LogDebug(
                $"Already Enabled: {PiecesAlreadyEnabled}"
            );

            LogManager.LogDebug(
                $"Failed: {PiecesFailed}"
            );

            LogManager.LogDebug(
                "========================================"
            );
        }
    }
}