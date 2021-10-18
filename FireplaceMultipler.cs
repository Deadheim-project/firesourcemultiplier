using BepInEx;
using BepInEx.Configuration;
using HarmonyLib;

namespace FireplaceMultipler
{
    [BepInPlugin("Detalhes.FireplaceMultipler", "FireplaceMultipler", "1.0.2")]
    [BepInProcess("valheim.exe")]
    public class FireplaceMultipler : BaseUnityPlugin
    {
        public const string PluginGUID = "Detalhes.FireplaceMultipler";
        Harmony harmony = new Harmony(PluginGUID);

        public static ConfigEntry<int> multiplier;

        private void Awake()
        {
            multiplier = Config.Bind<int>("General", "Multiplier", 5, "Firesource multiplier");

            harmony.PatchAll();
        }      
    }
}
