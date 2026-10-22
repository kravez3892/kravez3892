using UnityEngine;

/// One daily objective. No constructor (rule C.59) - field initialisers plus an Init that
/// returns the object.
public sealed class _0xc2530753
{
    public static readonly int KindBells = 2;
    public static readonly int KindLonghorns = 3;
    public static readonly int KindLanterns = 1;
    public int Kind;
    public static readonly int KindCoinsWon = 4;
    public bool _0xc1a984ce()
    {
        return this.Progress >= this.Target;
    }

    public static readonly int KindScatters = 7;
    public int Reward;
    public static readonly int KindFourOfAKind = 6;
    public static readonly int KindSpins = 0;
    public _0xc2530753 _0x36099326(int _0x103c2979, int _0x5f8a2ae9, int _0x68175909, int _0x161fe8b4)
    {
        this.Slot = _0x103c2979;
        this.Kind = _0x5f8a2ae9;
        this.Target = _0x68175909;
        this.Reward = _0x161fe8b4;
        this.Progress = 0;
        this.Claimed = false;
        return this;
    }

    /// Two hand-placed lines: the engine never decides where a caption breaks (rule C.10).
    public string _0x31eab4b1()
    {
        if (this.Kind == KindSpins)
        {
            return _0xfa24e378._0xc32cf24f(new byte[15] { 239, 236, 245, 242, 156, 232, 244, 249, 156, 238, 249, 249, 240, 239, 182 }, 188) + this.Target + _0xfa24e378._0xc32cf24f(new byte[6] { 101, 17, 12, 8, 0, 22 }, 69);
        }

        if (this.Kind == KindLanterns)
        {
            return _0xfa24e378._0xc32cf24f(new byte[5] { 164, 169, 166, 172, 200 }, 232) + this.Target + _0xfa24e378._0xc32cf24f(new byte[30] { 46, 66, 79, 64, 90, 75, 92, 64, 93, 4, 79, 64, 87, 89, 70, 75, 92, 75, 46, 65, 64, 46, 90, 70, 75, 46, 73, 92, 71, 74 }, 14);
        }

        if (this.Kind == KindBells)
        {
            return _0xfa24e378._0xc32cf24f(new byte[5] { 168, 165, 170, 160, 196 }, 228) + this.Target + _0xfa24e378._0xc32cf24f(new byte[27] { 42, 72, 79, 70, 70, 89, 0, 75, 68, 83, 93, 66, 79, 88, 79, 42, 69, 68, 42, 94, 66, 79, 42, 77, 88, 67, 78 }, 10);
        }

        if (this.Kind == KindLonghorns)
        {
            return _0xfa24e378._0xc32cf24f(new byte[5] { 100, 105, 102, 108, 8 }, 40) + this.Target + _0xfa24e378._0xc32cf24f(new byte[26] { 91, 55, 52, 53, 60, 51, 52, 41, 53, 40, 113, 47, 51, 62, 91, 44, 50, 55, 63, 91, 62, 54, 57, 55, 62, 54 }, 123);
        }

        if (this.Kind == KindCoinsWon)
        {
            return _0xfa24e378._0xc32cf24f(new byte[4] { 185, 167, 160, 206 }, 238) + _0x61cef379.Grouped(this.Target) + _0xfa24e378._0xc32cf24f(new byte[26] { 137, 234, 230, 224, 231, 250, 163, 224, 231, 137, 230, 231, 236, 137, 239, 236, 250, 253, 224, 255, 232, 229, 137, 237, 232, 240 }, 169);
        }

        if (this.Kind == KindPaylines)
        {
            return _0xfa24e378._0xc32cf24f(new byte[4] { 156, 157, 128, 244 }, 212) + this.Target + _0xfa24e378._0xc32cf24f(new byte[24] { 198, 182, 167, 191, 170, 175, 168, 163, 181, 236, 167, 165, 180, 169, 181, 181, 198, 178, 174, 163, 198, 162, 167, 191 }, 230);
        }

        if (this.Kind == KindFourOfAKind)
        {
            return _0xfa24e378._0xc32cf24f(new byte[5] { 127, 114, 125, 119, 19 }, 51) + this.Target + _0xfa24e378._0xc32cf24f(new byte[30] { 57, 95, 86, 76, 75, 52, 86, 95, 52, 88, 52, 82, 80, 87, 93, 19, 86, 87, 57, 88, 87, 64, 57, 73, 88, 64, 85, 80, 87, 92 }, 25);
        }

        if (this.Kind == KindScatters)
        {
            return _0xfa24e378._0xc32cf24f(new byte[5] { 194, 207, 192, 202, 174 }, 142) + this.Target + _0xfa24e378._0xc32cf24f(new byte[25] { 184, 203, 204, 217, 202, 203, 146, 203, 219, 217, 204, 204, 221, 202, 221, 220, 184, 217, 214, 193, 207, 208, 221, 202, 221 }, 152);
        }

        return _0xfa24e378._0xc32cf24f(new byte[17] { 2, 21, 17, 19, 24, 112, 17, 112, 0, 5, 2, 3, 21, 112, 31, 22, 90 }, 80) + _0x61cef379.Grouped(this.Target);
    }

    public int Progress;
    public static readonly int KindCount = 9;
    public string _0xa4552257()
    {
        if (this.Kind == KindSpins)
        {
            return _0xfa24e378._0xc32cf24f(new byte[5] { 142, 141, 148, 147, 142 }, 221);
        }

        if (this.Kind == KindLanterns)
        {
            return _0xfa24e378._0xc32cf24f(new byte[8] { 58, 55, 56, 34, 51, 36, 56, 37 }, 118);
        }

        if (this.Kind == KindBells)
        {
            return _0xfa24e378._0xc32cf24f(new byte[5] { 183, 176, 185, 185, 166 }, 245);
        }

        if (this.Kind == KindLonghorns)
        {
            return _0xfa24e378._0xc32cf24f(new byte[9] { 72, 75, 74, 67, 76, 75, 86, 74, 87 }, 4);
        }

        if (this.Kind == KindCoinsWon)
        {
            return _0xfa24e378._0xc32cf24f(new byte[9] { 187, 183, 177, 182, 171, 216, 175, 183, 182 }, 248);
        }

        if (this.Kind == KindPaylines)
        {
            return _0xfa24e378._0xc32cf24f(new byte[8] { 52, 37, 61, 40, 45, 42, 33, 55 }, 100);
        }

        if (this.Kind == KindFourOfAKind)
        {
            return _0xfa24e378._0xc32cf24f(new byte[13] { 79, 70, 92, 91, 41, 64, 71, 41, 72, 41, 91, 70, 94 }, 9);
        }

        if (this.Kind == KindScatters)
        {
            return _0xfa24e378._0xc32cf24f(new byte[5] { 200, 207, 218, 201, 200 }, 155);
        }

        return _0xfa24e378._0xc32cf24f(new byte[5] { 118, 115, 116, 117, 99 }, 38);
    }

    public float _0x457b84a2()
    {
        if (this.Target <= 0)
        {
            return 0f;
        }

        return Mathf.Clamp01((float)this.Progress / (float)this.Target);
    }

    public int Target;
    public static readonly int KindPurse = 8;
    public bool Claimed;
    public static readonly int KindPaylines = 5;
    public int Slot;
}

internal static class _0xfa24e378
{
    internal static string _0xc32cf24f(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}