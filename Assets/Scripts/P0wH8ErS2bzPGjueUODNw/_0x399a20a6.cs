using System.Collections.Generic;
using UnityEngine;

/// Everything that outlives a scene: the purse, the bet ladder, the emblem album, the daily
/// objectives and the chosen festival scene. A plain static holder, so there is no singleton
/// to assign in Awake and no ordering to get wrong (rule C.59) - callers open with
/// EnsureReady(), which is idempotent.
///
/// Coins live in the template's own store (SETTINGS.PlayerSYSTEM.Coins), so the template's
/// MoneyCount readouts stay correct; everything else is PlayerPrefs.
public static class _0x399a20a6
{
    // ── daily objectives ─────────────────────────────────────────────────────
    public static List<_0xc2530753> Challenges()
    {
        EnsureReady();
        return _0x00163818;
    }

    public static bool ChooseScene(int _0xd276a662)
    {
        EnsureReady();
        if (_0xd276a662 < 0 || _0xd276a662 >= SceneCount || !SceneUnlocked(_0xd276a662))
        {
            return false;
        }

        _0xd2376c93 = _0xd276a662;
        PlayerPrefs.SetInt(_0xf7f73be6, _0xd2376c93);
        return true;
    }

    public static void Advance(int _0x69f42b5e, int _0x551e0536)
    {
        EnsureReady();
        if (_0x551e0536 <= 0)
        {
            return;
        }

        for (int _0x347bb8af = 0; _0x347bb8af < _0x00163818.Count; _0x347bb8af++)
        {
            _0xc2530753 _0xe2b1490e = _0x00163818[_0x347bb8af];
            if (_0xe2b1490e.Kind != _0x69f42b5e || _0xe2b1490e.Claimed)
            {
                continue;
            }

            _0xe2b1490e.Progress = Mathf.Min(_0xe2b1490e.Progress + _0x551e0536, _0xe2b1490e.Target);
            PlayerPrefs.SetInt(_0xd5b6fe89 + _0xe2b1490e.Slot + _0x5c078a1f._0xee25aacb(new byte[1] { 172 }, 252), _0xe2b1490e.Progress);
        }
    }

    public static readonly long FundGrant = 1000L;
    private static readonly string _0x7743782b = _0x5c078a1f._0xee25aacb(new byte[12] { 123, 88, 78, 73, 127, 88, 73, 116, 83, 89, 88, 69 }, 61);
    public static bool Vibrate()
    {
        EnsureReady();
        return _0xe7b73ec3;
    }

    // ── emblem album ─────────────────────────────────────────────────────────
    public static int AlbumCount(int _0x38b9042e)
    {
        EnsureReady();
        if (_0x38b9042e < 0 || _0x38b9042e >= _0x4f7cafa9.Length)
        {
            return 0;
        }

        return _0x4f7cafa9[_0x38b9042e];
    }

    public static void Reach(int _0x40d9aee7, int _0x3b41ffaa)
    {
        EnsureReady();
        for (int _0x9cf9f587 = 0; _0x9cf9f587 < _0x00163818.Count; _0x9cf9f587++)
        {
            _0xc2530753 _0x891aae36 = _0x00163818[_0x9cf9f587];
            if (_0x891aae36.Kind != _0x40d9aee7 || _0x891aae36.Claimed || _0x3b41ffaa <= _0x891aae36.Progress)
            {
                continue;
            }

            _0x891aae36.Progress = Mathf.Min(_0x3b41ffaa, _0x891aae36.Target);
            PlayerPrefs.SetInt(_0xd5b6fe89 + _0x891aae36.Slot + _0x5c078a1f._0xee25aacb(new byte[1] { 134 }, 214), _0x891aae36.Progress);
        }
    }

    public static bool SceneUnlocked(int _0x5ab1520a)
    {
        EnsureReady();
        if (_0x5ab1520a <= 0)
        {
            return true;
        }

        return AlbumCount(_0x97c3b88a.Wild) >= SceneUnlockEmblems * _0x5ab1520a;
    }

    private static int RollTarget(int _0xc696a289, System.Random _0x010b9f76)
    {
        if (_0xc696a289 == _0xc2530753.KindSpins)
        {
            return 20 + _0x010b9f76.Next(41);
        }

        if (_0xc696a289 == _0xc2530753.KindLanterns || _0xc696a289 == _0xc2530753.KindBells)
        {
            return 6 + _0x010b9f76.Next(13);
        }

        if (_0xc696a289 == _0xc2530753.KindLonghorns)
        {
            return 2 + _0x010b9f76.Next(5);
        }

        if (_0xc696a289 == _0xc2530753.KindCoinsWon)
        {
            return 500 + (_0x010b9f76.Next(26) * 100);
        }

        if (_0xc696a289 == _0xc2530753.KindPaylines)
        {
            return 5 + _0x010b9f76.Next(11);
        }

        if (_0xc696a289 == _0xc2530753.KindFourOfAKind)
        {
            return 1 + _0x010b9f76.Next(2);
        }

        if (_0xc696a289 == _0xc2530753.KindScatters)
        {
            return 3 + _0x010b9f76.Next(7);
        }

        return 6000 + (_0x010b9f76.Next(31) * 100);
    }

    public static bool CanAffordBet()
    {
        return Purse() >= Bet();
    }

    private static int _0x32ce6e08;
    private static readonly string _0xf8e12fc9 = _0x5c078a1f._0xee25aacb(new byte[11] { 0, 35, 53, 50, 16, 47, 36, 52, 39, 50, 35 }, 70);
    public static int SpinIndex()
    {
        EnsureReady();
        return _0xf5596a99;
    }

    /// The Festival Fund: free, unlimited, no purchase path of any kind. It is what makes the
    /// run unbounded, which is what rule C.5 asks of a game with no timer.
    public static void GrantFund()
    {
        EnsureReady();
        SetPurse(Purse() + FundGrant);
    }

    private static readonly string _0xd5b6fe89 = _0x5c078a1f._0xee25aacb(new byte[8] { 238, 205, 219, 220, 235, 192, 201, 196 }, 168);
    public static long Bet()
    {
        EnsureReady();
        return BetLadder[Mathf.Clamp(_0x32ce6e08, 0, BetLadder.Length - 1)];
    }

    public static readonly int DefaultBetIndex = 1;
    // ── festival scene and preferences ───────────────────────────────────────
    public static int FestivalScene()
    {
        EnsureReady();
        return _0xd2376c93;
    }

    /// Three of nine archetypes, drawn from a DAY-seeded generator so every player sees the
    /// same set on the same day and a different set tomorrow.
    private static void RollChallenges(bool _0x6a981819)
    {
        System.Random _0x57159b52 = new System.Random((_0x3bc681dc * 7919) ^ 0x5BD1);
        List<int> _0x482df15c = new List<int>();
        for (int _0x7083d039 = 0; _0x7083d039 < _0xc2530753.KindCount; _0x7083d039++)
        {
            _0x482df15c.Add(_0x7083d039);
        }

        for (int _0x48553120 = _0x482df15c.Count - 1; _0x48553120 > 0; _0x48553120--)
        {
            int _0xb7bedb3d = _0x57159b52.Next(_0x48553120 + 1);
            int _0x9f46ec7d = _0x482df15c[_0x48553120];
            _0x482df15c[_0x48553120] = _0x482df15c[_0xb7bedb3d];
            _0x482df15c[_0xb7bedb3d] = _0x9f46ec7d;
        }

        _0x00163818.Clear();
        for (int _0xd7aba75d = 0; _0xd7aba75d < 3; _0xd7aba75d++)
        {
            int _0xd1aaf99e = _0x482df15c[_0xd7aba75d];
            int _0x0be10285 = RollTarget(_0xd1aaf99e, _0x57159b52);
            int _0x63485662 = RollReward(_0xd1aaf99e, _0x0be10285);
            _0xc2530753 _0xb10600fe = new _0xc2530753()._0x36099326(_0xd7aba75d, _0xd1aaf99e, _0x0be10285, _0x63485662);
            if (!_0x6a981819)
            {
                _0xb10600fe.Progress = PlayerPrefs.GetInt(_0xd5b6fe89 + _0xd7aba75d + _0x5c078a1f._0xee25aacb(new byte[1] { 37 }, 117), 0);
                _0xb10600fe.Claimed = PlayerPrefs.GetInt(_0xd5b6fe89 + _0xd7aba75d + _0x5c078a1f._0xee25aacb(new byte[1] { 148 }, 215), 0) == 1;
            }
            else
            {
                PlayerPrefs.SetInt(_0xd5b6fe89 + _0xd7aba75d + _0x5c078a1f._0xee25aacb(new byte[1] { 144 }, 192), 0);
                PlayerPrefs.SetInt(_0xd5b6fe89 + _0xd7aba75d + _0x5c078a1f._0xee25aacb(new byte[1] { 251 }, 184), 0);
            }

            _0x00163818.Add(_0xb10600fe);
        }
    }

    public static _0xc2530753 Headline()
    {
        EnsureReady();
        for (int _0x17ba693f = 0; _0x17ba693f < _0x00163818.Count; _0x17ba693f++)
        {
            if (!_0x00163818[_0x17ba693f].Claimed)
            {
                return _0x00163818[_0x17ba693f];
            }
        }

        return _0x00163818.Count > 0 ? _0x00163818[0] : null;
    }

    public static readonly long[] BetLadder =
    {
        20L,
        50L,
        100L,
        250L,
        500L
    };
    public static void SetPurse(long _0x829febb1)
    {
        EnsureReady();
        long _0x88e2c0ce = _0x829febb1 < 0L ? 0L : _0x829febb1;
        _0x283dfe71._0x7c26fac4._0xaf9e7d41 = (int)_0x88e2c0ce;
    }

    private static bool _0xe7b73ec3;
    private static readonly string _0xc2cffa54 = _0x5c078a1f._0xee25aacb(new byte[10] { 123, 88, 78, 73, 110, 88, 88, 89, 88, 89 }, 61);
    public static readonly string[] SceneNames =
    {
        _0x5c078a1f._0xee25aacb(new byte[11] { 110, 126, 99, 98, 118, 105, 12, 100, 109, 96, 96 }, 44),
        _0x5c078a1f._0xee25aacb(new byte[13] { 12, 29, 6, 2, 28, 0, 1, 111, 1, 6, 8, 7, 27 }, 79),
        _0x5c078a1f._0xee25aacb(new byte[15] { 166, 174, 173, 165, 193, 177, 179, 174, 162, 164, 178, 178, 168, 174, 175 }, 225)
    };
    public static void ResetProgress()
    {
        EnsureReady();
        for (int _0x0920e83f = 0; _0x0920e83f < _0x4f7cafa9.Length; _0x0920e83f++)
        {
            _0x4f7cafa9[_0x0920e83f] = 0;
            PlayerPrefs.SetInt(_0xa7f2ba48 + _0x0920e83f, 0);
        }

        for (int _0x93395ce8 = 0; _0x93395ce8 < 3; _0x93395ce8++)
        {
            PlayerPrefs.SetInt(_0xd5b6fe89 + _0x93395ce8 + _0x5c078a1f._0xee25aacb(new byte[1] { 245 }, 165), 0);
            PlayerPrefs.SetInt(_0xd5b6fe89 + _0x93395ce8 + _0x5c078a1f._0xee25aacb(new byte[1] { 93 }, 30), 0);
        }

        for (int _0x0339354e = 0; _0x0339354e < _0x00163818.Count; _0x0339354e++)
        {
            _0x00163818[_0x0339354e].Progress = 0;
            _0x00163818[_0x0339354e].Claimed = false;
        }

        _0x32ce6e08 = DefaultBetIndex;
        PlayerPrefs.SetInt(_0x7743782b, _0x32ce6e08);
        _0xd2376c93 = 0;
        PlayerPrefs.SetInt(_0xf7f73be6, 0);
        SetPurse(WelcomePurse);
    }

    private static int _0x3bc681dc;
    public static int NextSpinSeed()
    {
        EnsureReady();
        _0xf5596a99++;
        return (_0xe6fb7650 * 7919) ^ (_0xf5596a99 * 104729);
    }

    public static int AlbumUnlocked()
    {
        EnsureReady();
        int _0xda5820c6 = 0;
        for (int _0xc1be6a31 = 0; _0xc1be6a31 < _0x4f7cafa9.Length; _0xc1be6a31++)
        {
            if (_0x4f7cafa9[_0xc1be6a31] > 0)
            {
                _0xda5820c6++;
            }
        }

        return _0xda5820c6;
    }

    private static int _0xf5596a99;
    public static int BetIndex()
    {
        EnsureReady();
        return _0x32ce6e08;
    }

    private static bool _0x43d14e36;
    public static bool AllClaimed()
    {
        EnsureReady();
        for (int _0x10aa5c6f = 0; _0x10aa5c6f < _0x00163818.Count; _0x10aa5c6f++)
        {
            if (!_0x00163818[_0x10aa5c6f].Claimed)
            {
                return false;
            }
        }

        return _0x00163818.Count > 0;
    }

    private static int _0xe6fb7650;
    private static readonly string _0x3d5b6c73 = _0x5c078a1f._0xee25aacb(new byte[12] { 101, 70, 80, 87, 103, 66, 90, 106, 77, 71, 70, 91 }, 35);
    private static readonly string _0xf7f73be6 = _0x5c078a1f._0xee25aacb(new byte[9] { 79, 108, 122, 125, 90, 106, 108, 103, 108 }, 9);
    private static List<_0xc2530753> _0x00163818;
    public static bool StepBet(int _0x8edf1118)
    {
        EnsureReady();
        int _0x11d9ec93 = Mathf.Clamp(_0x32ce6e08 + _0x8edf1118, 0, BetLadder.Length - 1);
        if (_0x11d9ec93 == _0x32ce6e08)
        {
            return false;
        }

        _0x32ce6e08 = _0x11d9ec93;
        PlayerPrefs.SetInt(_0x7743782b, _0x32ce6e08);
        return true;
    }

    private static int[] _0x4f7cafa9;
    private static int RollReward(int _0x8ff0c731, int _0x52883e69)
    {
        if (_0x8ff0c731 == _0xc2530753.KindCoinsWon || _0x8ff0c731 == _0xc2530753.KindPurse)
        {
            return 400 + (_0x52883e69 / 10);
        }

        return 250 + (_0x52883e69 * 25);
    }

    private static int _0xd2376c93;
    public static void EnsureReady()
    {
        if (_0x43d14e36)
        {
            return;
        }

        _0x43d14e36 = true;
        _0xe6fb7650 = (int)(System.DateTime.UtcNow.Ticks & 0x7FFFFFFF);
        _0xf5596a99 = 0;
        _0x4f7cafa9 = new int[_0x97c3b88a.Count];
        _0x00163818 = new List<_0xc2530753>();
        if (PlayerPrefs.GetInt(_0xc2cffa54, 0) == 0)
        {
            PlayerPrefs.SetInt(_0xc2cffa54, 1);
            _0x283dfe71._0x7c26fac4._0xaf9e7d41 = (int)WelcomePurse;
        }

        _0x32ce6e08 = Mathf.Clamp(PlayerPrefs.GetInt(_0x7743782b, DefaultBetIndex), 0, BetLadder.Length - 1);
        _0xd2376c93 = Mathf.Clamp(PlayerPrefs.GetInt(_0xf7f73be6, 0), 0, SceneCount - 1);
        _0xe7b73ec3 = PlayerPrefs.GetInt(_0xf8e12fc9, 1) == 1;
        for (int _0xf014669d = 0; _0xf014669d < _0x97c3b88a.Count; _0xf014669d++)
        {
            _0x4f7cafa9[_0xf014669d] = PlayerPrefs.GetInt(_0xa7f2ba48 + _0xf014669d, 0);
        }

        _0x3bc681dc = (int)(System.DateTime.UtcNow.Ticks / System.TimeSpan.TicksPerDay);
        bool _0xcd4a0a0a = PlayerPrefs.GetInt(_0x3d5b6c73, -1) != _0x3bc681dc;
        if (_0xcd4a0a0a)
        {
            PlayerPrefs.SetInt(_0x3d5b6c73, _0x3bc681dc);
        }

        RollChallenges(_0xcd4a0a0a);
        {
#if B_LOGS
            {
                Debug.Log($"[session] seed={_0xe6fb7650} day={_0x3bc681dc} purse={_0x283dfe71._0x7c26fac4._0xaf9e7d41} bet={Bet()}");
            }
#endif
        }
    }

    public static void StampAlbum(int _0xba867ce5, int _0x849edc6d)
    {
        EnsureReady();
        if (_0xba867ce5 < 0 || _0xba867ce5 >= _0x4f7cafa9.Length || _0x849edc6d <= 0)
        {
            return;
        }

        _0x4f7cafa9[_0xba867ce5] = _0x4f7cafa9[_0xba867ce5] + _0x849edc6d;
        PlayerPrefs.SetInt(_0xa7f2ba48 + _0xba867ce5, _0x4f7cafa9[_0xba867ce5]);
    }

    public static void SetVibrate(bool _0xf48f550c)
    {
        EnsureReady();
        _0xe7b73ec3 = _0xf48f550c;
        PlayerPrefs.SetInt(_0xf8e12fc9, _0xf48f550c ? 1 : 0);
    }

    public static readonly int SceneUnlockEmblems = 10;
    public static bool Claim(int _0xfd3a036f)
    {
        EnsureReady();
        for (int _0x092ae3a7 = 0; _0x092ae3a7 < _0x00163818.Count; _0x092ae3a7++)
        {
            _0xc2530753 _0x1a213179 = _0x00163818[_0x092ae3a7];
            if (_0x1a213179.Slot != _0xfd3a036f || _0x1a213179.Claimed || !_0x1a213179._0xc1a984ce())
            {
                continue;
            }

            _0x1a213179.Claimed = true;
            PlayerPrefs.SetInt(_0xd5b6fe89 + _0xfd3a036f + _0x5c078a1f._0xee25aacb(new byte[1] { 141 }, 206), 1);
            SetPurse(Purse() + _0x1a213179.Reward);
            return true;
        }

        return false;
    }

    public static readonly long WelcomePurse = 5000L;
    // ── purse and bet ────────────────────────────────────────────────────────
    public static long Purse()
    {
        EnsureReady();
        return _0x283dfe71._0x7c26fac4._0xaf9e7d41;
    }

    public static readonly int SceneCount = 3;
    // ── per-spin seeding (rule C.11) ─────────────────────────────────────────
    public static int SessionSeed()
    {
        EnsureReady();
        return _0xe6fb7650;
    }

    private static readonly string _0xa7f2ba48 = _0x5c078a1f._0xee25aacb(new byte[9] { 84, 119, 97, 102, 83, 126, 112, 103, 127 }, 18);
}

internal static class _0x5c078a1f
{
    internal static string _0xee25aacb(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}