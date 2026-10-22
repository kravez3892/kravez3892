using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// Dresses the three template pops - WIN (7), LOSE (8), PAUSE (6) - completely, not just
/// their captions (rule C.3).
///
/// The template body of a pop is switched off and this game's own card is built in its place,
/// which settles four rules at once: no leftover "Score:" / "Reward:" labels (C.3), no
/// Lorem-Ipsum branch left dressed (C.15), no sprite-less close button drawn as a white
/// rectangle (B.1), and every button gets its own caption because each one is created here by
/// hand rather than found by walking a list (C.17).
///
/// Pop.Content ships inactive and Pop.Show() turns it on, so dressing happens AFTER ShowPop.
public sealed class _0x8a4f0b59 : MonoBehaviour
{
    /// The close cross gets a REAL sprite through a serialized reference. The template leaves
    /// its own cross Image empty, and Unity draws that as a solid white rectangle (B.1).
    private void _0x5515e4cf(RectTransform _0x2da2c20b, int _0x2b140bbf)
    {
        Button _0x94ebb6e7 = _0xcc3029b1.IconAction(_0x2da2c20b, _0x6dd4b47c._0x12b04e9a(new byte[5] { 221, 242, 241, 237, 251 }, 158), 0.885f, 0.925f, 96f, this._art.ButtonPlate, this._art.IconClose, _0xfbd72b05.Amber, _0xfbd72b05.Cream);
        if (_0x2b140bbf == _0x283dfe71._0x895c7d75.PAUSE)
        {
            _0x94ebb6e7.onClick.AddListener(() => this._director._0x3d73b3ab());
            return;
        }

        _0x94ebb6e7.onClick.AddListener(() => this._director._0x98583d98());
    }

    [SerializeField]
    private _0xae4301ee _director;
    private static readonly float _0x3299b2d0 = 1010f;
    [SerializeField]
    private TMP_FontAsset _font;
    public void _0x23bb95fb(_0xb371c2af _0x72acbbaf, long win, int _0x57520708, int _0x1e31c05e)
    {
        RectTransform _0x37e01df6 = this._0xa31a21df(_0x72acbbaf, _0x283dfe71._0x895c7d75.WIN);
        if (_0x37e01df6 == null)
        {
            return;
        }

        string _0x9d2453e8 = _0x57520708 >= 3 && _0x1e31c05e >= 0 ? (_0x57520708 + _0x6dd4b47c._0x12b04e9a(new byte[1] { 230 }, 198) + _0x97c3b88a.NameOf(_0x1e31c05e) + _0x6dd4b47c._0x12b04e9a(new byte[15] { 66, 45, 44, 66, 45, 44, 39, 66, 50, 35, 59, 46, 43, 44, 39 }, 98)) : _0x6dd4b47c._0x12b04e9a(new byte[26] { 4, 24, 21, 112, 7, 24, 31, 28, 21, 112, 24, 17, 28, 28, 112, 25, 3, 112, 19, 24, 21, 21, 2, 25, 30, 23 }, 80);
        this._0xc35f700b(_0x37e01df6, _0x6dd4b47c._0x12b04e9a(new byte[16] { 180, 188, 191, 183, 182, 189, 211, 160, 167, 178, 190, 163, 182, 183, 182, 210 }, 243), _0xfbd72b05.Gold);
        this._0x806fbfc3(_0x37e01df6, _0x6dd4b47c._0x12b04e9a(new byte[1] { 38 }, 13) + _0x61cef379.Grouped(win) + _0x6dd4b47c._0x12b04e9a(new byte[16] { 213, 179, 176, 166, 161, 188, 163, 180, 185, 213, 182, 186, 188, 187, 166, 255 }, 245) + _0x9d2453e8);
        Button _0x52fca659 = _0xcc3029b1.Action(_0x37e01df6, _0x6dd4b47c._0x12b04e9a(new byte[7] { 65, 109, 110, 110, 103, 97, 118 }, 2), 0.5f, 0.26f, 620f, 150f, this._art.CardPlate, this._font, _0x6dd4b47c._0x12b04e9a(new byte[7] { 8, 4, 7, 7, 14, 8, 31 }, 75), _0xfbd72b05.Gold, _0xfbd72b05.Bronze, _0xfbd72b05.Cream);
        _0x52fca659.onClick.AddListener(() => this._director._0x98583d98());
        this._0x5515e4cf(_0x37e01df6, _0x283dfe71._0x895c7d75.WIN);
    }

    [SerializeField]
    private _0xde8b9ebc _art;
    public void _0xcc4812c0(_0xb371c2af _0xac2801a1, long _0x183cf5e8)
    {
        RectTransform _0x9464a2e7 = this._0xa31a21df(_0xac2801a1, _0x283dfe71._0x895c7d75.LOSE);
        if (_0x9464a2e7 == null)
        {
            return;
        }

        this._0xc35f700b(_0x9464a2e7, _0x6dd4b47c._0x12b04e9a(new byte[16] { 53, 57, 63, 56, 86, 38, 35, 36, 37, 51, 86, 51, 59, 38, 34, 47 }, 118), _0xfbd72b05.CrimsonLit);
        this._0x806fbfc3(_0x9464a2e7, _0x6dd4b47c._0x12b04e9a(new byte[71] { 45, 49, 60, 89, 63, 60, 42, 45, 48, 47, 56, 53, 89, 63, 44, 55, 61, 89, 43, 60, 63, 48, 53, 53, 42, 89, 32, 54, 44, 43, 89, 41, 44, 43, 42, 60, 87, 115, 41, 53, 56, 32, 89, 52, 54, 55, 60, 32, 89, 54, 55, 53, 32, 89, 84, 89, 55, 54, 45, 49, 48, 55, 62, 89, 45, 54, 89, 59, 44, 32, 87 }, 121));
        Button _0xcedf40d0 = _0xcc3029b1.Action(_0x9464a2e7, _0x6dd4b47c._0x12b04e9a(new byte[5] { 131, 172, 161, 169, 173 }, 192), 0.5f, 0.26f, 620f, 150f, this._art.CardPlate, this._font, _0x6dd4b47c._0x12b04e9a(new byte[6] { 41, 38, 43, 35, 39, 74 }, 106) + _0x61cef379.Grouped(_0x183cf5e8), _0xfbd72b05.Gold, _0xfbd72b05.Bronze, _0xfbd72b05.Cream);
        _0xcedf40d0.onClick.AddListener(() => this._director._0xbf22c978());
        Button _0xbc43af2e = _0xcc3029b1.Action(_0x9464a2e7, _0x6dd4b47c._0x12b04e9a(new byte[5] { 0, 35, 46, 46, 53 }, 76), 0.5f, 0.115f, 620f, 132f, this._art.CardPlate, this._font, _0x6dd4b47c._0x12b04e9a(new byte[13] { 5, 6, 4, 12, 103, 19, 8, 103, 11, 8, 5, 5, 30 }, 71), _0xfbd72b05.Amber, _0xfbd72b05.BronzeLit, _0xfbd72b05.Cream);
        _0xbc43af2e.onClick.AddListener(() => this._director._0xd0b0706b());
    }

    private static readonly float _0x024d0bc1 = 1060f;
    private void _0x806fbfc3(RectTransform _0x7baa95fc, string _0x314c121c)
    {
        // Mark, header and body are spaced so no two boxes overlap: a 90pt header growing
        // into a 46pt body is the one collision autosize cannot resolve.
        RectTransform _0xc9ef0928 = _0xcc3029b1.Inner(_0x7baa95fc, _0x6dd4b47c._0x12b04e9a(new byte[8] { 213, 248, 243, 238, 195, 242, 239, 227 }, 151), 0f, -60f, _0x024d0bc1 - 140f, 170f);
        _0xcc3029b1.Label(_0xc9ef0928, this._font, _0x314c121c, 46f, _0xfbd72b05.Cream, TextAlignmentOptions.Center);
    }

    private void _0xc35f700b(RectTransform _0xd5dae4b4, string _0x99dfb99e, Color _0x45874c3f)
    {
        RectTransform _0x67dbbbd3 = _0xcc3029b1.Inner(_0xd5dae4b4, _0x6dd4b47c._0x12b04e9a(new byte[6] { 81, 124, 120, 125, 124, 107 }, 25), 0f, 130f, _0x024d0bc1 - 120f, 150f);
        _0xcc3029b1.Label(_0x67dbbbd3, this._font, _0x99dfb99e, 90f, _0x45874c3f, TextAlignmentOptions.Center);
    }

    /// Captions and handlers are captured when a card is built, so a cached card would offer
    /// the previous result's wording and run the previous handler. Rebuild every time.
    private RectTransform _0xa31a21df(_0xb371c2af _0x7f5e0c36, int _0xac4df83c)
    {
        if (_0x7f5e0c36 == null || _0x7f5e0c36.Content == null)
        {
            return null;
        }

        Transform _0x210891a6 = _0x7f5e0c36.Content.transform;
        RectTransform _0x10bf43ab;
        if (this._0x82c23cb8.TryGetValue(_0xac4df83c, out _0x10bf43ab) && _0x10bf43ab != null)
        {
            _0x10bf43ab.SetParent(null, false);
            Destroy(_0x10bf43ab.gameObject);
        }

        // Child 0 is the BASE_PANEL chrome of the pop and carries the themed surface; every
        // later branch is the template's own body and is switched off, not deleted.
        for (int _0x3aac60c4 = 1; _0x3aac60c4 < _0x210891a6.childCount; _0x3aac60c4++)
        {
            _0x210891a6.GetChild(_0x3aac60c4).gameObject.SetActive(false);
        }

        RectTransform _0x38d0560c = _0xcc3029b1.Node(_0x210891a6, _0x6dd4b47c._0x12b04e9a(new byte[10] { 63, 8, 30, 24, 1, 25, 46, 12, 31, 9 }, 109), 0.5f, 0.5f, _0x024d0bc1, _0x3299b2d0);
        _0x38d0560c.SetAsLastSibling();
        _0xcc3029b1.Plate(_0x38d0560c, this._art.CardPlate, _0xfbd72b05.Amber, 2.2f);
        RectTransform _0xaf2bb00f = _0xcc3029b1.Inner(_0x38d0560c, _0x6dd4b47c._0x12b04e9a(new byte[4] { 68, 105, 98, 127 }, 6), 0f, 0f, _0x024d0bc1 - 22f, _0x3299b2d0 - 22f);
        _0xcc3029b1.Plate(_0xaf2bb00f, this._art.CardPlate, _0xfbd72b05.Bronze, 2.2f);
        RectTransform _0xd86aadb1 = _0xcc3029b1.Inner(_0x38d0560c, _0x6dd4b47c._0x12b04e9a(new byte[4] { 138, 166, 181, 172 }, 199), 0f, 320f, 190f, 190f);
        _0xcc3029b1.Picture(_0xd86aadb1, this._art.EmblemMark, _0xfbd72b05.WithAlpha(Color.white, 0.95f));
        _0x38d0560c.localScale = Vector3.one * 0.94f;
        _0x38d0560c.DOScale(1f, 0.26f).SetEase(Ease.OutBack).SetLink(_0x38d0560c.gameObject);
        this._0x82c23cb8[_0xac4df83c] = _0x38d0560c;
        return _0x38d0560c;
    }

    private void OnDestroy()
    {
        DOTween.Kill(this);
    }

    public void _0x184be240(_0xb371c2af _0x959762f1, long _0x856ec57b, int _0x3caeb373)
    {
        RectTransform _0xc2cc8c43 = this._0xa31a21df(_0x959762f1, _0x283dfe71._0x895c7d75.PAUSE);
        if (_0xc2cc8c43 == null)
        {
            return;
        }

        this._0xc35f700b(_0xc2cc8c43, _0x6dd4b47c._0x12b04e9a(new byte[15] { 158, 157, 139, 140, 145, 142, 153, 148, 248, 136, 153, 141, 139, 157, 156 }, 216), _0xfbd72b05.GoldSoft);
        this._0x806fbfc3(_0xc2cc8c43, _0x6dd4b47c._0x12b04e9a(new byte[6] { 151, 155, 157, 154, 135, 244 }, 212) + _0x61cef379.Grouped(_0x856ec57b) + _0x6dd4b47c._0x12b04e9a(new byte[20] { 20, 77, 78, 87, 80, 77, 62, 74, 86, 87, 77, 62, 77, 91, 77, 77, 87, 81, 80, 62 }, 30) + _0x3caeb373);
        Button _0x28f81143 = _0xcc3029b1.Action(_0xc2cc8c43, _0x6dd4b47c._0x12b04e9a(new byte[6] { 100, 83, 69, 67, 91, 83 }, 54), 0.5f, 0.26f, 620f, 150f, this._art.CardPlate, this._font, _0x6dd4b47c._0x12b04e9a(new byte[6] { 249, 238, 248, 254, 230, 238 }, 171), _0xfbd72b05.Gold, _0xfbd72b05.Bronze, _0xfbd72b05.Cream);
        _0x28f81143.onClick.AddListener(() => this._director._0x3d73b3ab());
        Button _0x6c4f3fb6 = _0xcc3029b1.Action(_0xc2cc8c43, _0x6dd4b47c._0x12b04e9a(new byte[5] { 99, 64, 77, 77, 86 }, 47), 0.5f, 0.115f, 620f, 132f, this._art.CardPlate, this._font, _0x6dd4b47c._0x12b04e9a(new byte[13] { 101, 102, 100, 108, 7, 115, 104, 7, 107, 104, 101, 101, 126 }, 39), _0xfbd72b05.Amber, _0xfbd72b05.BronzeLit, _0xfbd72b05.Cream);
        _0x6c4f3fb6.onClick.AddListener(() => this._director._0xd0b0706b());
        this._0x5515e4cf(_0xc2cc8c43, _0x283dfe71._0x895c7d75.PAUSE);
    }

    private readonly System.Collections.Generic.Dictionary<int, RectTransform> _0x82c23cb8 = new System.Collections.Generic.Dictionary<int, RectTransform>();
}

internal static class _0x6dd4b47c
{
    internal static string _0x12b04e9a(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}