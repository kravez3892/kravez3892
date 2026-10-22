using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// The settings sheet. Four rows, and every one of them really does something the screen can
/// show (rule C.7): the vibration pill fires the motor as it turns on, picking a festival
/// scene re-tints the lobby decor on the spot, HOW TO PLAY expands in place, and RESET asks
/// for a confirmation in the same row before it wipes anything.
///
/// There is NO sound or music control here, and none anywhere else: these games ship without
/// audio, so a speaker toggle would be a control with nothing behind it (rule C.20). The row
/// it would have taken is the vibration pill.
public sealed class _0xd978d0ff : MonoBehaviour
{
    private readonly List<TextMeshProUGUI> _0x246c7c13 = new List<TextMeshProUGUI>();
    private Image _0xa8884b4b;
    public void _0xd427fa11(RectTransform _0xf8ab4632, _0x3bfed499 _0xea6a7709, _0xde8b9ebc _0xaf9c0c69, TMP_FontAsset _0xef21f014)
    {
        this._0xd7d17072 = _0xf8ab4632;
        this._0x75169a18 = _0xea6a7709;
        _0xcc3029b1.Caption(_0xf8ab4632, _0xa767a38a._0x93d25e47(new byte[13] { 194, 244, 229, 229, 248, 255, 246, 226, 197, 248, 229, 253, 244 }, 145), 0.5f, 0.950f, 900f, 72f, _0xef21f014, _0xa767a38a._0x93d25e47(new byte[8] { 247, 225, 240, 240, 237, 234, 227, 247 }, 164), 52f, _0xfbd72b05.GoldSoft);
        // ── vibration ─────────────────────────────────────────────────────────
        RectTransform _0x676e3dc1 = _0xcc3029b1.Node(_0xf8ab4632, _0xa767a38a._0x93d25e47(new byte[10] { 221, 226, 233, 249, 234, 255, 238, 217, 228, 252 }, 139), 0.5f, 0.862f, 940f, 128f);
        _0xcc3029b1.Plate(_0x676e3dc1, _0xaf9c0c69.CardPlate, _0xfbd72b05.Amber, 2.2f);
        RectTransform _0x0d4e3d21 = _0xcc3029b1.Inner(_0x676e3dc1, _0xa767a38a._0x93d25e47(new byte[4] { 63, 18, 25, 4 }, 125), 0f, 0f, 922f, 110f);
        _0xcc3029b1.Plate(_0x0d4e3d21, _0xaf9c0c69.CardPlate, _0xfbd72b05.Bronze, 2.2f);
        RectTransform _0xe279adbe = _0xcc3029b1.Inner(_0x676e3dc1, _0xa767a38a._0x93d25e47(new byte[5] { 215, 250, 249, 254, 247 }, 155), -230f, 0f, 420f, 64f);
        _0xcc3029b1.Label(_0xe279adbe, _0xef21f014, _0xa767a38a._0x93d25e47(new byte[9] { 65, 94, 85, 69, 86, 67, 94, 88, 89 }, 23), 44f, _0xfbd72b05.Cream, TextAlignmentOptions.Left);
        RectTransform _0xbb8febe7 = _0xcc3029b1.Inner(_0x676e3dc1, _0xa767a38a._0x93d25e47(new byte[4] { 188, 133, 128, 128 }, 236), 300f, 0f, 260f, 92f);
        this._0xa8884b4b = _0xcc3029b1.Plate(_0xbb8febe7, _0xaf9c0c69.CardPlate, _0xfbd72b05.Amber, 1.6f);
        this._0xa8884b4b.raycastTarget = true;
        RectTransform _0x3cdabc06 = _0xcc3029b1.Inner(_0xbb8febe7, _0xa767a38a._0x93d25e47(new byte[4] { 52, 25, 18, 15 }, 118), 0f, 0f, 244f, 76f);
        _0xcc3029b1.Plate(_0x3cdabc06, _0xaf9c0c69.CardPlate, _0xfbd72b05.BronzeLit, 1.6f);
        this._0xa79411cf = _0xcc3029b1.Label(_0xbb8febe7, _0xef21f014, _0xa767a38a._0x93d25e47(new byte[2] { 3, 2 }, 76), 42f, _0xfbd72b05.Cream, TextAlignmentOptions.Center);
        Button _0xc26b1308 = _0xbb8febe7.gameObject.AddComponent<Button>();
        _0xc26b1308.targetGraphic = this._0xa8884b4b;
        _0xc26b1308.onClick.AddListener(() => this._0x168c8e72());
        // ── festival scene ────────────────────────────────────────────────────
        _0xcc3029b1.Caption(_0xf8ab4632, _0xa767a38a._0x93d25e47(new byte[10] { 27, 43, 45, 38, 45, 4, 41, 42, 45, 36 }, 72), 0.5f, 0.760f, 940f, 60f, _0xef21f014, _0xa767a38a._0x93d25e47(new byte[14] { 189, 190, 168, 175, 178, 173, 186, 183, 219, 168, 184, 190, 181, 190 }, 251), 42f, _0xfbd72b05.Sand);
        float[] _0x7be63131 =
        {
            0.175f,
            0.5f,
            0.825f
        };
        for (int _0x52b2f7ed = 0; _0x52b2f7ed < _0x399a20a6.SceneCount && _0x52b2f7ed < _0x7be63131.Length; _0x52b2f7ed++)
        {
            this._0x83529a9e(_0xf8ab4632, _0xaf9c0c69, _0xef21f014, _0x52b2f7ed, _0x7be63131[_0x52b2f7ed]);
        }

        this._0xff46c4ea = _0xcc3029b1.Caption(_0xf8ab4632, _0xa767a38a._0x93d25e47(new byte[9] { 238, 222, 216, 211, 216, 243, 210, 201, 216 }, 189), 0.5f, 0.572f, 940f, 60f, _0xef21f014, _0xa767a38a._0x93d25e47(new byte[1] { 16 }, 48), 34f, _0xfbd72b05.Sand);
        // ── how to play ───────────────────────────────────────────────────────
        RectTransform _0xa741a1fa = _0xcc3029b1.Node(_0xf8ab4632, _0xa767a38a._0x93d25e47(new byte[6] { 147, 180, 172, 137, 180, 172 }, 219), 0.5f, 0.498f, 940f, 118f);
        Image _0xca722952 = _0xcc3029b1.Plate(_0xa741a1fa, _0xaf9c0c69.CardPlate, _0xfbd72b05.Amber, 2f);
        _0xca722952.raycastTarget = true;
        RectTransform _0x492c71eb = _0xcc3029b1.Inner(_0xa741a1fa, _0xa767a38a._0x93d25e47(new byte[4] { 250, 215, 220, 193 }, 184), 0f, 0f, 922f, 100f);
        _0xcc3029b1.Plate(_0x492c71eb, _0xaf9c0c69.CardPlate, _0xfbd72b05.BronzeLit, 2f);
        this._0xe7898966 = _0xcc3029b1.Label(_0xa741a1fa, _0xef21f014, _0xa767a38a._0x93d25e47(new byte[14] { 216, 223, 199, 176, 196, 223, 176, 192, 220, 209, 201, 176, 176, 187 }, 144), 44f, _0xfbd72b05.Cream, TextAlignmentOptions.Center);
        Button _0x27d2b70f = _0xa741a1fa.gameObject.AddComponent<Button>();
        _0x27d2b70f.targetGraphic = _0xca722952;
        _0x27d2b70f.onClick.AddListener(() => this._0xf90b0f9d());
        this._0x3ada4722 = _0xcc3029b1.Node(_0xf8ab4632, _0xa767a38a._0x93d25e47(new byte[8] { 28, 59, 35, 22, 56, 59, 55, 63 }, 84), 0.5f, 0.370f, 940f, 250f);
        _0xcc3029b1.Plate(this._0x3ada4722, _0xaf9c0c69.CardPlate, _0xfbd72b05.Ink, 2f);
        RectTransform _0xd1a3998f = _0xcc3029b1.Inner(this._0x3ada4722, _0xa767a38a._0x93d25e47(new byte[4] { 204, 253, 224, 236 }, 152), 0f, 0f, 900f, 230f);
        _0xcc3029b1.Label(_0xd1a3998f, _0xef21f014, _0xa767a38a._0x93d25e47(new byte[205] { 181, 160, 177, 193, 178, 177, 168, 175, 193, 204, 193, 167, 168, 183, 164, 193, 179, 164, 164, 173, 178, 193, 178, 181, 174, 177, 193, 173, 164, 167, 181, 193, 181, 174, 193, 179, 168, 166, 169, 181, 207, 235, 181, 169, 179, 164, 164, 193, 174, 179, 193, 172, 174, 179, 164, 193, 172, 160, 181, 162, 169, 168, 175, 166, 193, 167, 160, 162, 164, 178, 193, 167, 179, 174, 172, 193, 179, 164, 164, 173, 193, 174, 175, 164, 235, 177, 160, 184, 193, 174, 175, 193, 174, 175, 164, 193, 174, 167, 193, 181, 169, 164, 193, 167, 168, 183, 164, 193, 173, 168, 175, 164, 178, 207, 235, 181, 169, 164, 193, 173, 174, 175, 166, 169, 174, 179, 175, 193, 168, 178, 193, 182, 168, 173, 165, 205, 193, 181, 169, 164, 193, 178, 181, 160, 179, 193, 177, 160, 184, 178, 193, 160, 175, 184, 182, 169, 164, 179, 164, 207, 235, 164, 183, 164, 179, 184, 193, 167, 160, 162, 164, 193, 184, 174, 180, 193, 173, 160, 175, 165, 193, 168, 178, 193, 178, 181, 160, 172, 177, 164, 165, 193, 168, 175, 193, 181, 169, 164, 193, 160, 173, 163, 180, 172, 207 }, 225), 34f, _0xfbd72b05.Cream, TextAlignmentOptions.Center);
        this._0x3ada4722.gameObject.SetActive(false);
        // ── reset ─────────────────────────────────────────────────────────────
        this._0xbf5ca717 = _0xcc3029b1.Node(_0xf8ab4632, _0xa767a38a._0x93d25e47(new byte[8] { 24, 47, 57, 47, 62, 24, 37, 61 }, 74), 0.5f, 0.228f, 940f, 128f);
        Image _0x5e424b85 = _0xcc3029b1.Plate(this._0xbf5ca717, _0xaf9c0c69.CardPlate, _0xfbd72b05.Crimson, 2f);
        _0x5e424b85.raycastTarget = true;
        RectTransform _0x7370fb13 = _0xcc3029b1.Inner(this._0xbf5ca717, _0xa767a38a._0x93d25e47(new byte[4] { 191, 146, 153, 132 }, 253), 0f, 0f, 922f, 110f);
        _0xcc3029b1.Plate(_0x7370fb13, _0xaf9c0c69.CardPlate, _0xfbd72b05.Crimson, 2f);
        _0xcc3029b1.Label(this._0xbf5ca717, _0xef21f014, _0xa767a38a._0x93d25e47(new byte[14] { 247, 224, 246, 224, 241, 133, 245, 247, 234, 226, 247, 224, 246, 246 }, 165), 44f, _0xfbd72b05.Cream, TextAlignmentOptions.Center);
        Button _0x328ce79d = this._0xbf5ca717.gameObject.AddComponent<Button>();
        _0x328ce79d.targetGraphic = _0x5e424b85;
        _0x328ce79d.onClick.AddListener(() => this._0xc20773cf(true));
        this._0x5886c68c = _0xcc3029b1.Node(_0xf8ab4632, _0xa767a38a._0x93d25e47(new byte[10] { 10, 38, 39, 47, 32, 59, 36, 27, 38, 62 }, 73), 0.5f, 0.228f, 940f, 128f);
        Button _0x42ea9c25 = _0xcc3029b1.Action(this._0x5886c68c, _0xa767a38a._0x93d25e47(new byte[12] { 23, 59, 58, 50, 61, 38, 57, 6, 49, 39, 49, 32 }, 84), 0.27f, 0.5f, 450f, 118f, _0xaf9c0c69.CardPlate, _0xef21f014, _0xa767a38a._0x93d25e47(new byte[9] { 198, 209, 194, 208, 198, 163, 194, 207, 207 }, 131), _0xfbd72b05.Crimson, _0xfbd72b05.Crimson, _0xfbd72b05.Cream);
        _0x42ea9c25.onClick.AddListener(() => this._0x93e0527c());
        Button _0xbc046500 = _0xcc3029b1.Action(this._0x5886c68c, _0xa767a38a._0x93d25e47(new byte[11] { 93, 127, 112, 125, 123, 114, 76, 123, 109, 123, 106 }, 30), 0.73f, 0.5f, 450f, 118f, _0xaf9c0c69.CardPlate, _0xef21f014, _0xa767a38a._0x93d25e47(new byte[7] { 196, 202, 202, 223, 175, 198, 219 }, 143), _0xfbd72b05.Amber, _0xfbd72b05.BronzeLit, _0xfbd72b05.Cream);
        _0xbc046500.onClick.AddListener(() => this._0xc20773cf(false));
        this._0x5886c68c.gameObject.SetActive(false);
        _0xcc3029b1.Caption(_0xf8ab4632, _0xa767a38a._0x93d25e47(new byte[13] { 153, 175, 190, 190, 163, 164, 173, 185, 134, 175, 173, 171, 166 }, 202), 0.5f, 0.090f, 960f, 120f, _0xef21f014, _0xa767a38a._0x93d25e47(new byte[78] { 43, 40, 62, 57, 36, 59, 44, 33, 77, 46, 34, 36, 35, 62, 77, 44, 63, 40, 77, 61, 33, 44, 52, 77, 32, 34, 35, 40, 52, 77, 34, 35, 33, 52, 67, 103, 57, 37, 40, 52, 77, 46, 44, 35, 35, 34, 57, 77, 47, 40, 77, 47, 34, 56, 42, 37, 57, 65, 77, 62, 34, 33, 41, 77, 34, 63, 77, 46, 44, 62, 37, 40, 41, 77, 34, 56, 57, 67 }, 109), 36f, _0xfbd72b05.Sand);
    }

    private RectTransform _0x3ada4722;
    private void _0x24f56f6d(int _0x811d4381)
    {
        if (!_0x399a20a6.ChooseScene(_0x811d4381))
        {
            if (_0x811d4381 < this._0x6a3b6b32.Count)
            {
                this._0x6a3b6b32[_0x811d4381].transform.DOPunchScale(Vector3.one * 0.07f, 0.26f, 6, 0.6f).SetLink(this._0x6a3b6b32[_0x811d4381].gameObject);
            }

            _0x61cef379.SetText(this._0xff46c4ea, _0xa767a38a._0x93d25e47(new byte[5] { 0, 13, 2, 8, 108 }, 76) + (_0x399a20a6.SceneUnlockEmblems * _0x811d4381) + _0xa767a38a._0x93d25e47(new byte[31] { 57, 85, 86, 87, 94, 81, 86, 75, 87, 74, 57, 77, 86, 57, 76, 87, 85, 86, 90, 82, 57, 77, 81, 80, 74, 57, 74, 90, 92, 87, 92 }, 25));
            this._0xff46c4ea.color = _0xfbd72b05.CrimsonLit;
            return;
        }

        this._0xfcc0a4ec();
        if (this._0x75169a18 != null)
        {
            this._0x75169a18._0x1e4d13ce(_0x811d4381);
        }
    }

    /// Turning vibration ON fires the motor immediately, so the control confirms itself
    /// physically as well as visually.
    private void _0x168c8e72()
    {
        bool _0x631244c2 = !_0x399a20a6.Vibrate();
        _0x399a20a6.SetVibrate(_0x631244c2);
        if (_0x631244c2)
        {
            Handheld.Vibrate();
        }

        this._0xa8884b4b.transform.DOPunchScale(Vector3.one * 0.08f, 0.24f, 6, 0.6f).SetLink(this._0xa8884b4b.gameObject);
        this._0xfcc0a4ec();
    }

    private TextMeshProUGUI _0xff46c4ea;
    private TextMeshProUGUI _0xe7898966;
    public void _0x4ac5dacc(bool _0x4b2e991d)
    {
        if (this._0xd7d17072 != null)
        {
            this._0xd7d17072.gameObject.SetActive(_0x4b2e991d);
        }

        if (!_0x4b2e991d)
        {
            this._0xc20773cf(false);
        }
    }

    private void _0x93e0527c()
    {
        _0x399a20a6.ResetProgress();
        this._0xc20773cf(false);
        this._0xfcc0a4ec();
        if (this._0x75169a18 != null)
        {
            this._0x75169a18._0xe77c0e43();
            this._0x75169a18._0x1e4d13ce(_0x399a20a6.FestivalScene());
        }
    }

    private void OnDestroy()
    {
        DOTween.Kill(this);
        if (this._0xa8884b4b != null)
        {
            DOTween.Kill(this._0xa8884b4b.transform);
        }

        for (int _0x28255478 = 0; _0x28255478 < this._0x6a3b6b32.Count; _0x28255478++)
        {
            if (this._0x6a3b6b32[_0x28255478] != null)
            {
                DOTween.Kill(this._0x6a3b6b32[_0x28255478].transform);
            }
        }
    }

    private void _0xf90b0f9d()
    {
        this._0x6b092386 = !this._0x6b092386;
        this._0x3ada4722.gameObject.SetActive(this._0x6b092386);
        _0x61cef379.SetText(this._0xe7898966, this._0x6b092386 ? _0xa767a38a._0x93d25e47(new byte[14] { 92, 91, 67, 52, 64, 91, 52, 68, 88, 85, 77, 52, 52, 57 }, 20) : _0xa767a38a._0x93d25e47(new byte[14] { 53, 50, 42, 93, 41, 50, 93, 45, 49, 60, 36, 93, 93, 86 }, 125));
    }

    private RectTransform _0x5886c68c;
    private TextMeshProUGUI _0xa79411cf;
    private bool _0x6b092386;
    private RectTransform _0xd7d17072;
    public void _0xfcc0a4ec()
    {
        bool _0xaeb6c223 = _0x399a20a6.Vibrate();
        _0x61cef379.SetText(this._0xa79411cf, _0xaeb6c223 ? _0xa767a38a._0x93d25e47(new byte[2] { 3, 2 }, 76) : _0xa767a38a._0x93d25e47(new byte[3] { 212, 221, 221 }, 155));
        this._0xa79411cf.color = _0xaeb6c223 ? _0xfbd72b05.Gold : _0xfbd72b05.Sand;
        this._0xa8884b4b.color = _0xaeb6c223 ? _0xfbd72b05.Gold : _0xfbd72b05.Muted;
        int _0x4ee610ba = _0x399a20a6.FestivalScene();
        for (int _0xc03c44ca = 0; _0xc03c44ca < this._0x6a3b6b32.Count; _0xc03c44ca++)
        {
            bool _0xc9b301ba = _0x399a20a6.SceneUnlocked(_0xc03c44ca);
            bool _0x6a5a9fab = _0xc03c44ca == _0x4ee610ba;
            this._0x6a3b6b32[_0xc03c44ca].color = _0x6a5a9fab ? _0xfbd72b05.Gold : (_0xc9b301ba ? _0xfbd72b05.Amber : _0xfbd72b05.Muted);
            this._0x246c7c13[_0xc03c44ca].color = _0x6a5a9fab ? _0xfbd72b05.Gold : (_0xc9b301ba ? _0xfbd72b05.Cream : _0xfbd72b05.Sand);
            _0x61cef379.SetText(this._0x246c7c13[_0xc03c44ca], _0xc9b301ba ? _0x399a20a6.SceneNames[_0xc03c44ca] : (_0x399a20a6.SceneNames[_0xc03c44ca] + _0xa767a38a._0x93d25e47(new byte[7] { 44, 106, 105, 101, 109, 99, 98 }, 38)));
        }

        if (this._0xff46c4ea != null && this._0xff46c4ea.color != _0xfbd72b05.CrimsonLit)
        {
            _0x61cef379.SetText(this._0xff46c4ea, _0xa767a38a._0x93d25e47(new byte[35] { 53, 41, 36, 65, 34, 41, 46, 50, 36, 47, 65, 50, 34, 36, 47, 36, 65, 51, 36, 76, 53, 40, 47, 53, 50, 65, 53, 41, 36, 65, 45, 46, 35, 35, 56 }, 97));
            this._0xff46c4ea.color = _0xfbd72b05.Sand;
        }
    }

    private readonly List<Image> _0x6a3b6b32 = new List<Image>();
    private void _0xc20773cf(bool _0xbd3dee8c)
    {
        this._0xbf5ca717.gameObject.SetActive(!_0xbd3dee8c);
        this._0x5886c68c.gameObject.SetActive(_0xbd3dee8c);
    }

    private readonly List<Button> _0xe3407012 = new List<Button>();
    private RectTransform _0xbf5ca717;
    private void _0x83529a9e(RectTransform _0xa190a6c8, _0xde8b9ebc _0xdf8c8864, TMP_FontAsset _0xacfc4668, int _0xb2d3c0f4, float _0x2aa2cc5f)
    {
        RectTransform _0xa2016d2a = _0xcc3029b1.Node(_0xa190a6c8, _0xa767a38a._0x93d25e47(new byte[11] { 137, 185, 191, 180, 191, 152, 175, 174, 174, 181, 180 }, 218), _0x2aa2cc5f, 0.665f, 300f, 150f);
        Image _0x6a26572e = _0xcc3029b1.Plate(_0xa2016d2a, _0xdf8c8864.CardPlate, _0xfbd72b05.Amber, 2f);
        _0x6a26572e.raycastTarget = true;
        RectTransform _0x4ad11257 = _0xcc3029b1.Inner(_0xa2016d2a, _0xa767a38a._0x93d25e47(new byte[4] { 162, 143, 132, 153 }, 224), 0f, 0f, 284f, 134f);
        _0xcc3029b1.Plate(_0x4ad11257, _0xdf8c8864.CardPlate, _0xfbd72b05.BronzeLit, 2f);
        TextMeshProUGUI _0x9d378d17 = _0xcc3029b1.Label(_0xa2016d2a, _0xacfc4668, _0x399a20a6.SceneNames[_0xb2d3c0f4], 34f, _0xfbd72b05.Cream, TextAlignmentOptions.Center);
        Button _0x19bc0fc7 = _0xa2016d2a.gameObject.AddComponent<Button>();
        _0x19bc0fc7.targetGraphic = _0x6a26572e;
        int _0xae7b8284 = _0xb2d3c0f4;
        _0x19bc0fc7.onClick.AddListener(() => this._0x24f56f6d(_0xae7b8284));
        this._0x6a3b6b32.Add(_0x6a26572e);
        this._0x246c7c13.Add(_0x9d378d17);
        this._0xe3407012.Add(_0x19bc0fc7);
    }

    private _0x3bfed499 _0x75169a18;
}

internal static class _0xa767a38a
{
    internal static string _0x93d25e47(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}