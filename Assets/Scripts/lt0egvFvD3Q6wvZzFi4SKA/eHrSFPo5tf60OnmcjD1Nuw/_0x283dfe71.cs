using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public static class _0x283dfe71
{
    public static class _0xf15fd126
    {
        public static readonly int SCENE_0 = 0;
        public static readonly int SCENE_1 = 1;
    }

    public static class _0x895c7d75
    {
        public static readonly int PAUSE = 6;
        public static readonly int WIN = 7;
        public static readonly int LOSE = 8;
    }

    public static class _0x7c26fac4
    {
        public static int _0xaf9e7d41
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x3aa7f40a._0x713c28f1(new byte[5] { 77, 97, 103, 96, 125 }, 14)))
                    PlayerPrefs.SetInt(_0x3aa7f40a._0x713c28f1(new byte[5] { 85, 121, 127, 120, 101 }, 22), 0);
                return PlayerPrefs.GetInt(_0x3aa7f40a._0x713c28f1(new byte[5] { 142, 162, 164, 163, 190 }, 205));
            }

            set
            {
                PlayerPrefs.SetInt(_0x3aa7f40a._0x713c28f1(new byte[5] { 214, 250, 252, 251, 230 }, 149), value);
                _0x19b9e3e8.Instance._0x765c4c36();
            }
        }
    }

    public static class _0x0485a4d3
    {
        public static readonly int SPLASH = 0;
        public static readonly int DEFAULT = 1;
        public static readonly int EMPTY = 2;
        public static readonly int TUTORIAL0 = 13;
        public static readonly int TUTORIAL1 = 14;
        public static readonly int TUTORIAL2 = 15;
        public static readonly int TUTORIAL3 = 16;
        public static readonly int TUTORIAL4 = 17;
        public static readonly int TUTORIAL5 = 18;
        public static readonly int TUTORIAL6 = 19;
    }

    public class _0x2bc4bf01
    {
        private static readonly _0x2bc4bf01 _0x6988f22b = new();
        public static readonly _0x2bc4bf01[] ALL_SCENES_SETTING_SINGLETONS =
        {
            _0x6988f22b,
            _0x6988f22b,
            _0x6988f22b,
        };
        private int _0x8805dbd7 => 0;
        private int _0x630f7a6a => 10;
        private string _0x9d94a2e5 => _0x3aa7f40a._0x713c28f1(new byte[4] { 57, 17, 26, 1 }, 116);
        private string _0x7fddc9b0 => _0x3aa7f40a._0x713c28f1(new byte[8] { 103, 110, 125, 110, 103, 80, 27, 86 }, 43);

        private int _0xefadc54f
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x3aa7f40a._0x713c28f1(new byte[25] { 4, 50, 53, 53, 34, 41, 51, 0, 43, 40, 37, 38, 43, 4, 47, 38, 55, 51, 34, 53, 14, 41, 35, 34, 63 }, 71)))
                    PlayerPrefs.SetInt(_0x3aa7f40a._0x713c28f1(new byte[25] { 16, 38, 33, 33, 54, 61, 39, 20, 63, 60, 49, 50, 63, 16, 59, 50, 35, 39, 54, 33, 26, 61, 55, 54, 43 }, 83), 0);
                return PlayerPrefs.GetInt(_0x3aa7f40a._0x713c28f1(new byte[25] { 89, 111, 104, 104, 127, 116, 110, 93, 118, 117, 120, 123, 118, 89, 114, 123, 106, 110, 127, 104, 83, 116, 126, 127, 98 }, 26));
            }

            set => PlayerPrefs.SetInt(_0x3aa7f40a._0x713c28f1(new byte[25] { 203, 253, 250, 250, 237, 230, 252, 207, 228, 231, 234, 233, 228, 203, 224, 233, 248, 252, 237, 250, 193, 230, 236, 237, 240 }, 136), value);
        }

        public int _0x06b4f889
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x9d94a2e5}CurrentLevelIndex"))
                    PlayerPrefs.SetInt($"{this._0x9d94a2e5}CurrentLevelIndex", 0);
                return PlayerPrefs.GetInt($"{this._0x9d94a2e5}CurrentLevelIndex");
            }

            set => PlayerPrefs.SetInt($"{this._0x9d94a2e5}CurrentLevelIndex", value);
        }

        public int _0x39d3d900
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x9d94a2e5}BestScore"))
                    this._0x39d3d900 = 0;
                return PlayerPrefs.GetInt($"{this._0x9d94a2e5}BestScore");
            }

            set => PlayerPrefs.SetInt($"{this._0x9d94a2e5}BestScore", value);
        }

        public bool _0x45897a57
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x9d94a2e5}IsGameTutorPassed"))
                    PlayerPrefs.SetInt($"{this._0x9d94a2e5}IsGameTutorPassed", Convert.ToInt32(false));
                return PlayerPrefs.GetInt($"{this._0x9d94a2e5}IsGameTutorPassed") == 1;
            }

            set => PlayerPrefs.SetInt($"{this._0x9d94a2e5}IsGameTutorPassed", Convert.ToInt32(value));
        }
    }
}

internal static class _0x3aa7f40a
{
    internal static string _0x713c28f1(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}