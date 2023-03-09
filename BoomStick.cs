using System;
using System.IO;
using System.Linq;
using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
using ItemManager;
using ServerSync;
using UnityEngine;

namespace BoomStick
{
    [BepInPlugin(ModGUID, ModName, ModVersion)]
    public class BoomStick : BaseUnityPlugin
    {
        private const string ModName = "BoomStick";
        private const string ModVersion = "0.0.10";
        private const string ModGUID = "org.bepinex.plugins.boomstick";

        public void Awake()
        {
            Item Odins_BoomStick = new Item("boomstick", "Odins_BoomStick", "Booms");
            Odins_BoomStick.Crafting.Add(CraftingTable.BlackForge, 1);
            Odins_BoomStick.Name.English("Odins Boomstick");
            Odins_BoomStick.Description.English("This is my Boomstick!");
            Odins_BoomStick.RequiredItems.Add("BlackMarble", 4);
            Odins_BoomStick.RequiredItems.Add("YggdrasilWood", 4);
            Odins_BoomStick.RequiredUpgradeItems.Add("BlackMarble", 2);
            Odins_BoomStick.RequiredUpgradeItems.Add("YggdrasilWood", 2);
            Odins_BoomStick.Configurable = Configurability.Full;
            Odins_BoomStick.CraftAmount = 1;
            GameObject Odins_Boomshot_Pro = PrefabManager.RegisterPrefab("boomstick", "Odins_Boomshot_Pro");
            GameObject fx_boomshot_hit = PrefabManager.RegisterPrefab("boomstick", "fx_boomshot_hit");


            Item Odins_Boomstick_Classic = new Item("boomstick", "Odins_Boomstick_Classic", "Booms");
            Odins_Boomstick_Classic.Crafting.Add(CraftingTable.Forge, 3);
            Odins_Boomstick_Classic.Name.English("Odins Boomstick Classic");
            Odins_Boomstick_Classic.Description.English("A remake of the original Boomstick, this weapon requires Boomshot to fire");
            Odins_Boomstick_Classic.RequiredItems.Add("Iron", 4);
            Odins_Boomstick_Classic.RequiredItems.Add("FineWood", 4);
            Odins_Boomstick_Classic.RequiredUpgradeItems.Add("Iron", 2);
            Odins_Boomstick_Classic.RequiredUpgradeItems.Add("FineWood", 2);
            Odins_Boomstick_Classic.Configurable = Configurability.Full;
            Odins_Boomstick_Classic.CraftAmount = 1;

            Item Odins_Boomstick_Cannon = new Item("boomstick", "Odins_Boomstick_Cannon", "Booms");
            Odins_Boomstick_Cannon.Crafting.Add(CraftingTable.Forge, 3);
            Odins_Boomstick_Cannon.Name.English("Odins Boom Cannon");
            Odins_Boomstick_Cannon.Description.English("A hand cannon that fires boomshot");
            Odins_Boomstick_Cannon.RequiredItems.Add("Iron", 4);
            Odins_Boomstick_Cannon.RequiredItems.Add("FineWood", 4);
            Odins_Boomstick_Cannon.RequiredUpgradeItems.Add("Iron", 2);
            Odins_Boomstick_Cannon.RequiredUpgradeItems.Add("FineWood", 2);
            Odins_Boomstick_Cannon.Configurable = Configurability.Full;
            Odins_Boomstick_Cannon.CraftAmount = 1;

            //Item Odins_Boomstick_Rifle = new Item("boomstick", "Odins_Boomstick_Rifle", "Booms");
            //Odins_Boomstick_Rifle.Crafting.Add(CraftingTable.Forge, 3);
            //Odins_Boomstick_Rifle.Name.English("Odins Boomstick Rifle");
            //Odins_Boomstick_Rifle.Description.English("A fantasy rifle that fires boomshot");
            //Odins_Boomstick_Rifle.RequiredItems.Add("Iron", 4);
            //Odins_Boomstick_Rifle.RequiredItems.Add("FineWood", 4);
            //Odins_Boomstick_Rifle.RequiredUpgradeItems.Add("Iron", 2);
            //Odins_Boomstick_Rifle.RequiredUpgradeItems.Add("FineWood", 2);
            //Odins_Boomstick_Rifle.Configurable = Configurability.Full;
            //Odins_Boomstick_Rifle.CraftAmount = 1;

            Item Odins_Boomshot = new Item("boomstick", "Odins_Boomshot", "Booms");
            Odins_Boomshot.Crafting.Add(CraftingTable.Forge, 3);
            Odins_Boomshot.Name.English("Odins Boomshot");
            Odins_Boomshot.Description.English("A remake of the original boomshot, ammo for the boomstick weapons");
            Odins_Boomshot.RequiredItems.Add("Iron", 1);
            Odins_Boomshot.RequiredItems.Add("Coal", 1);
            Odins_Boomshot.RequiredItems.Add("Flint", 4);
            Odins_Boomshot.RequiredUpgradeItems.Add("Iron", 1);
            Odins_Boomshot.RequiredUpgradeItems.Add("Coal", 1);
            Odins_Boomshot.RequiredUpgradeItems.Add("Flint", 2);
            Odins_Boomshot.Configurable = Configurability.Full;
            Odins_Boomshot.CraftAmount = 25;


            GameObject Odins_Boomshot_Projectile = PrefabManager.RegisterPrefab("boomstick", "Odins_Boomshot_Projectile");


            GameObject vfx_boomshot_fire = PrefabManager.RegisterPrefab("boomstick", "vfx_boomshot_fire");
            GameObject sfx_boomshot_fire = PrefabManager.RegisterPrefab("boomstick", "sfx_boomshot_fire");

        }
    }
}



