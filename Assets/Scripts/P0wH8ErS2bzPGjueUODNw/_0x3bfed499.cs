using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// The festival lobby. Builds its own content into the template's DefaultPanel and dresses the
/// template's pre-wired scene-loading button, which renders nothing of its own.
///
/// TWO hosts, not one, and the split is forced by the template: that button is a sibling
/// inside DefaultPanel/Content, so a single host can only sit before it or after it - and the
/// lobby needs both. MenuBack (first sibling) holds the decor that must draw UNDER the button,
/// MenuFront (last sibling) holds the button's own face, the cards and the sheet that has to
/// cover it completely.
public sealed class _0x3bfed499 : MonoBehaviour
{
    private TextMeshProUGUI _0x9101c088;
    private Image _0x2b952957;
    private static readonly float _0xe0210b87 = 0.51f;
    private RectTransform _0xf3fe4320;
    private void _0x29cb0b14()
    {
        RectTransform _0x633d9978 = _0xcc3029b1.Node(this._0x16663670, _0x95a32079._0x3c545fdf(new byte[10] { 245, 196, 192, 210, 196, 211, 226, 192, 211, 197 }, 161), 0.5f, 0.490f, 940f, 170f);
        _0xcc3029b1.Plate(_0x633d9978, this._art.CardPlate, _0xfbd72b05.Amber, 2.2f);
        RectTransform _0x8409232b = _0xcc3029b1.Inner(_0x633d9978, _0x95a32079._0x3c545fdf(new byte[4] { 110, 67, 72, 85 }, 44), 0f, 0f, 922f, 152f);
        _0xcc3029b1.Plate(_0x8409232b, this._art.CardPlate, _0xfbd72b05.Bronze, 2.2f);
        RectTransform _0x8c5c047d = _0xcc3029b1.Inner(_0x633d9978, _0x95a32079._0x3c545fdf(new byte[5] { 78, 115, 110, 118, 127 }, 26), -30f, 34f, 740f, 56f);
        this._0x9101c088 = _0xcc3029b1.Label(_0x8c5c047d, this._font, _0x95a32079._0x3c545fdf(new byte[21] { 226, 249, 242, 247, 239, 145, 229, 150, 240, 243, 229, 226, 255, 224, 247, 250, 150, 226, 247, 229, 253 }, 182), 42f, _0xfbd72b05.Cream, TextAlignmentOptions.Left);
        this._0xa713fbe2 = _0xcc3029b1.Inner(_0x633d9978, _0x95a32079._0x3c545fdf(new byte[5] { 125, 91, 72, 74, 66 }, 41), -30f, -34f, 740f, 30f);
        _0xcc3029b1.Plate(this._0xa713fbe2, this._art.CardPlate, _0xfbd72b05.Ink, 1.2f);
        this._0xad31a6ca = _0xcc3029b1.Inner(this._0xa713fbe2, _0x95a32079._0x3c545fdf(new byte[4] { 5, 42, 47, 47 }, 67), 0f, 0f, 10f, 22f);
        this._0xad31a6ca.anchorMin = new Vector2(0f, 0.5f);
        this._0xad31a6ca.anchorMax = new Vector2(0f, 0.5f);
        this._0xad31a6ca.pivot = new Vector2(0f, 0.5f);
        this._0xad31a6ca.anchoredPosition = new Vector2(4f, 0f);
        _0xcc3029b1.Plate(this._0xad31a6ca, this._art.CardPlate, _0xfbd72b05.Gold, 1.2f);
        RectTransform _0x8e6087f8 = _0xcc3029b1.Inner(_0x633d9978, _0x95a32079._0x3c545fdf(new byte[5] { 194, 238, 244, 239, 245 }, 129), 380f, 0f, 150f, 70f);
        this._0x3506fa9d = _0xcc3029b1.Label(_0x8e6087f8, this._font, _0x95a32079._0x3c545fdf(new byte[5] { 96, 112, 127, 112, 96 }, 80), 46f, _0xfbd72b05.Gold, TextAlignmentOptions.Right);
    }

    private RectTransform _0xa713fbe2;
    private Image _0xc86c2a37;
    /// Choosing a festival scene re-tints the lobby decor on the spot - a change a screenshot
    /// can show, which is what rule C.7 asks of any button that changes something.
    public void _0x1e4d13ce(int _0x38c87396)
    {
        Color _0x66d6f422 = _0xfbd72b05.WithAlpha(_0xfbd72b05.Gold, 0.30f);
        Color _0x2a592fe3 = Color.white;
        if (_0x38c87396 == 1)
        {
            _0x66d6f422 = _0xfbd72b05.WithAlpha(_0xfbd72b05.CrimsonLit, 0.34f);
            _0x2a592fe3 = _0xfbd72b05.WithAlpha(_0xfbd72b05.CrimsonLit, 1f);
        }
        else if (_0x38c87396 == 2)
        {
            _0x66d6f422 = _0xfbd72b05.WithAlpha(_0xfbd72b05.GoldSoft, 0.42f);
            _0x2a592fe3 = _0xfbd72b05.WithAlpha(_0xfbd72b05.GoldSoft, 1f);
        }

        if (this._0x0d9a8425 != null)
        {
            this._0x0d9a8425.DOColor(_0x66d6f422, 0.35f).SetLink(this._0x0d9a8425.gameObject);
        }

        if (this._0xca086a24 != null)
        {
            this._0xca086a24.DOColor(_0x2a592fe3, 0.35f).SetLink(this._0xca086a24.gameObject);
        }
    }

    private int _0x68d9feda;
    private static readonly float _0x0e0a28e2 = 1989f;
    private _0xd978d0ff _0x280ba800;
    private void _0xef6c716f()
    {
        _0x19b9e3e8.Instance._0xcd25bcc1(_0x283dfe71._0xf15fd126.SCENE_1);
    }

    private TextMeshProUGUI _0x3506fa9d;
    // ── shared refreshes ─────────────────────────────────────────────────────
    public void _0xe77c0e43()
    {
        _0x61cef379.SetText(this._0x48424685, _0x61cef379.Grouped(_0x399a20a6.Purse()));
        _0xc2530753 _0x862ca801 = _0x399a20a6.Headline();
        if (_0x862ca801 == null || _0x399a20a6.AllClaimed())
        {
            _0x61cef379.SetText(this._0x9101c088, _0x95a32079._0x3c545fdf(new byte[23] { 122, 119, 119, 27, 111, 122, 104, 112, 104, 27, 120, 119, 122, 114, 118, 126, 127, 27, 111, 116, 127, 122, 98 }, 59));
            _0x61cef379.SetText(this._0x3506fa9d, _0x95a32079._0x3c545fdf(new byte[1] { 23 }, 58));
            this._0xad31a6ca.sizeDelta = new Vector2(10f, this._0xad31a6ca.sizeDelta.y);
            return;
        }

        _0x61cef379.SetText(this._0x9101c088, _0x862ca801._0xa4552257());
        _0x61cef379.SetText(this._0x3506fa9d, _0x862ca801.Progress + _0x95a32079._0x3c545fdf(new byte[3] { 19, 28, 19 }, 51) + _0x862ca801.Target);
        float _0x30c0b46b = this._0xa713fbe2.sizeDelta.x - 8f;
        this._0xad31a6ca.sizeDelta = new Vector2(Mathf.Max(10f, _0x30c0b46b * _0x862ca801._0x457b84a2()), this._0xad31a6ca.sizeDelta.y);
    }

    private RectTransform _0xbb7b68de;
    private TextMeshProUGUI _0x48424685;
    private void _0x354e802d()
    {
        RectTransform _0xb8bf9900 = _0xcc3029b1.Node(this._0x16663670, _0x95a32079._0x3c545fdf(new byte[10] { 98, 71, 64, 65, 87, 98, 94, 83, 70, 87 }, 50), 0.5f, 0.925f, 560f, 126f);
        _0xcc3029b1.Plate(_0xb8bf9900, this._art.CardPlate, _0xfbd72b05.Amber, 1.7f);
        RectTransform _0x09b930c4 = _0xcc3029b1.Inner(_0xb8bf9900, _0x95a32079._0x3c545fdf(new byte[4] { 139, 166, 173, 176 }, 201), 0f, 0f, 542f, 108f);
        _0xcc3029b1.Plate(_0x09b930c4, this._art.CardPlate, _0xfbd72b05.Bronze, 1.7f);
        RectTransform _0xd5861d6c = _0xcc3029b1.Inner(_0xb8bf9900, _0x95a32079._0x3c545fdf(new byte[4] { 235, 199, 193, 198 }, 168), -196f, 0f, 70f, 70f);
        _0xcc3029b1.Picture(_0xd5861d6c, this._art.SymCoin, Color.white);
        RectTransform _0x8d112296 = _0xcc3029b1.Inner(_0xb8bf9900, _0x95a32079._0x3c545fdf(new byte[5] { 122, 77, 64, 89, 73 }, 44), 36f, 0f, 400f, 92f);
        this._0x48424685 = _0xcc3029b1.Label(_0x8d112296, this._font, _0x95a32079._0x3c545fdf(new byte[1] { 148 }, 164), 56f, _0xfbd72b05.Gold, TextAlignmentOptions.Center);
        this._0xdc296fac(this._0x48424685);
        _0xcc3029b1.Caption(this._0x16663670, _0x95a32079._0x3c545fdf(new byte[12] { 148, 177, 182, 183, 161, 135, 165, 180, 176, 173, 171, 170 }, 196), 0.5f, 0.888f, 600f, 54f, this._font, _0x95a32079._0x3c545fdf(new byte[14] { 163, 160, 182, 177, 172, 179, 164, 169, 197, 166, 170, 172, 171, 182 }, 229), 36f, _0xfbd72b05.Sand);
        RectTransform _0x9a9372a4 = _0xcc3029b1.Node(this._0x16663670, _0x95a32079._0x3c545fdf(new byte[8] { 73, 100, 115, 110, 76, 96, 115, 106 }, 1), 0.5f, 0.780f, 360f, 360f);
        _0xcc3029b1.Picture(_0x9a9372a4, this._art.EmblemMark, Color.white);
        _0x9a9372a4.localScale = Vector3.one;
        _0x9a9372a4.DOScale(1.035f, 1.8f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo).SetLink(_0x9a9372a4.gameObject);
    }

    /// The always-on onboarding. A first-run modal would be the first thing a cold-launched
    /// capture photographs and would offset every blind tap by one screen (rule F.0b), so the
    /// rules live here and in the settings sheet instead, and the template tutorial stays off.
    private void _0x5e2f56f2()
    {
        this._0xdd7226fc(0.19f, _0x95a32079._0x3c545fdf(new byte[1] { 117 }, 68), _0x95a32079._0x3c545fdf(new byte[4] { 108, 111, 118, 113 }, 63), _0x95a32079._0x3c545fdf(new byte[7] { 148, 149, 158, 251, 143, 154, 139 }, 219));
        this._0xdd7226fc(0.50f, _0x95a32079._0x3c545fdf(new byte[1] { 198 }, 244), _0x95a32079._0x3c545fdf(new byte[8] { 31, 19, 6, 17, 26, 114, 97, 121 }, 82), _0x95a32079._0x3c545fdf(new byte[13] { 220, 213, 214, 196, 176, 196, 223, 176, 194, 217, 215, 216, 196 }, 144));
        this._0xdd7226fc(0.81f, _0x95a32079._0x3c545fdf(new byte[1] { 102 }, 85), _0x95a32079._0x3c545fdf(new byte[7] { 236, 224, 227, 227, 234, 236, 251 }, 175), _0x95a32079._0x3c545fdf(new byte[13] { 39, 32, 53, 57, 36, 84, 49, 57, 54, 56, 49, 57, 39 }, 116));
    }

    private RectTransform _0x2428cd89;
    private void _0xdd7226fc(float _0xeb18afcf, string _0xd481f04a, string _0xce0ed1cf, string _0x280ebffe)
    {
        RectTransform _0x970fb850 = _0xcc3029b1.Node(this._0x16663670, _0x95a32079._0x3c545fdf(new byte[7] { 40, 15, 23, 35, 1, 18, 4 }, 96), _0xeb18afcf, 0.625f, 330f, 190f);
        _0xcc3029b1.Plate(_0x970fb850, this._art.CardPlate, _0xfbd72b05.Amber, 2.6f);
        RectTransform _0xacba78c7 = _0xcc3029b1.Inner(_0x970fb850, _0x95a32079._0x3c545fdf(new byte[4] { 133, 168, 163, 190 }, 199), 0f, 0f, 314f, 174f);
        _0xcc3029b1.Plate(_0xacba78c7, this._art.CardPlate, _0xfbd72b05.Bronze, 2.6f);
        RectTransform _0x360f0b86 = _0xcc3029b1.Inner(_0x970fb850, _0x95a32079._0x3c545fdf(new byte[5] { 11, 40, 45, 46, 44 }, 73), 0f, 52f, 64f, 64f);
        _0xcc3029b1.Plate(_0x360f0b86, this._art.ButtonPlate, _0xfbd72b05.Gold, 1.2f);
        _0xcc3029b1.Label(_0x360f0b86, this._font, _0xd481f04a, 38f, _0xfbd72b05.Ink, TextAlignmentOptions.Center);
        RectTransform _0x9cfc89d8 = _0xcc3029b1.Inner(_0x970fb850, _0x95a32079._0x3c545fdf(new byte[5] { 33, 28, 1, 25, 16 }, 117), 0f, -4f, 300f, 54f);
        _0xcc3029b1.Label(_0x9cfc89d8, this._font, _0xce0ed1cf, 44f, _0xfbd72b05.GoldSoft, TextAlignmentOptions.Center);
        RectTransform _0xf512af8e = _0xcc3029b1.Inner(_0x970fb850, _0x95a32079._0x3c545fdf(new byte[4] { 193, 224, 251, 234 }, 143), 0f, -56f, 300f, 48f);
        _0xcc3029b1.Label(_0xf512af8e, this._font, _0x280ebffe, 34f, _0xfbd72b05.Sand, TextAlignmentOptions.Center);
    }

    [SerializeField]
    private _0xde8b9ebc _art;
    public int _0x181f056d()
    {
        return this._0x68d9feda;
    }

    private void _0xcfd6a1f8()
    {
        Button _0x27964c20 = _0xcc3029b1.Action(this._0x16663670, _0x95a32079._0x3c545fdf(new byte[16] { 56, 19, 26, 23, 23, 30, 21, 28, 30, 8, 57, 14, 15, 15, 20, 21 }, 123), 0.19f, 0.210f, 346f, 132f, this._art.CardPlate, this._font, _0x95a32079._0x3c545fdf(new byte[5] { 40, 61, 47, 55, 47 }, 124), _0xfbd72b05.Amber, _0xfbd72b05.BronzeLit, _0xfbd72b05.Cream);
        _0x27964c20.onClick.AddListener(() => this._0x66b45c84(1));
        Button _0x0d3b3dc2 = _0xcc3029b1.Action(this._0x16663670, _0x95a32079._0x3c545fdf(new byte[16] { 72, 100, 103, 103, 110, 104, 127, 98, 100, 101, 73, 126, 127, 127, 100, 101 }, 11), 0.50f, 0.210f, 346f, 132f, this._art.CardPlate, this._font, _0x95a32079._0x3c545fdf(new byte[10] { 210, 222, 221, 221, 212, 210, 197, 216, 222, 223 }, 145), _0xfbd72b05.Amber, _0xfbd72b05.BronzeLit, _0xfbd72b05.Cream);
        _0x0d3b3dc2.onClick.AddListener(() => this._0x66b45c84(0));
        Button _0x32b1466e = _0xcc3029b1.Action(this._0x16663670, _0x95a32079._0x3c545fdf(new byte[14] { 36, 18, 3, 3, 30, 25, 16, 4, 53, 2, 3, 3, 24, 25 }, 119), 0.81f, 0.210f, 346f, 132f, this._art.CardPlate, this._font, _0x95a32079._0x3c545fdf(new byte[8] { 174, 184, 169, 169, 180, 179, 186, 174 }, 253), _0xfbd72b05.Amber, _0xfbd72b05.BronzeLit, _0xfbd72b05.Cream);
        _0x32b1466e.onClick.AddListener(() => this._0x66b45c84(2));
        _0xcc3029b1.Caption(this._0x16663670, _0x95a32079._0x3c545fdf(new byte[11] { 253, 212, 214, 208, 221, 247, 222, 222, 197, 212, 195 }, 177), 0.5f, 0.075f, 1100f, 60f, this._font, _0x95a32079._0x3c545fdf(new byte[38] { 107, 119, 122, 98, 27, 118, 116, 117, 126, 98, 27, 116, 117, 119, 98, 27, 22, 27, 117, 116, 27, 120, 122, 104, 115, 27, 107, 105, 114, 97, 126, 104, 27, 22, 27, 10, 3, 16 }, 59), 36f, _0xfbd72b05.Sand);
    }

    private Image _0xca086a24;
    private TextMeshProUGUI _0xcb994c78;
    [SerializeField]
    private TMP_FontAsset _font;
    private _0xc155806c _0xd00d9d21;
    /// Tab 0 collection, tab 1 daily tasks, tab 2 settings. The chosen tab is visibly
    /// distinguished - gold on amber against sand on bronze - so the selection reads in a
    /// still frame (rule C.7).
    private void _0x9f6be992(int _0x90e0655f)
    {
        this._0x68d9feda = _0x90e0655f;
        bool _0xa00c2872 = _0x90e0655f != 2;
        this._0x8c35c090.gameObject.SetActive(_0xa00c2872);
        this._0xd00d9d21._0xcd5c7864(_0x90e0655f == 0);
        this._0x9f10e15e._0x3e22b9a6(_0x90e0655f == 1);
        this._0x280ba800._0x4ac5dacc(_0x90e0655f == 2);
        this._0x2b952957.color = _0x90e0655f == 0 ? _0xfbd72b05.Gold : _0xfbd72b05.Amber;
        this._0xc86c2a37.color = _0x90e0655f == 1 ? _0xfbd72b05.Gold : _0xfbd72b05.Amber;
        this._0xdfa81db4.color = _0x90e0655f == 0 ? _0xfbd72b05.Gold : _0xfbd72b05.Sand;
        this._0xcb994c78.color = _0x90e0655f == 1 ? _0xfbd72b05.Gold : _0xfbd72b05.Sand;
        if (_0x90e0655f == 0)
        {
            this._0xd00d9d21._0x4130137b();
        }
        else if (_0x90e0655f == 1)
        {
            this._0x9f10e15e._0xaa618c12();
        }
        else
        {
            this._0x280ba800._0xfcc0a4ec();
        }
    }

    private RectTransform _0xad31a6ca;
    private TextMeshProUGUI _0xdfa81db4;
    private _0xbea032fb _0x9f10e15e;
    /// The menu scene template ships no coin readout of its own, so the purse plate built
    /// above becomes one: the template's MoneyCount component is put on the same label and
    /// added to the list BasicController refreshes, which is how the coin store announces a
    /// change. Nothing is hung on a template placeholder - this is our own object carrying a
    /// template component (rule C.2).
    private void _0xdc296fac(TextMeshProUGUI _0x399c1667)
    {
        if (_0x399c1667 == null)
        {
            return;
        }

        _0xa82a8197 _0xb8152888 = _0x399c1667.gameObject.AddComponent<_0xa82a8197>();
        _0xb8152888.MoneyCountText = _0x399c1667;
        _0x19b9e3e8 _0xafa31376 = _0x19b9e3e8.Instance;
        if (_0xafa31376 != null && _0xafa31376.MoneyCountContainers != null)
        {
            _0xafa31376.MoneyCountContainers.Add(_0xb8152888);
        }
    }

    // ── overlay sheet ────────────────────────────────────────────────────────
    private void _0x0eb9a1bd()
    {
        this._0x2428cd89 = _0xcc3029b1.Stretch(this._0x16663670, _0x95a32079._0x3c545fdf(new byte[8] { 233, 210, 223, 223, 206, 254, 211, 215 }, 186));
        Image _0x91cf0e0c = _0xcc3029b1.Wash(this._0x2428cd89, _0xfbd72b05.Dim);
        _0x91cf0e0c.raycastTarget = true;
        this._0xf3fe4320 = _0xcc3029b1.Node(this._0x2428cd89, _0x95a32079._0x3c545fdf(new byte[9] { 12, 55, 58, 58, 43, 28, 62, 45, 59 }, 95), 0.5f, _0xe0210b87, _0x24104e9d, _0x0e0a28e2);
        _0xcc3029b1.Plate(this._0xf3fe4320, this._art.CardPlate, _0xfbd72b05.Amber, 2.6f);
        RectTransform _0x880833f8 = _0xcc3029b1.Inner(this._0xf3fe4320, _0x95a32079._0x3c545fdf(new byte[4] { 11, 38, 45, 48 }, 73), 0f, 0f, _0x24104e9d - 22f, _0x0e0a28e2 - 22f);
        _0xcc3029b1.Plate(_0x880833f8, this._art.CardPlate, _0xfbd72b05.Bronze, 2.6f);
        // 0.37 of the card height, not 0.30: at 0.30 the strip ran into the top of SheetBody
        // and the tab a player taps was drawn under each page's own title.
        this._0x8c35c090 = _0xcc3029b1.Inner(this._0xf3fe4320, _0x95a32079._0x3c545fdf(new byte[4] { 104, 93, 94, 79 }, 60), 0f, (_0x0e0a28e2 * 0.37f), _0x24104e9d, 130f);
        this._0x2b952957 = this._0xb2276b43(this._0x8c35c090, -238f, _0x95a32079._0x3c545fdf(new byte[10] { 228, 232, 235, 235, 226, 228, 243, 238, 232, 233 }, 167), 0);
        this._0xc86c2a37 = this._0xb2276b43(this._0x8c35c090, 238f, _0x95a32079._0x3c545fdf(new byte[5] { 121, 108, 126, 102, 126 }, 45), 1);
        // The cross sits ABOVE the tab strip, in the card's own header band: at 0.845 it
        // clipped the right-hand tab's top corner.
        Button _0xe6e1f7d6 = _0xcc3029b1.IconAction(this._0xf3fe4320, _0x95a32079._0x3c545fdf(new byte[10] { 189, 134, 139, 139, 154, 173, 130, 129, 157, 139 }, 238), 0.875f, 0.94f, 104f, this._art.ButtonPlate, this._art.IconClose, _0xfbd72b05.Amber, _0xfbd72b05.Cream);
        _0xe6e1f7d6.onClick.AddListener(() => this._0x37d12efc());
        this._0x54d3f821 = _0xcc3029b1.Inner(this._0xf3fe4320, _0x95a32079._0x3c545fdf(new byte[9] { 165, 158, 147, 147, 130, 180, 153, 146, 143 }, 246), 0f, -90f, _0x24104e9d - 60f, _0x0e0a28e2 * 0.74f);
        Button _0xb500a3f9 = _0xcc3029b1.Action(this._0xf3fe4320, _0x95a32079._0x3c545fdf(new byte[9] { 70, 125, 112, 112, 97, 69, 121, 116, 108 }, 21), 0.5f, 0.06f, 560f, 150f, this._art.CardPlate, this._font, _0x95a32079._0x3c545fdf(new byte[4] { 143, 147, 158, 134 }, 223), _0xfbd72b05.Gold, _0xfbd72b05.AmberDeep, _0xfbd72b05.Cream);
        _0xb500a3f9.onClick.AddListener(() => this._0xef6c716f());
        GameObject _0xefccb7b0 = new GameObject(_0x95a32079._0x3c545fdf(new byte[14] { 150, 189, 180, 185, 185, 176, 187, 178, 176, 151, 186, 180, 167, 177 }, 213), typeof(RectTransform));
        RectTransform _0xb936f747 = _0xefccb7b0.GetComponent<RectTransform>();
        _0xb936f747.SetParent(this._0x54d3f821, false);
        _0xb936f747.anchorMin = Vector2.zero;
        _0xb936f747.anchorMax = Vector2.one;
        _0xb936f747.offsetMin = Vector2.zero;
        _0xb936f747.offsetMax = Vector2.zero;
        this._0x9f10e15e = _0xefccb7b0.AddComponent<_0xbea032fb>();
        this._0x9f10e15e._0xa47bc86f(_0xb936f747, this, this._art, this._font);
        GameObject _0x8c6dd38b = new GameObject(_0x95a32079._0x3c545fdf(new byte[9] { 19, 62, 48, 39, 63, 21, 32, 59, 54 }, 82), typeof(RectTransform));
        RectTransform _0xc0e469bf = _0x8c6dd38b.GetComponent<RectTransform>();
        _0xc0e469bf.SetParent(this._0x54d3f821, false);
        _0xc0e469bf.anchorMin = Vector2.zero;
        _0xc0e469bf.anchorMax = Vector2.one;
        _0xc0e469bf.offsetMin = Vector2.zero;
        _0xc0e469bf.offsetMax = Vector2.zero;
        this._0xd00d9d21 = _0x8c6dd38b.AddComponent<_0xc155806c>();
        this._0xd00d9d21._0x75b1a9ed(_0xc0e469bf, this._art, this._font);
        GameObject _0x215d1c70 = new GameObject(_0x95a32079._0x3c545fdf(new byte[13] { 86, 96, 113, 113, 108, 107, 98, 118, 86, 109, 96, 96, 113 }, 5), typeof(RectTransform));
        RectTransform _0x4600d20d = _0x215d1c70.GetComponent<RectTransform>();
        _0x4600d20d.SetParent(this._0x54d3f821, false);
        _0x4600d20d.anchorMin = Vector2.zero;
        _0x4600d20d.anchorMax = Vector2.one;
        _0x4600d20d.offsetMin = Vector2.zero;
        _0x4600d20d.offsetMax = Vector2.zero;
        this._0x280ba800 = _0x215d1c70.AddComponent<_0xd978d0ff>();
        this._0x280ba800._0xd427fa11(_0x4600d20d, this, this._art, this._font);
        this._0x2428cd89.gameObject.SetActive(false);
    }

    // ── lobby ────────────────────────────────────────────────────────────────
    private void _0xbe9aec67()
    {
        RectTransform _0xc2db187a = _0xcc3029b1.Node(this._0xbb7b68de, _0x95a32079._0x3c545fdf(new byte[7] { 93, 123, 104, 118, 123, 116, 126 }, 26), 0.5f, 0.952f, 1220f, 170f);
        this._0xca086a24 = _0xcc3029b1.Picture(_0xc2db187a, this._art.DecorGarland, Color.white);
        _0xc2db187a.localEulerAngles = new Vector3(0f, 0f, -2.4f);
        _0xc2db187a.DOLocalRotate(new Vector3(0f, 0f, 2.4f), 3.4f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo).SetLink(_0xc2db187a.gameObject);
        RectTransform _0x442998f4 = _0xcc3029b1.Node(this._0xbb7b68de, _0x95a32079._0x3c545fdf(new byte[8] { 141, 160, 183, 170, 130, 169, 170, 178 }, 197), 0.5f, 0.780f, 540f, 540f);
        this._0x0d9a8425 = _0xcc3029b1.Picture(_0x442998f4, this._art.PaylineGlow, _0xfbd72b05.WithAlpha(_0xfbd72b05.Gold, 0.3f));
        _0x442998f4.DOLocalRotate(new Vector3(0f, 0f, 360f), 22f, RotateMode.FastBeyond360).SetEase(Ease.Linear).SetLoops(-1, LoopType.Restart).SetLink(_0x442998f4.gameObject);
    }

    private static readonly float _0x24104e9d = 1068f;
    private Image _0x0d9a8425;
    /// The template's scene-loading button renders nothing (its decorative layers are switched
    /// off in the variant), so the face is drawn as an own node over the SAME rect, with every
    /// graphic raycast-transparent so the tap still reaches the real button underneath.
    private void _0x45ff099f()
    {
        RectTransform _0x83309949 = _0xcc3029b1.Node(this._0x16663670, _0x95a32079._0x3c545fdf(new byte[8] { 102, 90, 87, 79, 112, 87, 85, 83 }, 54), 0.5f, 0.345f, 780f, 176f);
        if (this._playRect != null)
        {
            _0xcc3029b1.Fit(_0x83309949, this._playRect);
        }

        _0xcc3029b1.Plate(_0x83309949, this._art.CardPlate, _0xfbd72b05.Gold, 1.6f);
        RectTransform _0x1bcefddb = _0xcc3029b1.Inner(_0x83309949, _0x95a32079._0x3c545fdf(new byte[4] { 133, 168, 163, 190 }, 199), 0f, 0f, 760f, 156f);
        _0xcc3029b1.Plate(_0x1bcefddb, this._art.CardPlate, _0xfbd72b05.AmberDeep, 1.6f);
        RectTransform _0x5d05e09b = _0xcc3029b1.Inner(_0x83309949, _0x95a32079._0x3c545fdf(new byte[4] { 100, 72, 78, 73 }, 39), -186f, 0f, 56f, 56f);
        _0xcc3029b1.Picture(_0x5d05e09b, this._art.SymCoin, Color.white);
        RectTransform _0xd1d7ee48 = _0xcc3029b1.Inner(_0x83309949, _0x95a32079._0x3c545fdf(new byte[7] { 144, 178, 163, 167, 186, 188, 189 }, 211), 32f, 0f, 520f, 90f);
        _0xcc3029b1.Label(_0xd1d7ee48, this._font, _0x95a32079._0x3c545fdf(new byte[4] { 195, 223, 210, 202 }, 147), 58f, _0xfbd72b05.Cream, TextAlignmentOptions.Center);
        _0x83309949.localScale = Vector3.one;
        _0x83309949.DOScale(1.025f, 1.25f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo).SetLink(_0x83309949.gameObject);
    }

    private RectTransform _0x8c35c090;
    public void _0x66b45c84(int _0x5ae71ef7)
    {
        this._0x2428cd89.gameObject.SetActive(true);
        this._0xf3fe4320.localScale = Vector3.one * 0.95f;
        this._0xf3fe4320.DOScale(1f, 0.22f).SetEase(Ease.OutBack).SetLink(this._0xf3fe4320.gameObject);
        this._0x9f6be992(_0x5ae71ef7);
    }

    private RectTransform _0x16663670;
    private RectTransform _0x54d3f821;
    private Image _0xb2276b43(RectTransform _0x0a94303c, float _0x7de7bf05, string _0xf031e274, int _0x992d1e20)
    {
        RectTransform _0x7c80cc7e = _0xcc3029b1.Inner(_0x0a94303c, _0x95a32079._0x3c545fdf(new byte[3] { 90, 111, 108 }, 14), _0x7de7bf05, 0f, 430f, 116f);
        Image _0xee2ad3c6 = _0xcc3029b1.Plate(_0x7c80cc7e, this._art.CardPlate, _0xfbd72b05.Amber, 2f);
        _0xee2ad3c6.raycastTarget = true;
        RectTransform _0xc62f2c07 = _0xcc3029b1.Inner(_0x7c80cc7e, _0x95a32079._0x3c545fdf(new byte[4] { 173, 128, 139, 150 }, 239), 0f, 0f, 414f, 100f);
        _0xcc3029b1.Plate(_0xc62f2c07, this._art.CardPlate, _0xfbd72b05.BronzeLit, 2f);
        TextMeshProUGUI _0xef538f44 = _0xcc3029b1.Label(_0x7c80cc7e, this._font, _0xf031e274, 42f, _0xfbd72b05.Sand, TextAlignmentOptions.Center);
        Button _0x57a9193c = _0x7c80cc7e.gameObject.AddComponent<Button>();
        _0x57a9193c.targetGraphic = _0xee2ad3c6;
        int _0x3fd9a7f0 = _0x992d1e20;
        _0x57a9193c.onClick.AddListener(() => this._0x9f6be992(_0x3fd9a7f0));
        if (_0x992d1e20 == 0)
        {
            this._0xdfa81db4 = _0xef538f44;
        }
        else
        {
            this._0xcb994c78 = _0xef538f44;
        }

        return _0xee2ad3c6;
    }

    private void Start()
    {
        _0x399a20a6.EnsureReady();
        _0xb5c3d2c9 _0xff4e29a3 = _0xb5c3d2c9.Instance;
        if (_0xff4e29a3 == null || _0xff4e29a3.Panels == null || _0x283dfe71._0x0485a4d3.DEFAULT >= _0xff4e29a3.Panels.Count)
        {
            return;
        }

        _0x126eaf94 _0x2c7d1823 = _0xff4e29a3.Panels[_0x283dfe71._0x0485a4d3.DEFAULT];
        if (_0x2c7d1823 == null || _0x2c7d1823.Content == null)
        {
            return;
        }

        Transform _0x3b620ae5 = _0x2c7d1823.Content.transform;
        this._0xbb7b68de = _0xcc3029b1.Stretch(_0x3b620ae5, _0x95a32079._0x3c545fdf(new byte[9] { 62, 29, 16, 16, 11, 48, 19, 17, 25 }, 114));
        this._0xbb7b68de.SetAsFirstSibling();
        this._0x16663670 = _0xcc3029b1.Stretch(_0x3b620ae5, _0x95a32079._0x3c545fdf(new byte[10] { 163, 128, 141, 141, 150, 169, 157, 128, 129, 155 }, 239));
        this._0x16663670.SetAsLastSibling();
        this._0xbe9aec67();
        this._0x354e802d();
        this._0x5e2f56f2();
        this._0x29cb0b14();
        this._0x45ff099f();
        this._0xcfd6a1f8();
        this._0x0eb9a1bd();
        this._0x1e4d13ce(_0x399a20a6.FestivalScene());
        this._0xe77c0e43();
        // The template's own MoneyCount writes a bare integer into the purse the moment the
        // coin store changes, and its Start runs after this one. One delayed pass puts the
        // grouped reading back, so the two never disagree on screen.
        DOVirtual.DelayedCall(0.05f, () => this._0xe77c0e43()).SetLink(this.gameObject);
    }

    public void _0x37d12efc()
    {
        this._0x2428cd89.gameObject.SetActive(false);
        this._0xe77c0e43();
    }

    private void OnDestroy()
    {
        DOTween.Kill(this);
        if (this._0x0d9a8425 != null)
        {
            DOTween.Kill(this._0x0d9a8425);
        }

        if (this._0xca086a24 != null)
        {
            DOTween.Kill(this._0xca086a24);
        }
    }

    [SerializeField]
    private RectTransform _playRect;
}

internal static class _0x95a32079
{
    internal static string _0x3c545fdf(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}