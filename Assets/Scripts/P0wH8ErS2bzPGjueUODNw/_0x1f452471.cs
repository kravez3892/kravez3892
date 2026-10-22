using System.Collections.Generic;
using TMPro;
using UnityEngine;

// TmpContrastGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3, rule C.14 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TmpContrastGuard.cs.
//
// WHY: every TMP label gets an outline (C.10), and by default that outline is dark.
// A dark face colour on a dark outline merges into a smudge — the label is not
// readable on any backing (ANDROID-3627: PLAY drawn Deep #12151E on the #12151E
// outline read as a black blob). enforce-text-contrast.sh fixes colours SERIALISED
// in scenes/prefabs, but labels built at runtime from C# (UiKit.Cta, VaultUi.Caption,
// label.color = Palette.X ...) never reach a scene file, so that pass cannot see them.
//
// WHAT: after any TMP text is regenerated, compare its face colour with the outline
// colour of the material it actually renders with. Below WCAG 4.5:1 the face is
// blended toward white (dark outline) or black (light outline) until it reaches 7:1.
// Hue is kept; alpha is kept. A label whose outline was deliberately switched to a
// light colour (TextReadability-style per-label material) is measured against THAT
// outline, so intentionally dark text on a light rim is left alone. Labels without
// an outline are left alone too.
public sealed class _0x1f452471 : MonoBehaviour
{
    private readonly List<TMP_Text> _0x24356f24 = new List<TMP_Text>();
    private static void Fix(TMP_Text _0x5174a405)
    {
        if (_0x5174a405 == null || !_0x5174a405.isActiveAndEnabled)
            return;
        Material _0xee5ebb02 = _0x5174a405.fontSharedMaterial;
        if (_0xee5ebb02 == null || !_0xee5ebb02.HasProperty(ShaderUtilities.ID_OutlineColor) || !_0xee5ebb02.HasProperty(ShaderUtilities.ID_OutlineWidth))
            return;
        if (_0xee5ebb02.GetFloat(ShaderUtilities.ID_OutlineWidth) < MinOutlineWidth)
            return;
        Color _0x7cd6339a = _0x5174a405.color;
        if (_0x7cd6339a.a <= 0f)
            return;
        Color _0xdfbd0a8e = _0xee5ebb02.GetColor(ShaderUtilities.ID_OutlineColor);
        if (Ratio(_0x7cd6339a, _0xdfbd0a8e) >= MinRatio)
            return;
        Color _0xb37331d4 = Luminance(_0xdfbd0a8e) < 0.5f ? Color.white : Color.black;
        Color _0x2459cde9;
        if (Ratio(_0xb37331d4, _0xdfbd0a8e) < TargetRatio)
        {
            _0x2459cde9 = _0xb37331d4;
        }
        else
        {
            // Smallest blend that reaches the target: contrast grows monotonically
            // with t, so a short bisection keeps as much of the hue as possible.
            float _0xd72e587c = 0f;
            float _0x16042cfc = 1f;
            for (int _0xf1c2e690 = 0; _0xf1c2e690 < 20; _0xf1c2e690++)
            {
                float _0x74d8798a = (_0xd72e587c + _0x16042cfc) * 0.5f;
                if (Ratio(Color.Lerp(_0x7cd6339a, _0xb37331d4, _0x74d8798a), _0xdfbd0a8e) >= TargetRatio)
                    _0x16042cfc = _0x74d8798a;
                else
                    _0xd72e587c = _0x74d8798a;
            }

            _0x2459cde9 = Color.Lerp(_0x7cd6339a, _0xb37331d4, _0x16042cfc);
        }

        _0x2459cde9.a = _0x7cd6339a.a;
        _0x5174a405.color = _0x2459cde9;
    }

    // The event fires from inside the canvas rebuild. Changing the colour right there
    // would re-dirty the graphic mid-rebuild, which Unity rejects — so queue it and
    // apply in LateUpdate, which runs before the next frame's rebuild.
    private void _0x874ea61e(Object _0xd6a3b0cd)
    {
        TMP_Text _0xd909e82f = _0xd6a3b0cd as TMP_Text;
        if (_0xd909e82f != null)
            this._0x8d02ff1f.Add(_0xd909e82f);
    }

    private void OnDisable()
    {
        if (this._0x4827f582 != null)
            TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(this._0x4827f582);
    }

    private static float Linear(float _0x55c7b3b0)
    {
        _0x55c7b3b0 = Mathf.Clamp01(_0x55c7b3b0);
        return _0x55c7b3b0 <= 0.03928f ? _0x55c7b3b0 / 12.92f : Mathf.Pow((_0x55c7b3b0 + 0.055f) / 1.055f, 2.4f);
    }

    private void OnEnable()
    {
        if (this._0x4827f582 == null)
            this._0x4827f582 = _0x9a035a3e => this._0x874ea61e(_0x9a035a3e);
        TMPro_EventManager.TEXT_CHANGED_EVENT.Add(this._0x4827f582);
    }

    // A lambda held in a field, never the bare method group: Plana renames the method
    // declaration but not a method-group reference (verify-unity-buttons.sh, CS0103).
    // The field keeps Add and Remove on the same delegate instance.
    private System.Action<Object> _0x4827f582;
    // WCAG relative luminance of an sRGB colour, and the contrast ratio of two.
    private static float Luminance(Color _0xbba2142c)
    {
        return 0.2126f * Linear(_0xbba2142c.r) + 0.7152f * Linear(_0xbba2142c.g) + 0.0722f * Linear(_0xbba2142c.b);
    }

    private void LateUpdate()
    {
        if (this._0x8d02ff1f.Count == 0)
            return;
        this._0x24356f24.Clear();
        this._0x24356f24.AddRange(this._0x8d02ff1f);
        this._0x8d02ff1f.Clear();
        for (int _0xb500fa41 = 0; _0xb500fa41 < this._0x24356f24.Count; _0xb500fa41++)
            Fix(this._0x24356f24[_0xb500fa41]);
    }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0xfe7ee491 != null)
            return;
        GameObject _0x15199c51 = new GameObject(_0x6cd91ccf._0xbe312e87(new byte[16] { 202, 243, 238, 221, 241, 240, 234, 236, 255, 237, 234, 217, 235, 255, 236, 250 }, 158));
        _0x15199c51.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0x15199c51);
        _0xfe7ee491 = _0x15199c51.AddComponent<_0x1f452471>();
    }

    private static _0x1f452471 _0xfe7ee491;
    private const float TargetRatio = 7f;
    private const float MinRatio = 4.5f;
    private static float Ratio(Color _0xf244c462, Color _0x7c0a48d1)
    {
        float _0x8f31c644 = Luminance(_0xf244c462);
        float _0x99624cde = Luminance(_0x7c0a48d1);
        return (Mathf.Max(_0x8f31c644, _0x99624cde) + 0.05f) / (Mathf.Min(_0x8f31c644, _0x99624cde) + 0.05f);
    }

    private const float MinOutlineWidth = 0.01f;
    private readonly HashSet<TMP_Text> _0x8d02ff1f = new HashSet<TMP_Text>();
}

internal static class _0x6cd91ccf
{
    internal static string _0xbe312e87(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}