using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// The game scene's own HUD: top bar (back / purse / pause), the daily-objective meter, the
/// three readouts and the control panel. Nothing here hangs on a template placeholder - rule
/// C.2 asks for the game's own objects, and the template's TopPanel is switched off in the
/// scene so one consistent set of buttons ships.
///
/// Every button is driven from this component through a lambda (rule C.1): a method group,
/// here or in any other argument position, survives obfuscation only by luck.
public sealed class _0x48c0dec9 : MonoBehaviour
{
    private TextMeshProUGUI _0xfc5eee11;
    private TextMeshProUGUI _0xca33523a;
    public void _0x68138cc5(int _0xa577b9de, int _0x41b02e2c)
    {
        if (_0xa577b9de > 0)
        {
            _0x61cef379.SetText(this._0xe0af70a5, _0x2ca9c8e8._0xd3c159f5(new byte[5] { 90, 78, 79, 84, 59 }, 27) + _0xa577b9de + _0x2ca9c8e8._0xd3c159f5(new byte[3] { 175, 160, 175 }, 143) + _0x41b02e2c);
            this._0xe0af70a5.color = _0xfbd72b05.Gold;
            this._0x5d6c559f.color = _0xfbd72b05.Gold;
            return;
        }

        _0x61cef379.SetText(this._0xe0af70a5, _0x2ca9c8e8._0xd3c159f5(new byte[5] { 252, 232, 233, 242, 157 }, 189) + _0x41b02e2c);
        this._0xe0af70a5.color = _0xfbd72b05.Cream;
        this._0x5d6c559f.color = _0xfbd72b05.Amber;
    }

    public void _0xd9d4c8ca(_0xc2530753 _0xd6b4319c)
    {
        if (_0xd6b4319c == null)
        {
            _0x61cef379.SetText(this._0x3f88c7d6, _0x2ca9c8e8._0xd3c159f5(new byte[17] { 18, 31, 31, 115, 7, 18, 0, 24, 0, 115, 16, 31, 18, 26, 30, 22, 23 }, 83));
            _0x61cef379.SetText(this._0x3b2da656, _0x2ca9c8e8._0xd3c159f5(new byte[1] { 100 }, 73));
            this._0x355d6ded.sizeDelta = new Vector2(10f, this._0x355d6ded.sizeDelta.y);
            return;
        }

        _0x61cef379.SetText(this._0x3f88c7d6, _0xd6b4319c._0xa4552257());
        _0x61cef379.SetText(this._0x3b2da656, _0xd6b4319c.Progress + _0x2ca9c8e8._0xd3c159f5(new byte[3] { 79, 64, 79 }, 111) + _0xd6b4319c.Target);
        float _0x6928cbd7 = this._0xf0367466.sizeDelta.x - 8f;
        this._0x355d6ded.sizeDelta = new Vector2(Mathf.Max(10f, _0x6928cbd7 * _0xd6b4319c._0x457b84a2()), this._0x355d6ded.sizeDelta.y);
    }

    private Button _0x84e9cc0c;
    private TextMeshProUGUI _0x3b2da656;
    private Button _0x556b2950;
    private Image _0xa79f3584;
    private TextMeshProUGUI _0x4445f3f0;
    private _0xae4301ee _0x536f233d;
    private TextMeshProUGUI _0x181eefbb;
    public void _0x1a051971(long _0x09226b74)
    {
        _0x61cef379.SetText(this._0x4126e7a3, _0x61cef379.Grouped(_0x09226b74));
    }

    private RectTransform _0x355d6ded;
    private TMP_FontAsset _0x9b63f531;
    private TextMeshProUGUI _0xe95652fd(Transform _0x0a0924c5, string _0x3dcf0d74, float _0xe28fdd66, float _0x224f518c, Sprite _0x40496be5, TMP_FontAsset _0xa9778ea8, string _0xba2e3aac, Color _0xd319a6ab, bool _0xfa59377b)
    {
        RectTransform _0xdcdd198f = _0xcc3029b1.Node(_0x0a0924c5, _0x3dcf0d74, _0xe28fdd66, _0x224f518c, 366f, 128f);
        Image _0x25e48523 = _0xcc3029b1.Plate(_0xdcdd198f, _0x40496be5, _0xfbd72b05.Amber, 2f);
        RectTransform _0x025e4d5d = _0xcc3029b1.Inner(_0xdcdd198f, _0x2ca9c8e8._0xd3c159f5(new byte[4] { 174, 131, 136, 149 }, 236), 0f, 0f, 350f, 112f);
        _0xcc3029b1.Plate(_0x025e4d5d, _0x40496be5, _0xfbd72b05.Ink, 2f);
        RectTransform _0x85181bfd = _0xcc3029b1.Inner(_0xdcdd198f, _0x2ca9c8e8._0xd3c159f5(new byte[7] { 247, 213, 196, 192, 221, 219, 218 }, 180), 0f, 36f, 330f, 44f);
        _0xcc3029b1.Label(_0x85181bfd, _0xa9778ea8, _0xba2e3aac, 34f, _0xfbd72b05.Sand, TextAlignmentOptions.Center);
        RectTransform _0xc080655d = _0xcc3029b1.Inner(_0xdcdd198f, _0x2ca9c8e8._0xd3c159f5(new byte[5] { 78, 121, 116, 109, 125 }, 24), 0f, -22f, 330f, 60f);
        if (_0xfa59377b)
        {
            this._0xb8d5a859 = _0x25e48523;
        }

        return _0xcc3029b1.Label(_0xc080655d, _0xa9778ea8, _0x2ca9c8e8._0xd3c159f5(new byte[1] { 49 }, 1), 50f, _0xd319a6ab, TextAlignmentOptions.Center);
    }

    /// The spinning state has to be readable in a STILL frame, so the plate changes colour and
    /// the word on it changes too - not just an internal flag.
    public void _0x36f82b68(bool _0x9ab282fb)
    {
        this._0x7a4b4c12.interactable = !_0x9ab282fb;
        this._0xdbb384bd.interactable = !_0x9ab282fb;
        this._0x84e9cc0c.interactable = !_0x9ab282fb;
        _0x61cef379.SetText(this._0x181eefbb, _0x9ab282fb ? _0x2ca9c8e8._0xd3c159f5(new byte[8] { 228, 231, 254, 249, 249, 254, 249, 240 }, 183) : _0x2ca9c8e8._0xd3c159f5(new byte[4] { 79, 76, 85, 82 }, 28));
        this._0x181eefbb.color = _0x9ab282fb ? _0xfbd72b05.Sand : _0xfbd72b05.Cream;
        this._0x453b76b1.color = _0x9ab282fb ? _0xfbd72b05.WithAlpha(_0xfbd72b05.Muted, 0.85f) : _0xfbd72b05.WithAlpha(_0xfbd72b05.AmberDeep, 0.9f);
    }

    private RectTransform _0xf0367466;
    private Image _0xb8d5a859;
    private Button _0x7a4b4c12;
    public void _0xe9837470()
    {
        if (this._0xf5dc6fc7 == null)
        {
            return;
        }

        this._0xf5dc6fc7.transform.DOPunchScale(Vector3.one * 0.1f, 0.22f, 5, 0.6f).SetLink(this._0xf5dc6fc7.gameObject);
        this._0xb425d198.transform.DOPunchScale(Vector3.one * 0.1f, 0.22f, 5, 0.6f).SetLink(this._0xb425d198.gameObject);
    }

    public void _0x70137053(long win)
    {
        _0x61cef379.SetText(this._0xca33523a, win > 0L ? _0x61cef379.Grouped(win) : _0x2ca9c8e8._0xd3c159f5(new byte[1] { 90 }, 119));
    }

    private TextMeshProUGUI _0x3f88c7d6;
    private TextMeshProUGUI _0xe0af70a5;
    private Image _0x5d6c559f;
    public void _0x9896f975()
    {
        if (this._0xb8d5a859 == null)
        {
            return;
        }

        this._0xb8d5a859.color = _0xfbd72b05.Gold;
        this._0xb8d5a859.DOColor(_0xfbd72b05.Amber, 0.55f).SetLink(this._0xb8d5a859.gameObject);
    }

    private Button _0xdbb384bd;
    private Image _0xb425d198;
    public void _0xe3376cfa(Transform _0x74d36370, _0xae4301ee _0x68eb7442, TMP_FontAsset _0xe30447b3, Sprite _0xdc4837dd, Sprite _0x65d38a1a, Sprite _0xa5309ac2, Sprite _0x8a3e550a, Sprite _0x24f39979, Sprite _0x39fb0b4e, Sprite _0xcf39d54e)
    {
        this._0x536f233d = _0x68eb7442;
        this._0x9b63f531 = _0xe30447b3;
        // ── top bar ───────────────────────────────────────────────────────────
        Button _0xab92eb2b = _0xcc3029b1.IconAction(_0x74d36370, _0x2ca9c8e8._0xd3c159f5(new byte[10] { 236, 207, 205, 197, 236, 219, 218, 218, 193, 192 }, 174), 0.085f, 0.962f, 112f, _0xdc4837dd, _0x24f39979, _0xfbd72b05.Amber, _0xfbd72b05.Cream);
        _0xab92eb2b.onClick.AddListener(() => this._0x536f233d._0xd0b0706b());
        RectTransform _0xfdae48bb = _0xcc3029b1.Node(_0x74d36370, _0x2ca9c8e8._0xd3c159f5(new byte[10] { 153, 188, 187, 186, 172, 153, 165, 168, 189, 172 }, 201), 0.5f, 0.962f, 430f, 112f);
        _0xcc3029b1.Plate(_0xfdae48bb, _0x65d38a1a, _0xfbd72b05.Amber, 1.6f);
        RectTransform _0x83795ac7 = _0xcc3029b1.Inner(_0xfdae48bb, _0x2ca9c8e8._0xd3c159f5(new byte[4] { 104, 69, 78, 83 }, 42), 0f, 0f, 414f, 96f);
        _0xcc3029b1.Plate(_0x83795ac7, _0x65d38a1a, _0xfbd72b05.Bronze, 1.6f);
        RectTransform _0x00afb157 = _0xcc3029b1.Inner(_0xfdae48bb, _0x2ca9c8e8._0xd3c159f5(new byte[4] { 163, 143, 137, 142 }, 224), -158f, 0f, 60f, 60f);
        _0xcc3029b1.Picture(_0x00afb157, _0x8a3e550a, Color.white);
        RectTransform _0xac27af62 = _0xcc3029b1.Inner(_0xfdae48bb, _0x2ca9c8e8._0xd3c159f5(new byte[5] { 50, 5, 8, 17, 1 }, 100), 34f, 0f, 300f, 86f);
        this._0x4445f3f0 = _0xcc3029b1.Label(_0xac27af62, _0xe30447b3, _0x2ca9c8e8._0xd3c159f5(new byte[1] { 88 }, 104), 56f, _0xfbd72b05.Gold, TextAlignmentOptions.Center);
        Button _0x0e6ba02d = _0xcc3029b1.IconAction(_0x74d36370, _0x2ca9c8e8._0xd3c159f5(new byte[11] { 156, 173, 185, 191, 169, 142, 185, 184, 184, 163, 162 }, 204), 0.915f, 0.962f, 112f, _0xdc4837dd, _0x39fb0b4e, _0xfbd72b05.Amber, _0xfbd72b05.Cream);
        _0x0e6ba02d.onClick.AddListener(() => this._0x536f233d._0xd234f0a4());
        // ── daily-objective meter ─────────────────────────────────────────────
        RectTransform _0xd2b4841a = _0xcc3029b1.Node(_0x74d36370, _0x2ca9c8e8._0xd3c159f5(new byte[13] { 5, 38, 48, 55, 42, 53, 34, 47, 14, 38, 55, 38, 49 }, 67), 0.5f, 0.892f, 940f, 96f);
        _0xcc3029b1.Plate(_0xd2b4841a, _0x65d38a1a, _0xfbd72b05.Amber, 1.6f);
        RectTransform _0x8bb6aea8 = _0xcc3029b1.Inner(_0xd2b4841a, _0x2ca9c8e8._0xd3c159f5(new byte[4] { 201, 228, 239, 242 }, 139), 0f, 0f, 924f, 80f);
        _0xcc3029b1.Plate(_0x8bb6aea8, _0x65d38a1a, _0xfbd72b05.Bronze, 1.6f);
        RectTransform _0x2cc2fda2 = _0xcc3029b1.Inner(_0xd2b4841a, _0x2ca9c8e8._0xd3c159f5(new byte[5] { 198, 235, 232, 239, 230 }, 138), -210f, 0f, 460f, 60f);
        this._0x3f88c7d6 = _0xcc3029b1.Label(_0x2cc2fda2, _0xe30447b3, _0x2ca9c8e8._0xd3c159f5(new byte[13] { 232, 235, 253, 250, 231, 248, 239, 226, 142, 250, 239, 253, 229 }, 174), 38f, _0xfbd72b05.Sand, TextAlignmentOptions.Left);
        this._0xf0367466 = _0xcc3029b1.Inner(_0xd2b4841a, _0x2ca9c8e8._0xd3c159f5(new byte[5] { 164, 130, 145, 147, 155 }, 240), 180f, 0f, 400f, 30f);
        _0xcc3029b1.Plate(this._0xf0367466, _0x65d38a1a, _0xfbd72b05.Ink, 1.2f);
        this._0x355d6ded = _0xcc3029b1.Inner(this._0xf0367466, _0x2ca9c8e8._0xd3c159f5(new byte[4] { 182, 153, 156, 156 }, 240), 0f, 0f, 10f, 22f);
        this._0x355d6ded.anchorMin = new Vector2(0f, 0.5f);
        this._0x355d6ded.anchorMax = new Vector2(0f, 0.5f);
        this._0x355d6ded.pivot = new Vector2(0f, 0.5f);
        this._0x355d6ded.anchoredPosition = new Vector2(4f, 0f);
        _0xcc3029b1.Plate(this._0x355d6ded, _0x65d38a1a, _0xfbd72b05.Gold, 1.2f);
        RectTransform _0x7f21eb79 = _0xcc3029b1.Inner(_0xd2b4841a, _0x2ca9c8e8._0xd3c159f5(new byte[5] { 157, 177, 171, 176, 170 }, 222), 405f, 0f, 160f, 60f);
        this._0x3b2da656 = _0xcc3029b1.Label(_0x7f21eb79, _0xe30447b3, _0x2ca9c8e8._0xd3c159f5(new byte[5] { 123, 107, 100, 107, 123 }, 75), 40f, _0xfbd72b05.Gold, TextAlignmentOptions.Right);
        // ── control panel ─────────────────────────────────────────────────────
        RectTransform _0x76b2fb9f = _0xcc3029b1.Node(_0x74d36370, _0x2ca9c8e8._0xd3c159f5(new byte[12] { 202, 230, 231, 253, 251, 230, 229, 217, 232, 231, 236, 229 }, 137), 0.5f, 0.235f, 1180f, 1183f);
        _0xcc3029b1.Plate(_0x76b2fb9f, _0x65d38a1a, _0xfbd72b05.Amber, 2.4f);
        RectTransform _0x4189e91e = _0xcc3029b1.Inner(_0x76b2fb9f, _0x2ca9c8e8._0xd3c159f5(new byte[4] { 249, 212, 223, 194 }, 187), 0f, 0f, 1160f, 1163f);
        _0xcc3029b1.Plate(_0x4189e91e, _0x65d38a1a, _0xfbd72b05.Bronze, 2.4f);
        _0xcc3029b1.Caption(_0x74d36370, _0x2ca9c8e8._0xd3c159f5(new byte[11] { 33, 13, 12, 22, 16, 13, 14, 42, 11, 12, 22 }, 98), 0.30f, 0.405f, 580f, 70f, _0xe30447b3, _0x2ca9c8e8._0xd3c159f5(new byte[16] { 61, 40, 57, 73, 58, 57, 32, 39, 73, 61, 38, 73, 57, 37, 40, 48 }, 105), 38f, _0xfbd72b05.Sand);
        RectTransform _0xe837d989 = _0xcc3029b1.Node(_0x74d36370, _0x2ca9c8e8._0xd3c159f5(new byte[10] { 72, 124, 125, 102, 75, 124, 125, 125, 102, 103 }, 9), 0.845f, 0.405f, 300f, 104f);
        this._0x5d6c559f = _0xcc3029b1.Plate(_0xe837d989, _0x65d38a1a, _0xfbd72b05.Amber, 1.8f);
        this._0x5d6c559f.raycastTarget = true;
        RectTransform _0x2262b977 = _0xcc3029b1.Inner(_0xe837d989, _0x2ca9c8e8._0xd3c159f5(new byte[4] { 97, 76, 71, 90 }, 35), 0f, 0f, 284f, 88f);
        _0xcc3029b1.Plate(_0x2262b977, _0x65d38a1a, _0xfbd72b05.BronzeLit, 1.8f);
        this._0xe0af70a5 = _0xcc3029b1.Label(_0xe837d989, _0xe30447b3, _0x2ca9c8e8._0xd3c159f5(new byte[7] { 144, 132, 133, 158, 241, 224, 225 }, 209), 40f, _0xfbd72b05.Cream, TextAlignmentOptions.Center);
        this._0x556b2950 = _0xe837d989.gameObject.AddComponent<Button>();
        this._0x556b2950.targetGraphic = this._0x5d6c559f;
        this._0x556b2950.onClick.AddListener(() => this._0x536f233d._0xc5c19587());
        this._0xfc5eee11 = this._0xe95652fd(_0x74d36370, _0x2ca9c8e8._0xd3c159f5(new byte[10] { 136, 164, 162, 165, 184, 155, 167, 170, 191, 174 }, 203), 0.19f, 0.320f, _0x65d38a1a, _0xe30447b3, _0x2ca9c8e8._0xd3c159f5(new byte[5] { 58, 54, 48, 55, 42 }, 121), _0xfbd72b05.GoldSoft, false);
        this._0x4126e7a3 = this._0xe95652fd(_0x74d36370, _0x2ca9c8e8._0xd3c159f5(new byte[8] { 228, 195, 210, 246, 202, 199, 210, 195 }, 166), 0.50f, 0.320f, _0x65d38a1a, _0xe30447b3, _0x2ca9c8e8._0xd3c159f5(new byte[3] { 118, 113, 96 }, 52), _0xfbd72b05.Cream, false);
        this._0xca33523a = this._0xe95652fd(_0x74d36370, _0x2ca9c8e8._0xd3c159f5(new byte[8] { 79, 113, 118, 72, 116, 121, 108, 125 }, 24), 0.81f, 0.320f, _0x65d38a1a, _0xe30447b3, _0x2ca9c8e8._0xd3c159f5(new byte[8] { 122, 119, 101, 98, 22, 97, 127, 120 }, 54), _0xfbd72b05.Gold, true);
        RectTransform _0xec8db120 = _0xcc3029b1.Node(_0x74d36370, _0x2ca9c8e8._0xd3c159f5(new byte[7] { 22, 49, 32, 16, 59, 35, 58 }, 84), 0.15f, 0.175f, 170f, 170f);
        this._0xb425d198 = _0xcc3029b1.Plate(_0xec8db120, _0xdc4837dd, _0xfbd72b05.Amber, 1.3f);
        this._0xb425d198.raycastTarget = true;
        RectTransform _0xc7870bf7 = _0xcc3029b1.Inner(_0xec8db120, _0x2ca9c8e8._0xd3c159f5(new byte[4] { 164, 137, 130, 159 }, 230), 0f, 0f, 152f, 152f);
        _0xcc3029b1.Plate(_0xc7870bf7, _0xdc4837dd, _0xfbd72b05.BronzeLit, 1.3f);
        _0xcc3029b1.Label(_0xec8db120, _0xe30447b3, _0x2ca9c8e8._0xd3c159f5(new byte[1] { 2 }, 47), 72f, _0xfbd72b05.Cream, TextAlignmentOptions.Center);
        this._0xdbb384bd = _0xec8db120.gameObject.AddComponent<Button>();
        this._0xdbb384bd.targetGraphic = this._0xb425d198;
        this._0xdbb384bd.onClick.AddListener(() => this._0x536f233d._0x4ae7a63c(-1));
        RectTransform _0x7fdd1958 = _0xcc3029b1.Node(_0x74d36370, _0x2ca9c8e8._0xd3c159f5(new byte[10] { 98, 65, 88, 95, 115, 68, 69, 69, 94, 95 }, 49), 0.5f, 0.175f, 360f, 360f);
        this._0xa79f3584 = _0xcc3029b1.Plate(_0x7fdd1958, _0xa5309ac2, Color.white, 1.2f);
        this._0xa79f3584.raycastTarget = true;
        RectTransform _0x7b97d0e4 = _0xcc3029b1.Inner(_0x7fdd1958, _0x2ca9c8e8._0xd3c159f5(new byte[4] { 103, 74, 65, 92 }, 37), 0f, 0f, 250f, 250f);
        this._0x453b76b1 = _0xcc3029b1.Plate(_0x7b97d0e4, _0x65d38a1a, _0xfbd72b05.WithAlpha(_0xfbd72b05.AmberDeep, 0.9f), 1.2f);
        this._0x181eefbb = _0xcc3029b1.Label(_0x7fdd1958, _0xe30447b3, _0x2ca9c8e8._0xd3c159f5(new byte[4] { 63, 60, 37, 34 }, 108), 58f, _0xfbd72b05.Cream, TextAlignmentOptions.Center);
        this._0x7a4b4c12 = _0x7fdd1958.gameObject.AddComponent<Button>();
        this._0x7a4b4c12.targetGraphic = this._0xa79f3584;
        this._0x7a4b4c12.onClick.AddListener(() => this._0x536f233d._0x0d859af0());
        RectTransform _0x4a5baeb5 = _0xcc3029b1.Node(_0x74d36370, _0x2ca9c8e8._0xd3c159f5(new byte[5] { 211, 244, 229, 196, 225 }, 145), 0.85f, 0.175f, 170f, 170f);
        this._0xf5dc6fc7 = _0xcc3029b1.Plate(_0x4a5baeb5, _0xdc4837dd, _0xfbd72b05.Amber, 1.3f);
        this._0xf5dc6fc7.raycastTarget = true;
        RectTransform _0x0c50bb30 = _0xcc3029b1.Inner(_0x4a5baeb5, _0x2ca9c8e8._0xd3c159f5(new byte[4] { 138, 167, 172, 177 }, 200), 0f, 0f, 152f, 152f);
        _0xcc3029b1.Plate(_0x0c50bb30, _0xdc4837dd, _0xfbd72b05.BronzeLit, 1.3f);
        _0xcc3029b1.Label(_0x4a5baeb5, _0xe30447b3, _0x2ca9c8e8._0xd3c159f5(new byte[1] { 45 }, 6), 72f, _0xfbd72b05.Cream, TextAlignmentOptions.Center);
        this._0x84e9cc0c = _0x4a5baeb5.gameObject.AddComponent<Button>();
        this._0x84e9cc0c.targetGraphic = this._0xf5dc6fc7;
        this._0x84e9cc0c.onClick.AddListener(() => this._0x536f233d._0x4ae7a63c(1));
        _0xcc3029b1.Caption(_0x74d36370, _0x2ca9c8e8._0xd3c159f5(new byte[11] { 212, 253, 255, 249, 244, 222, 247, 247, 236, 253, 234 }, 152), 0.5f, 0.045f, 1060f, 60f, _0xe30447b3, _0x2ca9c8e8._0xd3c159f5(new byte[38] { 3, 31, 18, 10, 115, 30, 28, 29, 22, 10, 115, 28, 29, 31, 10, 115, 126, 115, 29, 28, 115, 16, 18, 0, 27, 115, 3, 1, 26, 9, 22, 0, 115, 126, 115, 98, 107, 120 }, 83), 36f, _0xfbd72b05.Sand);
    }

    private Image _0x453b76b1;
    private Image _0xf5dc6fc7;
    private TextMeshProUGUI _0x4126e7a3;
    // ── refreshes ────────────────────────────────────────────────────────────
    public void _0x5b0d2fc4(long _0x1b3bb41a)
    {
        _0x61cef379.SetText(this._0x4445f3f0, _0x61cef379.Grouped(_0x1b3bb41a));
        _0x61cef379.SetText(this._0xfc5eee11, _0x61cef379.Grouped(_0x1b3bb41a));
    }

    private void OnDestroy()
    {
        DOTween.Kill(this);
    }
}

internal static class _0x2ca9c8e8
{
    internal static string _0xd3c159f5(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}