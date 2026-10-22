using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Canvas))]
public class _0x5745525b : MonoBehaviour
{
    private static bool _0x089dd597;
    private static Rect _0x630a45a5 = Rect.zero;
    private RectTransform _0x2cce906a;
    private static void OrientationChanged()
    {
        _0x78038c3f = Screen.orientation;
        _0x87671f0d.x = Screen.width;
        _0x87671f0d.y = Screen.height;
        _0xcfcd85f4.Invoke();
    }

    private static void ResolutionChanged()
    {
        _0x87671f0d.x = Screen.width;
        _0x87671f0d.y = Screen.height;
        _0xcfcd85f4.Invoke();
    }

    private static readonly List<_0x5745525b> _0x219abfa4 = new();
    private void Awake()
    {
        if (!_0x219abfa4.Contains(this))
            _0x219abfa4.Add(this);
        this._0x97c042c6 = this.GetComponent<Canvas>();
        this._0x2cce906a = this.GetComponent<RectTransform>();
        this._0x57fb91cb = this.transform.Find(_0xd5f23bc7._0x07662b0a(new byte[8] { 24, 42, 45, 46, 10, 57, 46, 42 }, 75)) as RectTransform;
        if (!_0x089dd597)
        {
            _0x78038c3f = Screen.orientation;
            _0x87671f0d.x = Screen.width;
            _0x87671f0d.y = Screen.height;
            _0x630a45a5 = Screen.safeArea;
            _0x089dd597 = true;
        }

        this._0x547f2b10();
    }

    private void OnDestroy()
    {
        if (_0x219abfa4 != null && _0x219abfa4.Contains(this))
            _0x219abfa4.Remove(this);
    }

    private static Vector2 _0x87671f0d = Vector2.zero;
    private void Update()
    {
        if (_0x219abfa4[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x78038c3f)
            OrientationChanged();
        if (Screen.safeArea != _0x630a45a5)
            SafeAreaChanged();
        if (Screen.width != _0x87671f0d.x || Screen.height != _0x87671f0d.y)
            ResolutionChanged();
    }

    private static UnityEvent _0xcfcd85f4 = new();
    private static void SafeAreaChanged()
    {
        _0x630a45a5 = Screen.safeArea;
        for (int _0x5b2af931 = 0; _0x5b2af931 < _0x219abfa4.Count; _0x5b2af931++)
            _0x219abfa4[_0x5b2af931]._0x547f2b10();
    }

    private Canvas _0x97c042c6;
    private void _0x547f2b10()
    {
        if (this._0x57fb91cb == null)
            return;
        Rect _0x1e593579 = Screen.safeArea;
        Vector2 _0x789136b1 = _0x1e593579.position;
        Vector2 _0x690497bf = _0x1e593579.position + _0x1e593579.size;
        _0x789136b1.x /= this._0x97c042c6.pixelRect.width;
        _0x789136b1.y /= this._0x97c042c6.pixelRect.height;
        _0x690497bf.x /= this._0x97c042c6.pixelRect.width;
        _0x690497bf.y /= this._0x97c042c6.pixelRect.height;
        this._0x57fb91cb.anchorMin = _0x789136b1;
        this._0x57fb91cb.anchorMax = _0x690497bf;
    }

    private static ScreenOrientation _0x78038c3f = ScreenOrientation.LandscapeLeft;
    private RectTransform _0x57fb91cb;
}

internal static class _0xd5f23bc7
{
    internal static string _0x07662b0a(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}