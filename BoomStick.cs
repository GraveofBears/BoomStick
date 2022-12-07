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
        private const string ModVersion = "0.0.8";
        private const string ModGUID = "org.bepinex.plugins.boomstick";

        public void Awake()
        {
            Item Odins_BoomStick = new Item("boomstick", "Odins_BoomStick", "Booms");
            Odins_BoomStick.Crafting.Add(CraftingTable.BlackForge, 1);
            Odins_BoomStick.Name.English("Odin's Boomstick");
            Odins_BoomStick.Description.English("This is my Boomstick!");
            Odins_BoomStick.RequiredItems.Add("BlackMarble", 4);
            Odins_BoomStick.RequiredItems.Add("YggdrasilWood", 4);
            Odins_BoomStick.RequiredUpgradeItems.Add("BlackMarble", 2);
            Odins_BoomStick.RequiredUpgradeItems.Add("YggdrasilWood", 2);
            Odins_BoomStick.Configurable = Configurability.Full;
            Odins_BoomStick.CraftAmount = 1;
            GameObject Odins_Boomshot_Pro = PrefabManager.RegisterPrefab("boomstick", "Odins_Boomshot_Pro");
            GameObject fx_boomshot_hit = PrefabManager.RegisterPrefab("boomstick", "fx_boomshot_hit");
            GameObject vfx_boomshot_fire = PrefabManager.RegisterPrefab("boomstick", "vfx_boomshot_fire");
            GameObject sfx_boomshot_fire = PrefabManager.RegisterPrefab("boomstick", "sfx_boomshot_fire");

        }
    }
}



