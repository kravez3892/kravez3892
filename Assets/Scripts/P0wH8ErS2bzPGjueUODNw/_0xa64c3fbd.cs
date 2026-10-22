using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

/// One reel column: five cells (three visible plus one buffer above and below) inside a
/// RectMask2D, so the overshoot is clipped by the window itself instead of being hidden under
/// an opaque plate drawn over the content (the ANDROID-3297 mistake, rule C.13).
///
/// The scroll is driven in Update rather than by a looping tween: a wrap has to rotate the
/// symbol array at exactly the moment the strip has travelled one cell, and a tween callback
/// cannot promise that. Only the final thunk is a tween, and it is linked to its own object.
public sealed class _0xa64c3fbd : MonoBehaviour
{
    private bool _0xd3a1e967;
    private readonly Image[] _0x3661ee67 = new Image[5];
    private void OnDestroy()
    {
        if (this._0x330120e1 != null)
        {
            this._0x330120e1.Kill();
            this._0x330120e1 = null;
        }

        DOTween.Kill(this);
    }

    private bool _0x8506d4e9;
    private Sprite[] _0xb09b4285;
    private RectTransform _0x9b3dc57a;
    public int _0xe34f7a16(int _0xbbabe270)
    {
        int _0xb6158252 = Mathf.Clamp(_0xbbabe270 + 1, 1, 3);
        return this._0xf74937d9[_0xb6158252];
    }

    private void Update()
    {
        if (!this._0xd3a1e967)
        {
            return;
        }

        this._0xb11170f7 -= this._0xd10ceb7a * Time.deltaTime;
        if (this._0xb11170f7 > -this._0x301dc8c2)
        {
            this._0x4692f5c1();
            return;
        }

        this._0xb11170f7 += this._0x301dc8c2;
        bool _0x7c091180 = this._0x8506d4e9 && Time.time >= this._0xa5ee9d7a;
        if (!_0x7c091180)
        {
            for (int _0xec8568c9 = 4; _0xec8568c9 >= 1; _0xec8568c9--)
            {
                this._0xf74937d9[_0xec8568c9] = this._0xf74937d9[_0xec8568c9 - 1];
            }

            this._0xf74937d9[0] = this._0xab7a2023.Next(_0x97c3b88a.Count);
            this._0x4692f5c1();
            return;
        }

        this._0xd3a1e967 = false;
        this._0x8506d4e9 = false;
        this._0xb11170f7 = 0f;
        this._0xf74937d9[0] = this._0xab7a2023.Next(_0x97c3b88a.Count);
        this._0xf74937d9[4] = this._0xab7a2023.Next(_0x97c3b88a.Count);
        if (this._0x8be5d0c5 != null)
        {
            for (int _0x0564b876 = 0; _0x0564b876 < _0x97c3b88a.Rows; _0x0564b876++)
            {
                this._0xf74937d9[_0x0564b876 + 1] = this._0x8be5d0c5[_0x0564b876];
            }
        }

        this._0x4692f5c1();
        this._0xb11170f7 = -this._0x301dc8c2 * 0.22f;
        this._0x4692f5c1();
        float _0x05fba713 = this._0xb11170f7;
        this._0x330120e1 = DOTween.To(() => _0x05fba713, _0xabbb50d1 =>
        {
            this._0xb11170f7 = _0xabbb50d1;
            this._0x4692f5c1();
        }, 0f, 0.17f).SetEase(Ease.OutBack).SetLink(this.gameObject);
    }

    private System.Random _0xab7a2023;
    public void _0x4d3b513a(RectTransform _0x104d0a56, Sprite[] _0x4b517c5e, float _0x537a86e1, float _0x49cbb17a, int[] _0x052c58ea, int _0xb8213312)
    {
        this._0xb09b4285 = _0x4b517c5e;
        this._0x301dc8c2 = _0x49cbb17a;
        this._0xd10ceb7a = _0x49cbb17a / 0.062f;
        // Seeded, never UnityEngine.Random: that one is global state and rule C.11 keeps every
        // draw of a run reproducible from the session seed.
        this._0xab7a2023 = new System.Random(_0xb8213312);
        _0x104d0a56.gameObject.AddComponent<RectMask2D>();
        this._0x9b3dc57a = _0xcc3029b1.Stretch(_0x104d0a56, _0x54dccbd8._0xda214b8c(new byte[5] { 236, 203, 205, 214, 207 }, 191));
        this._0x9b3dc57a.anchorMin = new Vector2(0.5f, 0.5f);
        this._0x9b3dc57a.anchorMax = new Vector2(0.5f, 0.5f);
        this._0x9b3dc57a.sizeDelta = new Vector2(_0x537a86e1, _0x49cbb17a * 5f);
        this._0x9b3dc57a.anchoredPosition = Vector2.zero;
        for (int _0x3ffc32b5 = 0; _0x3ffc32b5 < 5; _0x3ffc32b5++)
        {
            float _0xce31844e = (2 - _0x3ffc32b5) * _0x49cbb17a;
            RectTransform _0xd5bc4226 = _0xcc3029b1.Inner(this._0x9b3dc57a, _0x54dccbd8._0xda214b8c(new byte[4] { 63, 25, 16, 16 }, 124), 0f, _0xce31844e, _0x537a86e1 * 0.86f, _0x49cbb17a * 0.86f);
            this._0x2807413a[_0x3ffc32b5] = _0xd5bc4226;
            this._0xf74937d9[_0x3ffc32b5] = _0x052c58ea != null && _0x3ffc32b5 >= 1 && _0x3ffc32b5 <= 3 ? _0x052c58ea[_0x3ffc32b5 - 1] : this._0xab7a2023.Next(_0x97c3b88a.Count);
            this._0x3661ee67[_0x3ffc32b5] = _0xcc3029b1.Picture(_0xd5bc4226, this._0x079ad57a(this._0xf74937d9[_0x3ffc32b5]), Color.white);
        }

        this._0x4692f5c1();
    }

    private void _0x4692f5c1()
    {
        for (int _0xede82d7a = 0; _0xede82d7a < 5; _0xede82d7a++)
        {
            if (this._0x3661ee67[_0xede82d7a] == null)
            {
                continue;
            }

            this._0x3661ee67[_0xede82d7a].sprite = this._0x079ad57a(this._0xf74937d9[_0xede82d7a]);
            this._0x2807413a[_0xede82d7a].anchoredPosition = new Vector2(0f, ((2 - _0xede82d7a) * this._0x301dc8c2) + this._0xb11170f7);
        }
    }

    public void _0x609285d4(bool _0xf2c567df)
    {
        if (this._0x330120e1 == null)
        {
            return;
        }

        if (_0xf2c567df)
        {
            this._0x330120e1.Pause();
        }
        else
        {
            this._0x330120e1.Play();
        }
    }

    public void _0x63663a10()
    {
        if (this._0x330120e1 != null)
        {
            this._0x330120e1.Kill();
            this._0x330120e1 = null;
        }

        this._0xd3a1e967 = true;
        this._0x8506d4e9 = false;
        this._0x8be5d0c5 = null;
        this._0xb11170f7 = 0f;
    }

    private readonly int[] _0xf74937d9 = new int[5];
    private float _0x301dc8c2;
    private int[] _0x8be5d0c5;
    /// Queues the stop. The column keeps scrolling until the delay has elapsed AND the strip
    /// has travelled a whole cell, so the landing is never a mid-cell snap.
    public void _0xf39dc8b3(int[] _0xee172a14, float _0x5179281e)
    {
        this._0x8be5d0c5 = _0xee172a14;
        this._0xa5ee9d7a = Time.time + _0x5179281e;
        this._0x8506d4e9 = true;
    }

    /// A short punch on the three visible cells of a line that paid.
    public void _0x872a7577(int _0xc159ecf6)
    {
        int _0x8e064c06 = Mathf.Clamp(_0xc159ecf6 + 1, 1, 3);
        RectTransform _0x454a0304 = this._0x2807413a[_0x8e064c06];
        if (_0x454a0304 == null)
        {
            return;
        }

        _0x454a0304.localScale = Vector3.one;
        _0x454a0304.DOPunchScale(Vector3.one * 0.14f, 0.28f, 6, 0.6f).SetLink(_0x454a0304.gameObject);
    }

    private float _0xa5ee9d7a;
    public bool _0x5769e318
    {
        get
        {
            return this._0xd3a1e967;
        }
    }

    private Sprite _0x079ad57a(int _0x2416b417)
    {
        if (this._0xb09b4285 == null || _0x2416b417 < 0 || _0x2416b417 >= this._0xb09b4285.Length)
        {
            return null;
        }

        return this._0xb09b4285[_0x2416b417];
    }

    private float _0xd10ceb7a;
    private readonly RectTransform[] _0x2807413a = new RectTransform[5];
    private Tween _0x330120e1;
    private float _0xb11170f7;
}

internal static class _0x54dccbd8
{
    internal static string _0xda214b8c(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}