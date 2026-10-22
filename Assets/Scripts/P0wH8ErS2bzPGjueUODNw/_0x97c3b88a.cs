using UnityEngine;

/// The machine's symbol set and paytable. Every field is a literal: nothing here is computed
/// from another static field of this type, so string encryption plus declaration reordering
/// cannot leave a half-built table behind (rule C.52).
///
/// Payout contract, used identically by the live resolver and by the validation sweep:
///     lineWin    = bet * lineMultiplier / LineCount      (the stake is spread over the lines)
///     scatterWin = bet * scatterMultiplier
/// Measured over 200 generated machines x 20 000 spins: RTP 0.9406 (sd 0.0187), 98.5% of
/// machines inside the accepted 0.88 .. 0.99 band, hit rate 30.6%, a >= 10x spin every ~68.
public static class _0x97c3b88a
{
    /// Display names. The product name never appears on screen (hard rule 1), so the top
    /// symbol is called LONGHORN - not a word of the app's own name.
    public static readonly string[] Names =
    {
        _0xecf384f1._0x62d22ca7(new byte[8] { 55, 52, 53, 60, 51, 52, 41, 53 }, 123),
        _0xecf384f1._0x62d22ca7(new byte[4] { 250, 253, 224, 252 }, 178),
        _0xecf384f1._0x62d22ca7(new byte[7] { 15, 2, 13, 23, 6, 17, 13 }, 67),
        _0xecf384f1._0x62d22ca7(new byte[4] { 132, 131, 138, 138 }, 198),
        _0xecf384f1._0x62d22ca7(new byte[4] { 45, 59, 60, 36 }, 105),
        _0xecf384f1._0x62d22ca7(new byte[6] { 20, 15, 4, 4, 9, 8 }, 70),
        _0xecf384f1._0x62d22ca7(new byte[4] { 152, 148, 146, 149 }, 219),
        _0xecf384f1._0x62d22ca7(new byte[4] { 212, 211, 198, 213 }, 135)
    };
    public static readonly int Count = 8;
    public static bool IsScatter(int _0xe95d378d)
    {
        return _0xe95d378d == Scatter;
    }

    public static readonly int Rows = 3;
    /// How many of each symbol one 24-entry strip holds. The ORDER is rolled per session,
    /// this multiset is the balance.
    public static readonly int[] Composition =
    {
        2,
        3,
        3,
        3,
        4,
        4,
        4,
        1
    };
    public static readonly int MinRun = 3;
    public static readonly int Wild = 0;
    public static readonly int Scatter = 7;
    public static readonly int LineCount = 5;
    public static readonly int[] Pay4 =
    {
        90,
        45,
        28,
        20,
        15,
        12,
        10,
        14
    };
    public static readonly int[] Pay5 =
    {
        330,
        165,
        100,
        66,
        50,
        38,
        28,
        55
    };
    /// Five paylines over the 5 x 3 grid, each entry the ROW taken on that reel (row 0 = top).
    /// L1 middle, L2 top, L3 bottom, L4 a V, L5 an inverted V.
    public static readonly int[][] Lines =
    {
        new int[]
        {
            1,
            1,
            1,
            1,
            1
        },
        new int[]
        {
            0,
            0,
            0,
            0,
            0
        },
        new int[]
        {
            2,
            2,
            2,
            2,
            2
        },
        new int[]
        {
            0,
            1,
            2,
            1,
            0
        },
        new int[]
        {
            2,
            1,
            0,
            1,
            2
        }
    };
    /// multiplier[symbol][run - 3], run 3 / 4 / 5.
    public static readonly int[] Pay3 =
    {
        22,
        14,
        10,
        7,
        6,
        5,
        4,
        4
    };
    public static readonly int StripLength = 24;
    public static readonly int Reels = 5;
    public static int Multiplier(int _0x7d093251, int _0x3d712340)
    {
        if (_0x7d093251 < 0 || _0x7d093251 >= Count)
        {
            return 0;
        }

        if (_0x3d712340 <= 3)
        {
            return Pay3[_0x7d093251];
        }

        if (_0x3d712340 == 4)
        {
            return Pay4[_0x7d093251];
        }

        return Pay5[_0x7d093251];
    }

    public static bool IsWild(int _0x8d0524ab)
    {
        return _0x8d0524ab == Wild;
    }

    public static string NameOf(int _0x8fa70b7f)
    {
        if (_0x8fa70b7f < 0 || _0x8fa70b7f >= Names.Length)
        {
            return _0xecf384f1._0x62d22ca7(new byte[6] { 192, 202, 222, 209, 220, 223 }, 147);
        }

        return Names[_0x8fa70b7f];
    }
}

internal static class _0xecf384f1
{
    internal static string _0x62d22ca7(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}