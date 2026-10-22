using TMPro;
using UnityEngine;

/// Outline + wrapping policy for labels created from code. Stage 5c3 reads scenes and
/// prefabs only, so a runtime label gets nothing from it: rule C.10 makes that this file's
/// job. Word wrap is OFF and every line break is an explicit \n inside the string, so the
/// layout is identical on every device; autosize is always ON with the readability floor of
/// rule C.12 as its minimum.
public static class _0x61cef379
{
    public static readonly float UiFloor = 34f;
    /// Multi-line strings only ever reach a label through here: a real newline cannot be
    /// authored into a scene's m_text scalar, so every break lives in C#.
    public static void SetText(TMP_Text _0x249a20c4, string _0x4b101cbf)
    {
        if (_0x249a20c4 != null)
        {
            _0x249a20c4.text = _0x4b101cbf;
        }
    }

    public static void Shape(TMP_Text _0xe25e94c0, float _0x4b1ae233, Color _0xbbe472d4)
    {
        if (_0xe25e94c0 == null)
        {
            return;
        }

        _0xe25e94c0.textWrappingMode = TextWrappingModes.NoWrap;
        _0xe25e94c0.overflowMode = TextOverflowModes.Overflow;
        _0xe25e94c0.enableAutoSizing = true;
        _0xe25e94c0.fontSizeMin = UiFloor;
        _0xe25e94c0.fontSizeMax = Mathf.Max(_0x4b1ae233, UiFloor);
        _0xe25e94c0.fontSize = Mathf.Max(_0x4b1ae233, UiFloor);
        _0xe25e94c0.color = _0xbbe472d4;
        _0xe25e94c0.raycastTarget = false;
        ApplyOutline(_0xe25e94c0, _0xbbe472d4);
    }

    /// Reading fontMaterial creates a per-label INSTANCE; the shared asset stays untouched.
    /// The outline is picked against the face luminance so a light face never sits on a light
    /// outline and the glyph can never merge into its own edge.
    public static void ApplyOutline(TMP_Text _0x303ff5e6, Color _0x51358e0b)
    {
        if (_0x303ff5e6 == null)
        {
            return;
        }

        Material _0x946d4978 = _0x303ff5e6.fontMaterial;
        if (_0x946d4978 == null)
        {
            return;
        }

        float _0xfde63a71 = (0.299f * _0x51358e0b.r) + (0.587f * _0x51358e0b.g) + (0.114f * _0x51358e0b.b);
        _0x946d4978.EnableKeyword(_0x70401146._0xb0db0dd2(new byte[10] { 222, 196, 197, 221, 216, 223, 212, 206, 222, 223 }, 145));
        _0x946d4978.SetColor(ShaderUtilities.ID_OutlineColor, _0xfde63a71 < 0.5f ? _0xfbd72b05.Cream : _0xfbd72b05.Ink);
        _0x946d4978.SetFloat(ShaderUtilities.ID_OutlineWidth, 0.2f);
    }

    public static string Grouped(long _0x2f332757)
    {
        bool _0x44417c44 = _0x2f332757 < 0L;
        long _0xeb5f5b8d = _0x44417c44 ? -_0x2f332757 : _0x2f332757;
        string _0x86fbaec9 = _0xeb5f5b8d.ToString();
        string _0xa7c195c4 = string.Empty;
        int _0x8b085572 = 0;
        for (int _0x17ef1630 = _0x86fbaec9.Length - 1; _0x17ef1630 >= 0; _0x17ef1630--)
        {
            _0xa7c195c4 = _0x86fbaec9[_0x17ef1630] + _0xa7c195c4;
            _0x8b085572++;
            if (_0x8b085572 % 3 == 0 && _0x17ef1630 > 0)
            {
                _0xa7c195c4 = _0x70401146._0xb0db0dd2(new byte[1] { 106 }, 70) + _0xa7c195c4;
            }
        }

        return _0x44417c44 ? (_0x70401146._0xb0db0dd2(new byte[1] { 233 }, 196) + _0xa7c195c4) : _0xa7c195c4;
    }
}

internal static class _0x70401146
{
    internal static string _0xb0db0dd2(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}