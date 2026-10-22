using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// The daily-objective tab of the lobby sheet: three cards, each with its own progress pips,
/// a gold bar and a CLAIM plate that pays out on the spot.
///
/// The pip gutter and the text live in two horizontal bands that never share an x-range
/// (rule C.25): the gutter is centred at GutterCentre with GutterWidth, the text column
/// starts a clear TextGap to the right of it, and every label is placed at the centre of its
/// OWN column rather than at the card's zero.
public sealed class _0xbea032fb : MonoBehaviour
{
    private static readonly float _0x3702bdb1 = 560f;
    private static float TextCentreX()
    {
        return TextLeft() + (_0x3702bdb1 * 0.5f) - (_0x8c2a3a1f * 0.5f);
    }

    private static float RightCentreX()
    {
        float _0xb448e60d = TextLeft() + _0x3702bdb1 + 24f;
        float width = _0x8c2a3a1f - 20f - _0xb448e60d;
        return _0xb448e60d + (width * 0.5f) - (_0x8c2a3a1f * 0.5f);
    }

    private readonly List<Image> _0xe757e36a = new List<Image>();
    private static readonly float _0xbf3235ce = 62f;
    private void OnDestroy()
    {
        DOTween.Kill(this);
        for (int _0xbe8c47cb = 0; _0xbe8c47cb < this._0xb06e11cb.Count; _0xbe8c47cb++)
        {
            if (this._0xb06e11cb[_0xbe8c47cb] != null)
            {
                DOTween.Kill(this._0xb06e11cb[_0xbe8c47cb]);
            }
        }
    }

    private void _0x183c1b44(RectTransform _0x02d9e828, _0xde8b9ebc _0xd67b3b8b, TMP_FontAsset _0xca2323f6, int _0x0e154746, float _0x4252c7de)
    {
        RectTransform _0x327baa30 = _0xcc3029b1.Node(_0x02d9e828, _0x60ee2511._0x90285c98(new byte[13] { 2, 41, 32, 45, 45, 36, 47, 38, 36, 2, 32, 51, 37 }, 65), 0.5f, _0x4252c7de, _0x8c2a3a1f, _0x4d7deb96);
        _0xcc3029b1.Plate(_0x327baa30, _0xd67b3b8b.CardPlate, _0xfbd72b05.Amber, 2.4f);
        RectTransform _0xa2912bb6 = _0xcc3029b1.Inner(_0x327baa30, _0x60ee2511._0x90285c98(new byte[4] { 154, 183, 188, 161 }, 216), 0f, 0f, _0x8c2a3a1f - 18f, _0x4d7deb96 - 18f);
        _0xcc3029b1.Plate(_0xa2912bb6, _0xd67b3b8b.CardPlate, _0xfbd72b05.Bronze, 2.4f);
        this._0xb06e11cb.Add(_0x327baa30);
        float _0xe22917d0 = GutterCentreX();
        for (int _0xcb0bff8d = 0; _0xcb0bff8d < _0xb09dde7c; _0xcb0bff8d++)
        {
            float _0x6f9a5e50 = (((_0xb09dde7c - 1) * 0.5f) - _0xcb0bff8d) * 44f;
            RectTransform _0x3a4c7ee3 = _0xcc3029b1.Inner(_0x327baa30, _0x60ee2511._0x90285c98(new byte[3] { 24, 33, 56 }, 72), _0xe22917d0, _0x6f9a5e50, _0xe97cb062, 32f);
            Image _0x08f4dd65 = _0xcc3029b1.Plate(_0x3a4c7ee3, _0xd67b3b8b.CardPlate, _0xfbd72b05.Ink, 1.1f);
            this._0x9f63edee.Add(_0x08f4dd65);
        }

        float _0xd09832a4 = TextCentreX();
        RectTransform _0x345ebbb9 = _0xcc3029b1.Inner(_0x327baa30, _0x60ee2511._0x90285c98(new byte[5] { 170, 151, 138, 146, 155 }, 254), _0xd09832a4, 44f, _0x3702bdb1, 96f);
        this._0x2f532e05.Add(_0xcc3029b1.Label(_0x345ebbb9, _0xca2323f6, _0x60ee2511._0x90285c98(new byte[13] { 110, 109, 123, 124, 97, 126, 105, 100, 8, 124, 105, 123, 99 }, 40), 40f, _0xfbd72b05.Cream, TextAlignmentOptions.Left));
        RectTransform _0x6c00cc38 = _0xcc3029b1.Inner(_0x327baa30, _0x60ee2511._0x90285c98(new byte[5] { 14, 40, 59, 57, 49 }, 90), _0xd09832a4, -46f, _0x3702bdb1, 28f);
        _0xcc3029b1.Plate(_0x6c00cc38, _0xd67b3b8b.CardPlate, _0xfbd72b05.Ink, 1.2f);
        this._0x8fa411ef.Add(_0x6c00cc38);
        RectTransform _0x7640aea1 = _0xcc3029b1.Inner(_0x6c00cc38, _0x60ee2511._0x90285c98(new byte[4] { 151, 184, 189, 189 }, 209), 0f, 0f, 10f, 20f);
        _0x7640aea1.anchorMin = new Vector2(0f, 0.5f);
        _0x7640aea1.anchorMax = new Vector2(0f, 0.5f);
        _0x7640aea1.pivot = new Vector2(0f, 0.5f);
        _0x7640aea1.anchoredPosition = new Vector2(4f, 0f);
        _0xcc3029b1.Plate(_0x7640aea1, _0xd67b3b8b.CardPlate, _0xfbd72b05.Gold, 1.2f);
        this._0x1f85d3c9.Add(_0x7640aea1);
        float _0x2d6dd66b = RightCentreX();
        RectTransform _0xaa2c1a2f = _0xcc3029b1.Inner(_0x327baa30, _0x60ee2511._0x90285c98(new byte[5] { 231, 203, 209, 202, 208 }, 164), _0x2d6dd66b, 52f, 196f, 56f);
        this._0x6f692fad.Add(_0xcc3029b1.Label(_0xaa2c1a2f, _0xca2323f6, _0x60ee2511._0x90285c98(new byte[5] { 90, 74, 69, 74, 90 }, 106), 40f, _0xfbd72b05.Gold, TextAlignmentOptions.Center));
        RectTransform _0x7f7b802b = _0xcc3029b1.Inner(_0x327baa30, _0x60ee2511._0x90285c98(new byte[5] { 193, 238, 227, 235, 239 }, 130), _0x2d6dd66b, -38f, 196f, 96f);
        Image _0x7ab67440 = _0xcc3029b1.Plate(_0x7f7b802b, _0xd67b3b8b.CardPlate, _0xfbd72b05.Amber, 1.8f);
        _0x7ab67440.raycastTarget = true;
        RectTransform _0x4e46f659 = _0xcc3029b1.Inner(_0x7f7b802b, _0x60ee2511._0x90285c98(new byte[4] { 119, 90, 81, 76 }, 53), 0f, 0f, 180f, 80f);
        _0xcc3029b1.Plate(_0x4e46f659, _0xd67b3b8b.CardPlate, _0xfbd72b05.BronzeLit, 1.8f);
        TextMeshProUGUI _0x0d0c3007 = _0xcc3029b1.Label(_0x7f7b802b, _0xca2323f6, _0x60ee2511._0x90285c98(new byte[5] { 136, 135, 138, 130, 134 }, 203), 38f, _0xfbd72b05.Cream, TextAlignmentOptions.Center);
        Button _0xdf24f83c = _0x7f7b802b.gameObject.AddComponent<Button>();
        _0xdf24f83c.targetGraphic = _0x7ab67440;
        int _0x541e59df = _0x0e154746;
        _0xdf24f83c.onClick.AddListener(() => this._0x0c2df5ab(_0x541e59df));
        this._0x4ca52288.Add(_0xdf24f83c);
        this._0xae78dc80.Add(_0x0d0c3007);
        this._0xe757e36a.Add(_0x7ab67440);
    }

    private RectTransform _0x1f653eba;
    private static readonly float _0x4d7deb96 = 220f;
    private readonly List<Image> _0x9f63edee = new List<Image>();
    public void _0x3e22b9a6(bool _0x31b4f1d0)
    {
        if (this._0x1c4d4db4 != null)
        {
            this._0x1c4d4db4.gameObject.SetActive(_0x31b4f1d0);
        }
    }

    private readonly List<TextMeshProUGUI> _0xae78dc80 = new List<TextMeshProUGUI>();
    private readonly List<TextMeshProUGUI> _0x2f532e05 = new List<TextMeshProUGUI>();
    private readonly List<RectTransform> _0x1f85d3c9 = new List<RectTransform>();
    private readonly List<Button> _0x4ca52288 = new List<Button>();
    private _0x3bfed499 _0xf4bb200f;
    private static readonly float _0xe97cb062 = 48f;
    private RectTransform _0x1c4d4db4;
    private static readonly float _0x2425ff8e = 46f;
    private static float GutterCentreX()
    {
        return _0xbf3235ce - (_0x8c2a3a1f * 0.5f);
    }

    /// Column maths, done once and reused by every label so the two bands cannot drift apart.
    private static float TextLeft()
    {
        return _0xbf3235ce + (_0xe97cb062 * 0.5f) + _0x2425ff8e;
    }

    private readonly List<RectTransform> _0xb06e11cb = new List<RectTransform>();
    private readonly List<TextMeshProUGUI> _0x6f692fad = new List<TextMeshProUGUI>();
    private static readonly float _0x8c2a3a1f = 940f;
    private readonly List<RectTransform> _0x8fa411ef = new List<RectTransform>();
    private static readonly int _0xb09dde7c = 4;
    /// A claim pays out and REDRAWS in the same frame - the purse, the card and the lobby
    /// teaser all move, so the tap is confirmed by what is on screen (rule C.7).
    private void _0x0c2df5ab(int _0x48539020)
    {
        if (!_0x399a20a6.Claim(_0x48539020))
        {
            return;
        }

        if (_0x48539020 < this._0xb06e11cb.Count && this._0xb06e11cb[_0x48539020] != null)
        {
            this._0xb06e11cb[_0x48539020].DOPunchScale(Vector3.one * 0.05f, 0.3f, 6, 0.6f).SetLink(this._0xb06e11cb[_0x48539020].gameObject);
        }

        this._0xaa618c12();
        if (this._0xf4bb200f != null)
        {
            this._0xf4bb200f._0xe77c0e43();
        }
    }

    public void _0xaa618c12()
    {
        List<_0xc2530753> _0xf1a1cacd = _0x399a20a6.Challenges();
        bool _0xca3215e0 = _0x399a20a6.AllClaimed();
        if (this._0x1f653eba != null)
        {
            this._0x1f653eba.gameObject.SetActive(_0xca3215e0);
        }

        for (int _0xc5484f5e = 0; _0xc5484f5e < this._0xb06e11cb.Count; _0xc5484f5e++)
        {
            bool _0x4f394a11 = !_0xca3215e0 && _0xc5484f5e < _0xf1a1cacd.Count;
            this._0xb06e11cb[_0xc5484f5e].gameObject.SetActive(_0x4f394a11);
            if (!_0x4f394a11)
            {
                continue;
            }

            _0xc2530753 _0x59e49233 = _0xf1a1cacd[_0xc5484f5e];
            _0x61cef379.SetText(this._0x2f532e05[_0xc5484f5e], _0x59e49233._0x31eab4b1());
            _0x61cef379.SetText(this._0x6f692fad[_0xc5484f5e], _0x59e49233.Progress + _0x60ee2511._0x90285c98(new byte[3] { 250, 245, 250 }, 218) + _0x59e49233.Target);
            float _0xd62d758d = this._0x8fa411ef[_0xc5484f5e].sizeDelta.x - 8f;
            this._0x1f85d3c9[_0xc5484f5e].sizeDelta = new Vector2(Mathf.Max(10f, _0xd62d758d * _0x59e49233._0x457b84a2()), this._0x1f85d3c9[_0xc5484f5e].sizeDelta.y);
            float _0x6ffe238a = _0x59e49233._0x457b84a2();
            for (int _0x56761e4b = 0; _0x56761e4b < _0xb09dde7c; _0x56761e4b++)
            {
                Image _0x3c722313 = this._0x9f63edee[(_0xc5484f5e * _0xb09dde7c) + _0x56761e4b];
                bool _0xba3861f8 = _0x6ffe238a >= (((_0x56761e4b + 1f) / _0xb09dde7c) - 0.001f);
                _0x3c722313.color = _0xba3861f8 ? _0xfbd72b05.Gold : _0xfbd72b05.Ink;
            }

            bool _0x1dcf5d9b = _0x59e49233._0xc1a984ce() && !_0x59e49233.Claimed;
            this._0x4ca52288[_0xc5484f5e].interactable = _0x1dcf5d9b;
            this._0xe757e36a[_0xc5484f5e].color = _0x1dcf5d9b ? _0xfbd72b05.Gold : _0xfbd72b05.Muted;
            if (_0x59e49233.Claimed)
            {
                _0x61cef379.SetText(this._0xae78dc80[_0xc5484f5e], _0x60ee2511._0x90285c98(new byte[7] { 24, 23, 26, 18, 22, 30, 31 }, 91));
                this._0xae78dc80[_0xc5484f5e].color = _0xfbd72b05.Sand;
            }
            else if (_0x1dcf5d9b)
            {
                _0x61cef379.SetText(this._0xae78dc80[_0xc5484f5e], _0x60ee2511._0x90285c98(new byte[5] { 180, 187, 182, 190, 186 }, 247));
                this._0xae78dc80[_0xc5484f5e].color = _0xfbd72b05.Cream;
            }
            else
            {
                _0x61cef379.SetText(this._0xae78dc80[_0xc5484f5e], _0x60ee2511._0x90285c98(new byte[1] { 83 }, 120) + _0x61cef379.Grouped(_0x59e49233.Reward));
                this._0xae78dc80[_0xc5484f5e].color = _0xfbd72b05.Sand;
            }
        }
    }

    public void _0xa47bc86f(RectTransform _0x4b59137c, _0x3bfed499 _0xce9507c9, _0xde8b9ebc _0x29144a5e, TMP_FontAsset _0x42084e9c)
    {
        this._0x1c4d4db4 = _0x4b59137c;
        this._0xf4bb200f = _0xce9507c9;
        _0xcc3029b1.Caption(_0x4b59137c, _0x60ee2511._0x90285c98(new byte[10] { 156, 177, 191, 172, 186, 138, 183, 170, 178, 187 }, 222), 0.5f, 0.935f, 900f, 72f, _0x42084e9c, _0x60ee2511._0x90285c98(new byte[20] { 32, 35, 53, 50, 47, 48, 39, 42, 70, 50, 39, 53, 45, 53, 70, 50, 41, 34, 39, 63 }, 102), 48f, _0xfbd72b05.GoldSoft);
        float[] _0x7deba171 =
        {
            0.740f,
            0.515f,
            0.290f
        };
        for (int _0xcb1c88be = 0; _0xcb1c88be < _0x7deba171.Length; _0xcb1c88be++)
        {
            this._0x183c1b44(_0x4b59137c, _0x29144a5e, _0x42084e9c, _0xcb1c88be, _0x7deba171[_0xcb1c88be]);
        }

        _0xcc3029b1.Caption(_0x4b59137c, _0x60ee2511._0x90285c98(new byte[9] { 183, 154, 148, 135, 145, 187, 154, 129, 144 }, 245), 0.5f, 0.105f, 940f, 60f, _0x42084e9c, _0x60ee2511._0x90285c98(new byte[39] { 237, 250, 232, 254, 237, 251, 236, 159, 254, 237, 250, 159, 239, 243, 254, 230, 159, 242, 240, 241, 250, 230, 159, 146, 159, 241, 240, 235, 247, 246, 241, 248, 159, 235, 240, 159, 253, 234, 230 }, 191), 34f, _0xfbd72b05.Sand);
        this._0x1f653eba = _0xcc3029b1.Node(_0x4b59137c, _0x60ee2511._0x90285c98(new byte[10] { 171, 134, 136, 155, 141, 172, 132, 153, 157, 144 }, 233), 0.5f, 0.52f, 900f, 220f);
        _0xcc3029b1.Label(this._0x1f653eba, _0x42084e9c, _0x60ee2511._0x90285c98(new byte[36] { 18, 31, 31, 115, 7, 18, 0, 24, 0, 115, 16, 31, 18, 26, 30, 22, 23, 89, 29, 22, 4, 115, 0, 22, 7, 115, 18, 7, 115, 0, 6, 29, 1, 26, 0, 22 }, 83), 46f, _0xfbd72b05.Sand, TextAlignmentOptions.Center);
        this._0x1f653eba.gameObject.SetActive(false);
    }
}

internal static class _0x60ee2511
{
    internal static string _0x90285c98(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}