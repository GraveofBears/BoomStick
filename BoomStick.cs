using BepInEx;
using ItemManager;
using ServerSync;
using UnityEngine;

namespace BoomStick
{
    [BepInPlugin(ModGUID, ModName, ModVersion)]
    public class BoomStick : BaseUnityPlugin
    {
        private const string ModName = "BoomStick";
        private const string ModVersion = "0.0.5";
        private const string ModGUID = "org.bepinex.plugins.boomstick";

        public void Awake()
        {
            Item BoomStick = new Item("boomstick", "BoomStick", "Booms");
            BoomStick.Crafting.Add(CraftingTable.Forge, 3);
            BoomStick.RequiredItems.Add("BlackMetal", 14);
            BoomStick.RequiredItems.Add("RoundLog", 4);
            BoomStick.RequiredItems.Add("Wood", 8);
            BoomStick.RequiredUpgradeItems.Add("BlackMetal", 12);
            BoomStick.RequiredUpgradeItems.Add("RoundLog", 2);
            BoomStick.RequiredUpgradeItems.Add("Wood", 2);
            BoomStick.Configurable = Configurability.Full;
            BoomStick.CraftAmount = 1;

            Item BoomShot = new Item("boomstick", "BoomShot", "Booms");
            BoomShot.Crafting.Add(CraftingTable.Forge, 3);
            BoomShot.RequiredItems.Add("Tin", 4);
            BoomShot.RequiredItems.Add("Tar", 2);
            BoomShot.RequiredItems.Add("Ooze", 2);
            BoomShot.Configurable = Configurability.Full;
            BoomShot.CraftAmount = 25;

            GameObject boomboom_projectile = PrefabManager.RegisterPrefab("boomstick", "boomboom_projectile");

        }
    }
}



