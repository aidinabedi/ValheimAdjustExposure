using HarmonyLib;
using UnityEngine.PostProcessing;

namespace ValheimAdjustExposure.GamePatches
{
    [HarmonyPatch(typeof(PostProcessingBehaviour), "OnPreCull")]
    static class PostProcessingBehaviour_OnPreCull_Patch
    {
        static void Postfix(ref ColorGradingComponent ___m_ColorGrading)
        {
            var settings = ___m_ColorGrading.model.settings;
            AdjustExposurePlugin.AdjustColorGradingSettings(ref settings);
            ___m_ColorGrading.model.settings = settings;
        }
    }
}
