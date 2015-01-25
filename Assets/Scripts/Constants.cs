using System;
using System.Collections.Generic;
using UnityEngine;

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

        static GameConstants()
        {
            ColorCodes = new Dictionary<GameObjectColor, Color>
            {
                {GameObjectColor.Blue,Color.blue},
                {GameObjectColor.Red,Color.red},
                {GameObjectColor.Yellow,Color.yellow}
            };
        }

        public static Dictionary<GameObjectColor, Color> ColorCodes { get; set; }

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
            Enemy,
            Food
        };

        static ObjectConstants()
        {
            PrefabNames = new Dictionary<Type, string>
            {
                {Type.Enemy,"Prefabs/GameObjects/Enemy"},
                {Type.Food,"Prefabs/GameObjects/Food"}
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

    public class SpriteConstants
    {
        private static readonly IDictionary<ObjectConstants.Type,string > _spriteNames = new Dictionary<ObjectConstants.Type, string>
		{
			{ObjectConstants.Type.Enemy, "Sprites/Enemy"},
			{ObjectConstants.Type.Food, "Sprites/Food"},
		};

        public static IDictionary<ObjectConstants.Type, string> SPRITE_NAMES { get { return _spriteNames; } }
    }

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