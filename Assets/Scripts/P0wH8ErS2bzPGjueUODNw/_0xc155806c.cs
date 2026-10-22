using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// The emblem album: a 4 x 2 grid of the eight reel faces. A slot the player has landed
/// shows the sprite, its name and how many have been stamped; a slot still missing shows a
/// flat silhouette plate with a question mark, so the grid reads as a collection rather than
/// as a half-empty page.
///
/// When nothing at all has been found, the grid is replaced by a themed message instead of
/// an empty area (rule G, empty states).
public sealed class _0xc155806c : MonoBehaviour
{
    public void _0x75b1a9ed(RectTransform _0x09feadfd, _0xde8b9ebc _0xc50f5f9d, TMP_FontAsset _0x815d549b)
    {
        this._0x54d7e2b8 = _0x09feadfd;
        _0xcc3029b1.Caption(_0x09feadfd, _0x4808228b._0x15c46b35(new byte[10] { 148, 185, 183, 160, 184, 129, 188, 161, 185, 176 }, 213), 0.5f, 0.935f, 900f, 72f, _0x815d549b, _0x4808228b._0x15c46b35(new byte[17] { 40, 63, 38, 38, 74, 47, 39, 40, 38, 47, 39, 74, 43, 38, 40, 63, 39 }, 106), 48f, _0xfbd72b05.GoldSoft);
        this._0x3c24cdf2 = _0xcc3029b1.Node(_0x09feadfd, _0x4808228b._0x15c46b35(new byte[13] { 220, 241, 255, 232, 240, 218, 239, 244, 249, 213, 242, 238, 233 }, 157), 0.5f, 0.555f, 980f, 560f);
        float[] _0x192ac2bb =
        {
            0.125f,
            0.375f,
            0.625f,
            0.875f
        };
        float[] _0x935419a7 =
        {
            0.76f,
            0.25f
        };
        for (int _0xb02e9011 = 0; _0xb02e9011 < _0x97c3b88a.Count; _0xb02e9011++)
        {
            int _0x6622d826 = _0xb02e9011 % _0x0a3c5503;
            int _0x9d5a6fb4 = _0xb02e9011 / _0x0a3c5503;
            if (_0x9d5a6fb4 >= _0xa534b676)
            {
                break;
            }

            this._0x3dfb4d69(this._0x3c24cdf2, _0xc50f5f9d, _0x815d549b, _0xb02e9011, _0x192ac2bb[_0x6622d826], _0x935419a7[_0x9d5a6fb4]);
        }

        this._0xc44ef22d = _0xcc3029b1.Caption(_0x09feadfd, _0x4808228b._0x15c46b35(new byte[10] { 213, 248, 246, 225, 249, 192, 245, 248, 248, 237 }, 148), 0.5f, 0.205f, 700f, 72f, _0x815d549b, _0x4808228b._0x15c46b35(new byte[13] { 130, 138, 133, 139, 130, 138, 148, 231, 247, 231, 232, 231, 255 }, 199), 48f, _0xfbd72b05.Gold);
        this._0x9b1c5d5b = _0xcc3029b1.Caption(_0x09feadfd, _0x4808228b._0x15c46b35(new byte[9] { 189, 144, 158, 137, 145, 180, 149, 146, 136 }, 252), 0.5f, 0.115f, 960f, 110f, _0x815d549b, _0x4808228b._0x15c46b35(new byte[51] { 202, 199, 200, 194, 166, 183, 182, 166, 202, 201, 200, 193, 206, 201, 212, 200, 213, 166, 210, 201, 166, 211, 200, 202, 201, 197, 205, 140, 210, 206, 195, 166, 200, 195, 222, 210, 166, 192, 195, 213, 210, 207, 208, 199, 202, 166, 213, 197, 195, 200, 195 }, 134), 36f, _0xfbd72b05.Sand);
        this._0x86991b70 = _0xcc3029b1.Node(_0x09feadfd, _0x4808228b._0x15c46b35(new byte[10] { 229, 200, 198, 209, 201, 225, 201, 212, 208, 221 }, 164), 0.5f, 0.555f, 920f, 220f);
        _0xcc3029b1.Label(this._0x86991b70, _0x815d549b, _0x4808228b._0x15c46b35(new byte[42] { 213, 212, 207, 211, 210, 213, 220, 187, 216, 212, 215, 215, 222, 216, 207, 222, 223, 187, 194, 222, 207, 145, 200, 203, 210, 213, 187, 207, 212, 187, 221, 210, 213, 223, 187, 222, 214, 217, 215, 222, 214, 200 }, 155), 46f, _0xfbd72b05.Sand, TextAlignmentOptions.Center);
        this._0x86991b70.gameObject.SetActive(false);
    }

    private void _0x3dfb4d69(RectTransform _0x18cfc6ba, _0xde8b9ebc _0x2aefa37a, TMP_FontAsset _0xb95edaa6, int _0xd734b071, float _0x92bf6e3e, float _0xe426b649)
    {
        RectTransform _0x1fa42350 = _0xcc3029b1.Node(_0x18cfc6ba, _0x4808228b._0x15c46b35(new byte[9] { 222, 243, 253, 234, 242, 204, 243, 240, 235 }, 159), _0x92bf6e3e, _0xe426b649, _0x0f0b8107, _0x0f0b8107);
        Image _0x80afc09b = _0xcc3029b1.Plate(_0x1fa42350, _0x2aefa37a.CardPlate, _0xfbd72b05.Amber, 2f);
        RectTransform _0xe5f122d7 = _0xcc3029b1.Inner(_0x1fa42350, _0x4808228b._0x15c46b35(new byte[4] { 52, 25, 18, 15 }, 118), 0f, 0f, _0x0f0b8107 - 16f, _0x0f0b8107 - 16f);
        _0xcc3029b1.Plate(_0xe5f122d7, _0x2aefa37a.CardPlate, _0xfbd72b05.Bronze, 2f);
        RectTransform _0x02a31e42 = _0xcc3029b1.Inner(_0x1fa42350, _0x4808228b._0x15c46b35(new byte[4] { 76, 107, 105, 111 }, 10), 0f, 26f, 116f, 116f);
        Image _0xe4e5fc90 = _0xcc3029b1.Picture(_0x02a31e42, _0x2aefa37a._0x58665a31(_0xd734b071), Color.white);
        RectTransform _0x640feda6 = _0xcc3029b1.Inner(_0x1fa42350, _0x4808228b._0x15c46b35(new byte[6] { 67, 96, 108, 100, 106, 107 }, 15), 0f, 26f, 116f, 116f);
        TextMeshProUGUI _0x403f0c18 = _0xcc3029b1.Label(_0x640feda6, _0xb95edaa6, _0x4808228b._0x15c46b35(new byte[1] { 108 }, 83), 64f, _0xfbd72b05.Sand, TextAlignmentOptions.Center);
        RectTransform _0xaeda3b94 = _0xcc3029b1.Inner(_0x1fa42350, _0x4808228b._0x15c46b35(new byte[4] { 121, 86, 90, 82 }, 55), 0f, -56f, _0x0f0b8107 - 28f, 44f);
        TextMeshProUGUI _0x51c2ee6b = _0xcc3029b1.Label(_0xaeda3b94, _0xb95edaa6, _0x97c3b88a.NameOf(_0xd734b071), 34f, _0xfbd72b05.Cream, TextAlignmentOptions.Center);
        RectTransform _0x6948b83c = _0xcc3029b1.Inner(_0x1fa42350, _0x4808228b._0x15c46b35(new byte[5] { 115, 95, 69, 94, 68 }, 48), 0f, -92f, _0x0f0b8107 - 28f, 42f);
        TextMeshProUGUI _0x1e9b4dca = _0xcc3029b1.Label(_0x6948b83c, _0xb95edaa6, _0x4808228b._0x15c46b35(new byte[1] { 200 }, 248), 34f, _0xfbd72b05.Gold, TextAlignmentOptions.Center);
        this._0xfc6b412c.Add(_0x1fa42350);
        this._0x6be85034.Add(_0x80afc09b);
        this._0x2a526d45.Add(_0xe4e5fc90);
        this._0xe1babd9c.Add(_0x403f0c18);
        this._0x29de6ac9.Add(_0x51c2ee6b);
        this._0x36738f83.Add(_0x1e9b4dca);
    }

    private void OnDestroy()
    {
        DOTween.Kill(this);
    }

    private readonly List<Image> _0x6be85034 = new List<Image>();
    private TextMeshProUGUI _0xc44ef22d;
    private static readonly int _0x0a3c5503 = 4;
    private RectTransform _0x54d7e2b8;
    private readonly List<TextMeshProUGUI> _0x29de6ac9 = new List<TextMeshProUGUI>();
    private TextMeshProUGUI _0x9b1c5d5b;
    private RectTransform _0x86991b70;
    private readonly List<Image> _0x2a526d45 = new List<Image>();
    private readonly List<RectTransform> _0xfc6b412c = new List<RectTransform>();
    private static readonly int _0xa534b676 = 2;
    private readonly List<TextMeshProUGUI> _0x36738f83 = new List<TextMeshProUGUI>();
    private static readonly float _0x0f0b8107 = 216f;
    private RectTransform _0x3c24cdf2;
    private readonly List<TextMeshProUGUI> _0xe1babd9c = new List<TextMeshProUGUI>();
    public void _0xcd5c7864(bool _0x4635c230)
    {
        if (this._0x54d7e2b8 != null)
        {
            this._0x54d7e2b8.gameObject.SetActive(_0x4635c230);
        }
    }

    public void _0x4130137b()
    {
        int _0x3c2fc791 = _0x399a20a6.AlbumUnlocked();
        bool _0xfbf823e8 = _0x3c2fc791 == 0;
        if (this._0x3c24cdf2 != null)
        {
            this._0x3c24cdf2.gameObject.SetActive(!_0xfbf823e8);
        }

        if (this._0x86991b70 != null)
        {
            this._0x86991b70.gameObject.SetActive(_0xfbf823e8);
        }

        if (this._0xc44ef22d != null)
        {
            _0x61cef379.SetText(this._0xc44ef22d, _0x4808228b._0x15c46b35(new byte[8] { 168, 160, 175, 161, 168, 160, 190, 205 }, 237) + _0x3c2fc791 + _0x4808228b._0x15c46b35(new byte[3] { 22, 25, 22 }, 54) + _0x97c3b88a.Count);
        }

        if (this._0x9b1c5d5b != null)
        {
            int _0xe9eff8a9 = _0x399a20a6.AlbumCount(_0x97c3b88a.Wild);
            int _0x430c5523 = _0x399a20a6.SceneUnlocked(2) ? 0 : (_0x399a20a6.SceneUnlocked(1) ? 2 : 1);
            _0x61cef379.SetText(this._0x9b1c5d5b, _0x430c5523 == 0 ? _0x4808228b._0x15c46b35(new byte[51] { 39, 52, 39, 48, 59, 66, 36, 39, 49, 54, 43, 52, 35, 46, 66, 49, 33, 39, 44, 39, 66, 55, 44, 46, 45, 33, 41, 39, 38, 104, 33, 42, 35, 44, 37, 39, 66, 43, 54, 66, 43, 44, 66, 49, 39, 54, 54, 43, 44, 37, 49 }, 98) : (_0x4808228b._0x15c46b35(new byte[10] { 209, 210, 211, 218, 213, 210, 207, 211, 206, 189 }, 157) + _0xe9eff8a9 + _0x4808228b._0x15c46b35(new byte[3] { 103, 104, 103 }, 71) + (_0x399a20a6.SceneUnlockEmblems * _0x430c5523) + _0x4808228b._0x15c46b35(new byte[32] { 218, 133, 158, 156, 159, 147, 155, 131, 240, 132, 152, 149, 240, 158, 149, 136, 132, 240, 150, 149, 131, 132, 153, 134, 145, 156, 240, 131, 147, 149, 158, 149 }, 208)));
        }

        for (int _0x13340027 = 0; _0x13340027 < this._0xfc6b412c.Count; _0x13340027++)
        {
            int _0x6c0ac47b = _0x399a20a6.AlbumCount(_0x13340027);
            bool _0xd4e2f164 = _0x6c0ac47b > 0;
            this._0x2a526d45[_0x13340027].gameObject.SetActive(_0xd4e2f164);
            this._0xe1babd9c[_0x13340027].gameObject.SetActive(!_0xd4e2f164);
            this._0x6be85034[_0x13340027].color = _0xd4e2f164 ? _0xfbd72b05.Gold : _0xfbd72b05.Muted;
            this._0x29de6ac9[_0x13340027].color = _0xd4e2f164 ? _0xfbd72b05.Cream : _0xfbd72b05.Sand;
            _0x61cef379.SetText(this._0x36738f83[_0x13340027], _0xd4e2f164 ? (_0x4808228b._0x15c46b35(new byte[1] { 54 }, 78) + _0x6c0ac47b) : _0x4808228b._0x15c46b35(new byte[6] { 249, 250, 246, 254, 240, 241 }, 181));
            this._0x36738f83[_0x13340027].color = _0xd4e2f164 ? _0xfbd72b05.Gold : _0xfbd72b05.Sand;
        }
    }
}

internal static class _0x4808228b
{
    internal static string _0x15c46b35(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}