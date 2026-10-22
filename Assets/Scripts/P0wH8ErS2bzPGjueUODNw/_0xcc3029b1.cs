using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// Small UGUI factory. The whole game is built from these: no SpriteRenderer, no world-space
/// TextMeshPro and no new Canvas anywhere, so nothing this game draws can ever sort above the
/// template's Win/Lose/Pause canvases.
///
/// Everything is laid out in the AspecterSA box, which is 1242 x 2688 logical units on every
/// device (an AspectRatioFitter in FitInParent mode keeps that ratio and letterboxes the rest),
/// so a point anchor plus a pixel size is reproducible and the screenshot scenario can be
/// computed from the same numbers.
///
/// Draw order is sibling order (rule E.1 / C.13): a plate is created BEFORE the label that sits
/// on it, so the caption is always the later sibling and always on top.
public static class _0xcc3029b1
{
    /// A content picture (symbol, icon, emblem). Its own aspect is preserved, so a 512 square
    /// PNG is never drawn as an egg (rule F.2a).
    public static Image Picture(RectTransform _0xdd31250f, Sprite _0xfb9430bd, Color _0x0725b99e)
    {
        Image _0xe2201d67 = _0xdd31250f.gameObject.AddComponent<Image>();
        _0xe2201d67.sprite = _0xfb9430bd;
        _0xe2201d67.color = _0x0725b99e;
        _0xe2201d67.type = Image.Type.Simple;
        _0xe2201d67.preserveAspect = true;
        _0xe2201d67.raycastTarget = false;
        return _0xe2201d67;
    }

    /// A free-standing caption anchored to a point of the parent.
    public static TextMeshProUGUI Caption(Transform _0xbc83088b, string _0x7f4ce349, float _0x7d0ac74e, float _0x81ffb0a7, float _0xe2469990, float _0x0896eb8b, TMP_FontAsset _0xa6dca1dd, string _0x255832a0, float _0xd7858898, Color _0xda4d77a6)
    {
        RectTransform _0x2dfdc876 = Node(_0xbc83088b, _0x7f4ce349, _0x7d0ac74e, _0x81ffb0a7, _0xe2469990, _0x0896eb8b);
        return Label(_0x2dfdc876, _0xa6dca1dd, _0x255832a0, _0xd7858898, _0xda4d77a6, TextAlignmentOptions.Center);
    }

    public static TextMeshProUGUI Label(RectTransform _0xffdae97a, TMP_FontAsset _0xfbe53be6, string _0x458b69a9, float _0x90796c03, Color _0x8146fe46, TextAlignmentOptions _0xcc3ba721)
    {
        GameObject _0xd496883f = new GameObject(_0xc1e72f31._0x71d6083f(new byte[7] { 197, 231, 246, 242, 239, 233, 232 }, 134), typeof(RectTransform));
        RectTransform _0xfda6c8ec = _0xd496883f.GetComponent<RectTransform>();
        _0xfda6c8ec.SetParent(_0xffdae97a, false);
        _0xfda6c8ec.anchorMin = new Vector2(0f, 0f);
        _0xfda6c8ec.anchorMax = new Vector2(1f, 1f);
        _0xfda6c8ec.offsetMin = Vector2.zero;
        _0xfda6c8ec.offsetMax = Vector2.zero;
        _0xfda6c8ec.localScale = Vector3.one;
        TextMeshProUGUI _0x546c0011 = _0xd496883f.AddComponent<TextMeshProUGUI>();
        if (_0xfbe53be6 != null)
        {
            _0x546c0011.font = _0xfbe53be6;
        }

        _0x546c0011.alignment = _0xcc3ba721;
        _0x61cef379.Shape(_0x546c0011, _0x90796c03, _0x8146fe46);
        _0x61cef379.SetText(_0x546c0011, _0x458b69a9);
        return _0x546c0011;
    }

    /// A node anchored to ONE point of its parent, sized in logical units. Collapsed anchors
    /// are what rule G.3 asks for and what makes a tapFrac computable.
    public static RectTransform Node(Transform _0x2b23a3a9, string _0x69c7413f, float _0x2d5ff8a6, float _0xf0d2d6d2, float _0x8a41dbda, float _0xc40118a7)
    {
        GameObject _0x572b2153 = new GameObject(_0x69c7413f, typeof(RectTransform));
        RectTransform _0xa6e4f14a = _0x572b2153.GetComponent<RectTransform>();
        _0xa6e4f14a.SetParent(_0x2b23a3a9, false);
        _0xa6e4f14a.anchorMin = new Vector2(_0x2d5ff8a6, _0xf0d2d6d2);
        _0xa6e4f14a.anchorMax = new Vector2(_0x2d5ff8a6, _0xf0d2d6d2);
        _0xa6e4f14a.pivot = new Vector2(0.5f, 0.5f);
        _0xa6e4f14a.anchoredPosition = Vector2.zero;
        _0xa6e4f14a.sizeDelta = new Vector2(_0x8a41dbda, _0xc40118a7);
        _0xa6e4f14a.localScale = Vector3.one;
        return _0xa6e4f14a;
    }

    /// A 9-sliced plate. Sliced is the point of these sprites (they carry a real spriteBorder),
    /// so preserveAspect is deliberately NOT set - it would break the slicing (rule F.2a).
    public static Image Plate(RectTransform _0xa14b8019, Sprite _0x0c5bbece, Color _0x899cd5a6, float _0x2ef2ac9c)
    {
        Image _0x34671a2b = _0xa14b8019.gameObject.AddComponent<Image>();
        _0x34671a2b.sprite = _0x0c5bbece;
        _0x34671a2b.color = _0x899cd5a6;
        _0x34671a2b.type = Image.Type.Sliced;
        _0x34671a2b.pixelsPerUnitMultiplier = _0x2ef2ac9c;
        _0x34671a2b.raycastTarget = false;
        return _0x34671a2b;
    }

    /// A framed button: amber frame plate, dark body inset, caption LAST so it draws on top.
    /// The frame carries the raycast, so the tap always lands even where the caption does not.
    public static Button Action(Transform _0xe0edda77, string _0x7210eccb, float _0x707a6a05, float _0x490fc6d0, float _0x9c22444d, float _0xc60ff33f, Sprite _0xbd16a79e, TMP_FontAsset _0xa23d424b, string _0xeb0a440c, Color _0x63794afb, Color _0xfae8f2fc, Color _0xcd2cbf34)
    {
        RectTransform _0xcdbec250 = Node(_0xe0edda77, _0x7210eccb, _0x707a6a05, _0x490fc6d0, _0x9c22444d, _0xc60ff33f);
        Image _0x7fa19939 = Plate(_0xcdbec250, _0xbd16a79e, _0x63794afb, 1.9f);
        _0x7fa19939.raycastTarget = true;
        RectTransform _0xc294d565 = Inner(_0xcdbec250, _0xc1e72f31._0x71d6083f(new byte[4] { 72, 101, 110, 115 }, 10), 0f, 0f, _0x9c22444d - 16f, _0xc60ff33f - 16f);
        Plate(_0xc294d565, _0xbd16a79e, _0xfae8f2fc, 1.9f);
        Label(_0xcdbec250, _0xa23d424b, _0xeb0a440c, Mathf.Min(58f, _0xc60ff33f * 0.42f), _0xcd2cbf34, TextAlignmentOptions.Center);
        Button _0x6d8fcda0 = _0xcdbec250.gameObject.AddComponent<Button>();
        _0x6d8fcda0.targetGraphic = _0x7fa19939;
        ColorBlock _0xac7f9b87 = _0x6d8fcda0.colors;
        _0xac7f9b87.normalColor = Color.white;
        _0xac7f9b87.highlightedColor = new Color(1f, 1f, 1f, 1f);
        _0xac7f9b87.pressedColor = new Color(0.78f, 0.78f, 0.78f, 1f);
        _0xac7f9b87.selectedColor = Color.white;
        _0xac7f9b87.disabledColor = new Color(0.55f, 0.55f, 0.55f, 1f);
        _0xac7f9b87.fadeDuration = 0.08f;
        _0x6d8fcda0.colors = _0xac7f9b87;
        return _0x6d8fcda0;
    }

    public static void Fit(RectTransform _0x9eccad14, RectTransform _0x999a9200)
    {
        if (_0x9eccad14 == null || _0x999a9200 == null)
        {
            return;
        }

        _0x9eccad14.anchorMin = _0x999a9200.anchorMin;
        _0x9eccad14.anchorMax = _0x999a9200.anchorMax;
        _0x9eccad14.pivot = _0x999a9200.pivot;
        _0x9eccad14.anchoredPosition = _0x999a9200.anchoredPosition;
        _0x9eccad14.sizeDelta = _0x999a9200.sizeDelta;
    }

    public static RectTransform Stretch(Transform _0x0cb38163, string _0x65ac374f)
    {
        GameObject _0x4c4e0464 = new GameObject(_0x65ac374f, typeof(RectTransform));
        RectTransform _0xffeafe6a = _0x4c4e0464.GetComponent<RectTransform>();
        _0xffeafe6a.SetParent(_0x0cb38163, false);
        _0xffeafe6a.anchorMin = new Vector2(0f, 0f);
        _0xffeafe6a.anchorMax = new Vector2(1f, 1f);
        _0xffeafe6a.pivot = new Vector2(0.5f, 0.5f);
        _0xffeafe6a.offsetMin = Vector2.zero;
        _0xffeafe6a.offsetMax = Vector2.zero;
        _0xffeafe6a.localScale = Vector3.one;
        return _0xffeafe6a;
    }

    /// A round/icon button: one plate, one icon picture, no caption.
    public static Button IconAction(Transform _0xf7ba17cc, string _0x52a20900, float _0x10184fd3, float _0xd316ceaa, float _0x4bd046e8, Sprite _0xb543e2ab, Sprite _0x608349ea, Color _0x32580fa2, Color _0x298d4965)
    {
        RectTransform _0xc27954f5 = Node(_0xf7ba17cc, _0x52a20900, _0x10184fd3, _0xd316ceaa, _0x4bd046e8, _0x4bd046e8);
        Image _0x20a6f1f4 = Plate(_0xc27954f5, _0xb543e2ab, _0x32580fa2, 1.4f);
        _0x20a6f1f4.raycastTarget = true;
        RectTransform _0x8d7caf25 = Inner(_0xc27954f5, _0xc1e72f31._0x71d6083f(new byte[5] { 221, 246, 227, 234, 242 }, 154), 0f, 0f, _0x4bd046e8 * 0.56f, _0x4bd046e8 * 0.56f);
        Picture(_0x8d7caf25, _0x608349ea, _0x298d4965);
        Button _0x4bbd3607 = _0xc27954f5.gameObject.AddComponent<Button>();
        _0x4bbd3607.targetGraphic = _0x20a6f1f4;
        return _0x4bbd3607;
    }

    /// A near-invisible film that still takes raycasts: the tap target laid over a template
    /// button whose own graphics cannot be relied on.
    public static Image HitLayer(Transform _0x3e0bcef8, string _0xc9fafdeb)
    {
        RectTransform _0x3d0fb447 = Stretch(_0x3e0bcef8, _0xc9fafdeb);
        Image _0xabd33bc6 = _0x3d0fb447.gameObject.AddComponent<Image>();
        _0xabd33bc6.color = _0xfbd72b05.HitFilm;
        _0xabd33bc6.raycastTarget = true;
        return _0xabd33bc6;
    }

    /// A child placed by offsets inside its parent's own rect, used for card internals.
    public static RectTransform Inner(Transform _0x53847bb0, string _0x95c413d1, float _0xf061eca1, float _0xda118345, float _0xa05890a4, float _0x6bb6dbc1)
    {
        GameObject _0x16d94e72 = new GameObject(_0x95c413d1, typeof(RectTransform));
        RectTransform _0x21f74320 = _0x16d94e72.GetComponent<RectTransform>();
        _0x21f74320.SetParent(_0x53847bb0, false);
        _0x21f74320.anchorMin = new Vector2(0.5f, 0.5f);
        _0x21f74320.anchorMax = new Vector2(0.5f, 0.5f);
        _0x21f74320.pivot = new Vector2(0.5f, 0.5f);
        _0x21f74320.anchoredPosition = new Vector2(_0xf061eca1, _0xda118345);
        _0x21f74320.sizeDelta = new Vector2(_0xa05890a4, _0x6bb6dbc1);
        _0x21f74320.localScale = Vector3.one;
        return _0x21f74320;
    }

    public static readonly float CanvasW = 1242f;
    public static readonly float CanvasH = 2688f;
    /// A flat tinted quad with no sprite. Used only for dims and washes, never as a frame.
    public static Image Wash(RectTransform _0x187ab3e7, Color _0x6ac9ed2c)
    {
        Image _0x311317af = _0x187ab3e7.gameObject.AddComponent<Image>();
        _0x311317af.color = _0x6ac9ed2c;
        _0x311317af.type = Image.Type.Simple;
        _0x311317af.raycastTarget = false;
        return _0x311317af;
    }
}

internal static class _0xc1e72f31
{
    internal static string _0x71d6083f(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}