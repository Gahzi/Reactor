using System.Collections.Generic;

namespace Assets.Scripts
{ //	public enum Team { Red = 0, Blue = 1, None = 2 };
//	
//	public enum PlayerMode { Player = 0, Spectator = 1 };
//	public enum PlayerType { mech, drone, tank, core };

    public class StringConstants
    {
        //		public static readonly string mechPrefix = "MCH.";
        //		public static readonly string tankPrefix = "TNK.";
        //		public static readonly string hunterPrefix = "HTR.";
        //		
        //		public static readonly string mech0Name = "ASLT";
        //		public static readonly string mech1Name = "PLSR";
        //		public static readonly string mech2Name = "LONG";
        //		
        //		public static readonly string tank0Name = "HEAT";
        //		public static readonly string tank1Name = "DRVR";
        //		public static readonly string tank2Name = "TRAP";
        //		
        //		public static readonly string hunter0Name = "BRST";
        //		public static readonly string hunter1Name = "RCPX";
        //		public static readonly string hunter2Name = "PLSR";

    }

    public class GameConstants
    {
        public enum GameObjectColor
        {
            Red,
            Blue,
            Yellow
        }

        public static readonly float NewObjectMinDistance = 0.05f;
        //		public static readonly float pregameTime = 30.0f;
        //		public static readonly int maxGameTimeCapturePoint = 60 * 3;
        //		public static readonly int maxGameTimeDeathmatch = 60 * 3;
        //		public static readonly int maxScoreDeathmatch = 30;
        //		public static readonly int masScoreCapturePoint = 100;
        //		public static readonly int maxGameTimeDataPulse = 60 * 3;
        //		public static readonly int dataPulsePeriod = 60;
        //		public static readonly int pointObjectDecayPeriod = 5;
        //		public static readonly int pointObjectDecayPercentPerPeriod = 0;
        //		public static readonly float pointPercentDropOnDeath = 1.0f;
        //		public static readonly int levelOneThreshold = 5;
        //		public static readonly int levelTwoThreshold = 29;
        //		public static readonly int decalLifetime = 10;
        //		public static readonly int explosionChaffAmount = 3; // Amount of chaff is this value ^ 3
        //		public static readonly int explosionParticleAmount = 5000;
        //		public static readonly int defaultAOElifetime = 1;
    }

    public class ObjectConstants
    {
        public enum Type
        {
            Floor
        };

        static ObjectConstants()
        {
            PrefabNames = new Dictionary<Type, string>
            {
                {Type.Floor,"Prefabs/GameObjects/Floor"}
//			{type.Spectator, "Characters/SpectatorLocal"},
//			{type.Gamepad, "Gamepads/Gamepad"},
//			{type.Item, "Items/Item"},
//			{type.PlayerCamera, "Cameras/Player Camera"},
//			{type.PlasmaBulletLevel0, "Abilities/bullet/PlasmaBulletl0"},
//			{type.PlasmaBulletLevel1, "Abilities/bullet/PlasmaBulletl1"},
//			{type.PlasmaBulletLevel2, "Abilities/bullet/PlasmaBulletl2"},
//			{type.BasicRigidbodyCube, "Environment/BasicRigidbodyCube"},
//			{type.MachinegunBulletLevel0, "Abilities/bullet/machinegunbulletl0"},
//			{type.MachinegunBulletLevel1, "Abilities/bullet/machinegunbulletl1"},
//			{type.MachinegunBulletLevel2, "Abilities/bullet/machinegunbulletl2"},
//			{type.RocketBulletLevel0, "abilities/bullet/rocketbulletl0"},
//			{type.RocketBulletLevel1, "abilities/bullet/rocketbulletl1"},
//			{type.RocketBulletLevel2, "abilities/bullet/rocketbulletl2"},
//			{type.KillTagBlue, "items/killtagblue"},
//			{type.KillTagRed, "items/killtagred"},
//			{type.LightAutoLaserBullet, "abilities/bullet/lightautolaserbullet"},
//			{type.SmallExplosion, "abilities/explosion/smallexplosion"},
//			{type.RocketExplosion, "abilities/explosion/rocketexplosion"},
//			{type.NoDamageExplosionMedium, "abilities/explosion/mediumexplosion"},
//			{type.PlasmaExplosionL0, "abilities/explosion/plasmaexplosionl0"},
//			{type.PlasmaExplosionL1, "abilities/explosion/plasmaexplosionl1"},
//			{type.PlasmaExplosionL2, "abilities/explosion/plasmaexplosionl2"},
//			
//			{type.FloatingText, "gui/floatingtext"},
//			{type.HeavyCannonBulletLevel0, "abilities/bullet/heavycannonbulletl0"},
//			{type.HeavyCannonBulletLevel1, "abilities/bullet/heavycannonbulletl1"},
//			{type.HeavyCannonBulletLevel2, "abilities/bullet/heavycannonbulletl2"},
//			{type.LightCannonBulletLevel0, "abilities/bullet/lightcannonbulletl0"},
//			{type.LightCannonBulletLevel1, "abilities/bullet/lightcannonbulletl1"},
//			{type.LightCannonBulletLevel2, "abilities/bullet/lightcannonbulletl2"},
//			{type.ShotgunLevel0, "abilities/bullet/shotgunbulletl0"},
//			{type.ShotgunLevel1, "abilities/bullet/shotgunbulletl1"},
//			{type.ShotgunLevel2, "abilities/bullet/shotgunbulletl2"},
//			{type.HomingRocketL0, "abilities/bullet/homingrocketbulletl0"},
//			{type.MachineGunShellCasing, "abilities/machinegunshellcasing"},
//			{type.HCannonShellCasing, "abilities/HCannonShellCasing"},
//			{type.SniperShellCasing, "abilities/snipershellcasing"},
//			{type.SniperBulletLevel0, "abilities/bullet/sniperbulletl0"},
//			{type.SniperBulletLevel1, "abilities/bullet/sniperbulletl1"},
//			{type.SniperBulletLevel2, "abilities/bullet/sniperbulletl2"},
//			{type.RailgunBulletLevel0, "abilities/bullet/railgunbulletl0"},
//			{type.RailgunBulletLevel1, "abilities/bullet/railgunbulletl1"},
//			{type.RailgunBulletLevel2, "abilities/bullet/railgunbulletl2"},
//			{type.MineLevel0, "abilities/bullet/minebulletl0"},
//			{type.MineLevel1, "abilities/bullet/minebulletl1"},
//			{type.MineLevel2, "abilities/bullet/minebulletl2"},
            };
        }

        public static IDictionary<Type, string> PrefabNames { get; private set; }
    }

    public class ManagerConstants
    {
        public enum Type { GameManager, AudioManager, TouchManager };

        private static readonly IDictionary<Type, string> PrefabNamesDictionary = new Dictionary<Type, string>
        {
            {Type.GameManager,"Prefabs/Managers/GameManager"},
            {Type.AudioManager, "Prefabs/Managers/AudioManager"}
        };

        public static IDictionary<Type, string> PrefabNames { get { return PrefabNamesDictionary; } }

        private static readonly IDictionary<Type, string> PrefabTagsDictionary = new Dictionary<Type, string>
        {
            {Type.GameManager,"GameManager"},
            {Type.AudioManager, "AudioManager"}
        };

        public static IDictionary<Type, string> PrefabTags { get { return PrefabTagsDictionary; } }
    }

//	public class MaterialConstants
//	{
//		public enum type { ItemCommon, ItemUncommon, ItemRare, ItemLegendary, CoreBlue, CoreRed };
//		
//		private static readonly IDictionary<type, string> materialNames = new Dictionary<type, string>
//		{
//			{type.ItemCommon, "Materials/Visual/Items/ItemCommon"},
//			{type.ItemUncommon, "Materials/Visual/Items/ItemUncommon"},
//			{type.ItemRare, "Materials/Visual/Items/ItemRare"},
//			{type.ItemLegendary, "Materials/Visual/Items/ItemLegendary"},
//			{type.CoreBlue, "Materials/Visual/Core/CoreBlueMaterial"},
//			{type.CoreRed, "Materials/Visual/Core/CoreRedMaterial"}
//		};
//		
//		public static IDictionary<type, string> MATERIAL_NAMES { get { return materialNames; } }
//	}

    public class AudioConstants
    {
        public enum Clip
        {
            //			ItemPickup01,
            //			PlasmaGunFire01,
            //			PlasmaGunFire02,
            //			MachineGunFire01,
            //			MachineGunFire02,
            //			LightCannonFire01,
            //			LightCannonFire02,
            //			LightCannonFire03,
            //			CannonFire01,
            //			CannonFire02,
            //			CannonFire03,
            //			CannonFire04,
            //			CannonFire05,
            //			CannonReload01,
            //			HitConfirm,
            //			MachineGunReload01, MachineGunReload02,
            //			RocketFire01,
            //			PlasmaReload01,
            //			SniperFire01,
            //			MineFire01, MineFire02
        };

        private static readonly IDictionary<Clip, string> ClipNamesDictionary = new Dictionary<Clip, string>();

        public static IDictionary<Clip, string> ClipNames { get { return ClipNamesDictionary; } }

        public enum Music
        {
            SpacepeopleFull
        };

        static AudioConstants()
        {
            MusicNames = new Dictionary<Music, string>
            {
                //			{clip.PlasmaGunFire01, "sounds/cyberstorm select/gun single shots/subgun-04"},
                //			{clip.PlasmaGunFire02, "sounds/cyberstorm select/gun single shots/subgun-05"},            
                //			{clip.HitConfirm, "sounds/hitmarker"},
                //			{clip.MachineGunFire01, "sounds/cyberstorm select/cuts/machinegun_double_01"},
                //			{clip.MachineGunFire02, "sounds/cyberstorm select/cuts/machinegun_triple_01"},
                //			{clip.RocketFire01, "sounds/cyberstorm select/gun single shots/rocket-07"},
                //			{clip.MachineGunReload01, "sounds/cyberstorm select/reload/machine-sequence-03"},
                //			{clip.MachineGunReload02, "sounds/cyberstorm select/reload/zm_audio_reload_01"},
                //			{clip.PlasmaReload01, "sounds/cyberstorm select/reload/tr_2-reployservo-01"},
                //			{clip.ItemPickup01, "sounds/cyberstorm select/item attach/interface-servos-06"},
                //			{clip.LightCannonFire01, "sounds/cyberstorm select/cuts/laserfire_01"},
                //			{clip.CannonFire01, "sounds/cyberstorm select/gun single shots/subgun-16"},
                //			{clip.CannonFire02, "sounds/cyberstorm select/gun single shots/subgun-17"},
                //			{clip.CannonFire03, "sounds/cyberstorm select/gun single shots/subgun-18"},
                //			{clip.CannonFire04, "sounds/cyberstorm select/gun single shots/subgun-19"},
                //			{clip.CannonFire05, "sounds/cyberstorm select/gun single shots/subgun-20"},
                //			{clip.SniperFire01, "sounds/cyberstorm select/gun single shots/artillery-21"},
                //			{clip.MineFire01, "sounds/cyberstorm select/cuts/mine_single_01"},
                //			{clip.MineFire02, "sounds/cyberstorm select/cuts/mine_single_02"}
            };
        }

        public static IDictionary<Music, string> MusicNames { get; private set; }
    }
}