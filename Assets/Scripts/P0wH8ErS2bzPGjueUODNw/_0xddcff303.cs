using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// The splash. Its whole job is to look like a DIFFERENT screen from the lobby: a heavy dark
/// scrim over the menu background, one abstract mark in the middle, one functional caption,
/// and the template's loading bar themed so it can actually be seen.
///
/// The mark is an emblem, never the app name and never a word of it (hard rule 1): the name
/// lives in ProjectSettings and nowhere on screen.
public sealed class _0xddcff303 : MonoBehaviour
{
    /// Rule G: the bar must READ. Fill takes the gold accent, the track a dark palette colour
    /// with real alpha instead of the template's near-transparent default. The inner rects are
    /// left exactly as the prefab laid them out - the Fill Area shrinks itself by 30 units and
    /// any smaller root collapses the bar to nothing (ANDROID-3578), so nothing here resizes.
    private void _0x1782ea51(_0x126eaf94 _0x00922217)
    {
        Slider _0x6e87dacd = _0x00922217.GetComponentInChildren<Slider>(true);
        if (_0x6e87dacd == null)
        {
            return;
        }

        if (_0x6e87dacd.fillRect != null)
        {
            Image _0x1f9f317b = _0x6e87dacd.fillRect.GetComponent<Image>();
            if (_0x1f9f317b != null)
            {
                _0x1f9f317b.color = _0xfbd72b05.Gold;
            }

            Transform _0xec0df6d3 = _0x6e87dacd.fillRect.parent;
            Image _0xf175618e = _0xec0df6d3 != null ? _0xec0df6d3.GetComponent<Image>() : null;
            if (_0xf175618e != null)
            {
                _0xf175618e.color = _0xfbd72b05.WithAlpha(_0xfbd72b05.BronzeLit, 0.90f);
            }
        }

        Image _0x2d35f530 = _0x6e87dacd.GetComponent<Image>();
        if (_0x2d35f530 != null)
        {
            _0x2d35f530.color = _0xfbd72b05.WithAlpha(_0xfbd72b05.BronzeLit, 0.90f);
        }
    }

    private RectTransform _0xb1af4835;
    private Image _0x105dbc65;
    private void OnDestroy()
    {
        if (this._0x105dbc65 != null)
        {
            DOTween.Kill(this._0x105dbc65);
            DOTween.Kill(this._0x105dbc65.transform);
        }

        if (this._0x5658c6fe != null)
        {
            DOTween.Kill(this._0x5658c6fe.transform);
        }

        DOTween.Kill(this);
    }

    private void _0x6ac08d38()
    {
        if (this._0x105dbc65 != null)
        {
            this._0x105dbc65.color = new Color(1f, 1f, 1f, 0f);
            this._0x105dbc65.transform.localScale = Vector3.one * 0.86f;
            this._0x105dbc65.DOFade(1f, 0.45f).SetLink(this._0x105dbc65.gameObject);
            this._0x105dbc65.transform.DOScale(1f, 0.45f).SetEase(Ease.OutBack).SetLink(this._0x105dbc65.gameObject);
            this._0x105dbc65.transform.DOScale(1.035f, 1.8f).SetDelay(0.5f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo).SetLink(this._0x105dbc65.gameObject);
        }

        if (this._0x5658c6fe != null)
        {
            this._0x5658c6fe.transform.DOLocalRotate(new Vector3(0f, 0f, 360f), 26f, RotateMode.FastBeyond360).SetEase(Ease.Linear).SetLoops(-1, LoopType.Restart).SetLink(this._0x5658c6fe.gameObject);
        }
    }

    [SerializeField]
    private TMP_FontAsset _font;
    private Image _0x5658c6fe;
    [SerializeField]
    private _0xde8b9ebc _art;
    private void Start()
    {
        _0xb5c3d2c9 _0xbc528ddf = _0xb5c3d2c9.Instance;
        if (_0xbc528ddf == null || _0xbc528ddf.Panels == null || _0x283dfe71._0x0485a4d3.SPLASH >= _0xbc528ddf.Panels.Count)
        {
            return;
        }

        _0x126eaf94 _0xb175f686 = _0xbc528ddf.Panels[_0x283dfe71._0x0485a4d3.SPLASH];
        if (_0xb175f686 == null || _0xb175f686.Content == null)
        {
            return;
        }

        this._0xb1af4835 = _0xcc3029b1.Stretch(_0xb175f686.Content.transform, _0x6a6b6350._0x35e6842e(new byte[10] { 4, 39, 59, 54, 36, 63, 26, 54, 37, 60 }, 87));
        this._0xb1af4835.SetAsFirstSibling();
        // A heavy scrim is what makes the splash read as its own screen rather than as the
        // lobby with a bar on it.
        _0xcc3029b1.Wash(_0xcc3029b1.Stretch(this._0xb1af4835, _0x6a6b6350._0x35e6842e(new byte[5] { 76, 124, 109, 118, 114 }, 31)), new Color(0.0784f, 0.0392f, 0.0196f, 0.88f));
        RectTransform _0x06a7bef2 = _0xcc3029b1.Node(this._0xb1af4835, _0x6a6b6350._0x35e6842e(new byte[8] { 154, 182, 165, 188, 159, 182, 187, 184 }, 215), 0.5f, 0.600f, 620f, 620f);
        this._0x5658c6fe = _0xcc3029b1.Picture(_0x06a7bef2, this._art != null ? this._art.PaylineGlow : null, _0xfbd72b05.WithAlpha(_0xfbd72b05.Amber, 0.30f));
        RectTransform _0x3b9dc6a1 = _0xcc3029b1.Node(this._0xb1af4835, _0x6a6b6350._0x35e6842e(new byte[4] { 252, 208, 195, 218 }, 177), 0.5f, 0.600f, 420f, 420f);
        this._0x105dbc65 = _0xcc3029b1.Picture(_0x3b9dc6a1, this._art != null ? this._art.EmblemMark : null, Color.white);
        _0xcc3029b1.Caption(this._0xb1af4835, _0x6a6b6350._0x35e6842e(new byte[13] { 91, 120, 100, 105, 123, 96, 75, 105, 120, 124, 97, 103, 102 }, 8), 0.5f, 0.340f, 940f, 70f, this._font, _0x6a6b6350._0x35e6842e(new byte[21] { 8, 13, 3, 12, 16, 13, 10, 3, 100, 16, 12, 1, 100, 8, 5, 10, 16, 1, 22, 10, 23 }, 68), 44f, _0xfbd72b05.Sand);
        _0xcc3029b1.Caption(this._0xb1af4835, _0x6a6b6350._0x35e6842e(new byte[11] { 33, 2, 30, 19, 1, 26, 62, 23, 21, 19, 30 }, 114), 0.5f, 0.090f, 1060f, 60f, this._font, _0x6a6b6350._0x35e6842e(new byte[38] { 208, 204, 193, 217, 160, 205, 207, 206, 197, 217, 160, 207, 206, 204, 217, 160, 173, 160, 206, 207, 160, 195, 193, 211, 200, 160, 208, 210, 201, 218, 197, 211, 160, 173, 160, 177, 184, 171 }, 128), 36f, _0xfbd72b05.Sand);
        this._0x6ac08d38();
        this._0x1782ea51(_0xb175f686);
    }
}

internal static class _0x6a6b6350
{
    internal static string _0x35e6842e(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}