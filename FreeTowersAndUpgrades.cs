using BTD_Mod_Helper;
using FreeTowersAndUpgrades;
using Il2CppAssets.Scripts.Models;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Upgrades;
using MelonLoader;

[assembly: MelonInfo(typeof(FreeTowersAndUpgrades.FreeTowersAndUpgrades), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace FreeTowersAndUpgrades;

public class FreeTowersAndUpgrades : BloonsTD6Mod
{
    public override void OnTitleScreen()
    {
        MelonLogger.Msg("Towers and Upgrades are Free. Mod LOADED!");
    }

    // This is the correct and standard hook for modifying game data like costs.
    public override void OnGameModelLoaded(GameModel model)
    {
        // Set the base cost of all towers/heroes to 1.
        foreach (TowerModel towerModel in model.towers)
        {
            towerModel.cost = 1;
        }

        // Set the cost of all upgrades to 1.
        foreach (UpgradeModel upgrade in model.upgrades)
        {
            if (upgrade != null)
            {
                upgrade.cost = 1;
            }
        }
    }
}
