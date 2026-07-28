using BepInEx;
using SeasonalContentUnlocked.Managers;
using SeasonalContentUnlocked.Registry;
using System.Collections;
using UnityEngine;

namespace SeasonalContentUnlocked
{
    [BepInPlugin(ModGUID, ModName, ModVersion)]
    public class Plugin : BaseUnityPlugin
    {
        private const string ModGUID = "NoxiousVex.SeasonalContentUnlocked";
        private const string ModName = "Seasonal Content Unlocked";
        private const string ModAuthor = "Noxious Vex";
        private const string ModVersion = "1.0.0";


        private void Awake()
        {
            LogManager.Initialize(Logger);


            ConfigManager.Initialize(Config);


            LogManager.SetLogLevel(
                ConfigManager.Current.Advanced.Logging
            );


            LogManager.LogLoad("========================================");
            LogManager.LogLoad($"{ModName}: Version {ModVersion} by {ModAuthor} has successfully loaded.");
            LogManager.LogLoad("========================================");


            StartCoroutine(InitializeRestoration());
        }


        /// <summary>
        /// Initializes all restoration systems after the vanilla scene has loaded.
        /// </summary>
        private IEnumerator InitializeRestoration()
        {
            yield return new WaitUntil(
                () => ZNetScene.instance != null
            );


            //
            // Piece Restoration
            //
            PieceRegistry.Initialize();

            PieceManager.Initialize();


            //
            // Item Restoration
            //
            ItemRegistry.Initialize();

            ItemManager.Initialize();
        }
    }
}