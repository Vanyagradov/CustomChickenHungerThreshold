using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;

namespace Vanyagradov_team.CustomChickenHungerThreshold;

[BepInAutoPlugin]
public partial class Plugin : BaseUnityPlugin
{
    internal static ManualLogSource Log { get; private set; } = null!;

    private ConfigEntry<float>? configHungerThreshold;

    private void Awake()
    {
        Log = Logger;

        configHungerThreshold = Config.Bind("General", "HungerThreshold", 0.6f, "Amount of hunger required to see other players as chickens");

        UIPlayerNames.CANNIBAL_HUNGER_THRESHOLD = configHungerThreshold.Value;

        Log.LogInfo($"Plugin {Name} is loaded!");
        Log.LogInfo($"Custom hunger threshold: {configHungerThreshold.Value}");
    }
}
