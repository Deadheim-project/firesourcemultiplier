using HarmonyLib;
using System;
using UnityEngine;

namespace FireplaceMultipler
{
    class Patches
    {
        [HarmonyPatch(typeof(Fireplace), "Awake")]
        public static class ConsumePatch
        {
            private static void Prefix(Fireplace __instance)
            {
                __instance.m_maxFuel *= FireplaceMultipler.multiplier.Value;
            }      
        }
    }
}
