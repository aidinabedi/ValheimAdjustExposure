using BepInEx;
using BepInEx.Configuration;
using HarmonyLib;
using System.Reflection;
using UnityEngine;
using UnityEngine.PostProcessing;

namespace ValheimAdjustExposure
{
    [BepInPlugin(ID, Manifest.Product, Manifest.Version)]
    [BepInProcess("valheim.exe")]
    public class AdjustExposurePlugin : BaseUnityPlugin
    {
        public const string ID = Manifest.ProjectName;

        #region BepInEx configs
        private static ConfigEntry<float> _exposure;
        private static ConfigEntry<ColorGradingModel.Tonemapper> _tonemapper;
        #endregion

        private Harmony _harmony;

        private void Awake()
        {
            _exposure = Config.Bind("General", "Exposure", 1f, "Adjusts the overall exposure of the scene in EV units.");
            _tonemapper = Config.Bind("General", "Tonemapper", ColorGradingModel.Tonemapper.ACES, "Tonemapping algorithm to use at the end of the color grading process.");

            _harmony = Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), ID);
        }

        public static void AdjustColorGradingSettings(ref ColorGradingModel.Settings settings)
        {
            settings.basic.postExposure = _exposure.Value;
            settings.tonemapping.tonemapper = _tonemapper.Value;
        }

        private void OnDestroy()
        {
            _harmony?.UnpatchAll(ID);
        }

        public static void Log(string message)
        {
            Debug.Log($"{ID}: {message}");
        }
    }
}
