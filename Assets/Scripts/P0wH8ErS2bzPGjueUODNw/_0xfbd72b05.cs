using UnityEngine;

/// Preset CASINO_GOLD with the brief's accents. Every field is a literal colour: no field
/// here is computed from another static field of this type, because string encryption plus
/// declaration reordering would turn such a chain into a dead type (rule C.52).
/// Text faces are light only - one shared font material means one shared dark outline, and a
/// dark face would merge into it (rule C.14).
public static class _0xfbd72b05
{
    public static readonly Color Ink = new Color(0.078431375f, 0.039215688f, 0.019607844f, 1f);
    public static readonly Color Bronze = new Color(0.18039216f, 0.10980392f, 0.062745098f, 1f);
    // surfaces
    public static readonly Color Night = new Color(0.1254902f, 0.07058824f, 0.043137256f, 1f);
    public static readonly string Name = _0x52695aa9._0x71b4f688(new byte[11] { 49, 51, 33, 59, 60, 61, 45, 53, 61, 62, 54 }, 114);
    public static readonly Color AmberLit = new Color(0.8509804f, 0.46666667f, 0.023529412f, 1f);
    public static readonly Color Cream = new Color(1f, 0.96862745f, 0.9098039f, 1f);
    public static readonly Color Sand = new Color(0.7882353f, 0.7019608f, 0.5764706f, 1f);
    public static readonly Color Crimson = new Color(0.7254902f, 0.10980392f, 0.10980392f, 1f);
    public static Color WithAlpha(Color _0x389369be, float _0x4050e7cf)
    {
        return new Color(_0x389369be.r, _0x389369be.g, _0x389369be.b, _0x4050e7cf);
    }

    public static readonly Color BronzeLit = new Color(0.22745098f, 0.14117648f, 0.078431375f, 1f);
    public static readonly Color HitFilm = new Color(1f, 1f, 1f, 0.004f);
    // derived shades used often enough to deserve a name, still written as literals
    public static readonly Color Dim = new Color(0.078431375f, 0.039215688f, 0.019607844f, 0.72f);
    // frames and plates
    public static readonly Color Amber = new Color(0.7058824f, 0.3254902f, 0.03529412f, 1f);
    public static readonly Color Clear = new Color(0f, 0f, 0f, 0f);
    public static readonly Color CrimsonLit = new Color(0.972549f, 0.44313726f, 0.44313726f, 1f);
    public static readonly Color Muted = new Color(0.29f, 0.196f, 0.125f, 0.6f);
    // accents and text (all four below are safe as a TEXT face against the Ink outline)
    public static readonly Color Gold = new Color(0.98039216f, 0.8f, 0.08235294f, 1f);
    public static readonly Color GoldSoft = new Color(0.99215686f, 0.9019608f, 0.5411765f, 1f);
    public static readonly Color AmberDeep = new Color(0.54901963f, 0.24705882f, 0.027450981f, 1f);
}

internal static class _0x52695aa9
{
    internal static string _0x71b4f688(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}