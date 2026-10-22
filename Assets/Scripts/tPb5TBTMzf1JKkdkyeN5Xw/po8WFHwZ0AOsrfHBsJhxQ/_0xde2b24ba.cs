using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
public class _0xde2b24ba : MonoBehaviour
{
    private static ScreenOrientation _0x1515d9ec = ScreenOrientation.LandscapeLeft;
    private Canvas _0xe909e78d;
    private static void ApplySafeAreaToAll()
    {
        for (int _0x4792042f = 0; _0x4792042f < _0x4b89a022.Count; _0x4792042f++)
            _0x4b89a022[_0x4792042f]._0x94873d28();
    }

    private RectTransform _0x7cf8d4fd;
    private void Start()
    {
    }

    private void Awake()
    {
        if (!_0x4b89a022.Contains(this))
            _0x4b89a022.Add(this);
        this._0xe909e78d = this.GetComponent<Canvas>();
        this._0x0b974069 = this.GetComponent<CanvasScaler>();
        if (this._0x0b974069 != null)
            this._0x063027d7 = this._0x0b974069.referenceResolution;
        this._0x7cf8d4fd = this.GetComponent<RectTransform>();
        this._0x060b8a4a = this.transform.Find(_0xdc83ca41._0xf3ea6571(new byte[8] { 158, 172, 171, 168, 140, 191, 168, 172 }, 205)) as RectTransform;
        if (!_0x744aae40)
        {
            _0x1515d9ec = Screen.orientation;
            _0x60d7f861.x = Screen.width;
            _0x60d7f861.y = Screen.height;
            _0x59dfcef0 = Screen.safeArea;
            _0x744aae40 = true;
        }

        this._0x94873d28();
    }

    private static bool _0x744aae40;
    private static void ResolutionChanged()
    {
        _0x60d7f861.x = Screen.width;
        _0x60d7f861.y = Screen.height;
        _0x59dfcef0 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x8afd66a2.Invoke();
    }

    private static Vector2 _0x60d7f861 = Vector2.zero;
    private static UnityEvent _0x8afd66a2 = new();
    private static void OrientationChanged()
    {
        _0x1515d9ec = Screen.orientation;
        _0x60d7f861.x = Screen.width;
        _0x60d7f861.y = Screen.height;
        _0x59dfcef0 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x8afd66a2.Invoke();
    }

    private void Update()
    {
        if (_0x4b89a022.Count == 0 || _0x4b89a022[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x1515d9ec)
            OrientationChanged();
        if (Screen.safeArea != _0x59dfcef0)
            SafeAreaChanged();
        if (Screen.width != _0x60d7f861.x || Screen.height != _0x60d7f861.y)
            ResolutionChanged();
    }

    private void _0x94873d28()
    {
        if (this._0x060b8a4a == null)
            return;
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;
        if (screenWidth <= 0f || screenHeight <= 0f)
            return;
        Rect _0xf1cfe99c = Screen.safeArea;
        Vector2 _0x704f9d50 = _0xf1cfe99c.position;
        Vector2 _0x2409f961 = _0xf1cfe99c.position + _0xf1cfe99c.size;
        _0x704f9d50.x /= screenWidth;
        _0x704f9d50.y /= screenHeight;
        _0x2409f961.x /= screenWidth;
        _0x2409f961.y /= screenHeight;
        this._0x060b8a4a.anchorMin = _0x704f9d50;
        this._0x060b8a4a.anchorMax = _0x2409f961;
        this._0x060b8a4a.offsetMin = Vector2.zero;
        this._0x060b8a4a.offsetMax = Vector2.zero;
        if (this._0x0b974069 == null)
            return;
        Vector2 _0x689b037c = _0x2409f961 - _0x704f9d50;
        float _0x991bbc43 = 2f - _0x689b037c.x;
        float _0xf15dcb57 = 2f - _0x689b037c.y;
        this._0x0b974069.referenceResolution = this._0x063027d7 * new Vector2(_0x991bbc43, _0xf15dcb57);
    }

    private static readonly List<_0xde2b24ba> _0x4b89a022 = new();
    private static void SafeAreaChanged()
    {
        _0x59dfcef0 = Screen.safeArea;
        ApplySafeAreaToAll();
    }

    private RectTransform _0x060b8a4a;
    private static Rect _0x59dfcef0 = Rect.zero;
    private void OnDestroy()
    {
        if (_0x4b89a022 != null && _0x4b89a022.Contains(this))
            _0x4b89a022.Remove(this);
    }

    private CanvasScaler _0x0b974069;
    private Vector2 _0x063027d7;
}

internal static class _0xdc83ca41
{
    internal static string _0xf3ea6571(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}