using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

/// The cabinet and its five reel columns, plus the win light-up.
///
/// Draw order is built in the order content must stack (rule C.13): cabinet backplate, then
/// the win glow layer, then the columns. The glow therefore sits BEHIND the symbols and reads
/// as a backlight; nothing opaque is ever created after the content it decorates.
public sealed class _0xabe4bb10 : MonoBehaviour
{
    private RectTransform _0xc4b89a52;
    public static readonly float CabinetW = 1156f;
    public static readonly float InnerW = 1070f;
    private readonly List<Image> _0xc19db01f = new List<Image>();
    private Sprite _0x71b1d3ff;
    private Sequence _0x5b0c78b1;
    private Sprite _0x17e714ca;
    private readonly List<_0xa64c3fbd> _0xac70bc7a = new List<_0xa64c3fbd>();
    public static readonly float BoardAnchorY = 0.638f;
    public float _0x7e07794f(float _0x7a07788a, float _0xa4e52c5f)
    {
        return _0x7a07788a + (_0xa4e52c5f * (_0x97c3b88a.Reels - 1)) + 0.35f;
    }

    public void _0x10aa48dd(Sprite[] _0x44512968)
    {
        for (int _0x2dc590ca = 0; _0x2dc590ca < 14; _0x2dc590ca++)
        {
            Sprite _0x2532639b = _0x44512968 != null && _0x44512968.Length > 0 ? _0x44512968[_0x2dc590ca % _0x44512968.Length] : this._0x71b1d3ff;
            float _0x46a6fe22 = ((_0x2dc590ca % 7) - 3) * (InnerW / 7.4f);
            RectTransform _0x4fc65730 = _0xcc3029b1.Inner(this._0xee4c8b31, _0x89d253e7._0xb75ebf07(new byte[5] { 184, 155, 138, 153, 128 }, 235), _0x46a6fe22, (InnerH * 0.5f) + 40f, 64f, 64f);
            Image _0xdb54ddea = _0xcc3029b1.Picture(_0x4fc65730, _0x2532639b, _0xfbd72b05.WithAlpha(_0xfbd72b05.GoldSoft, 0.95f));
            this._0x0bd9ba4a.Add(_0xdb54ddea);
            float _0xda28d61b = InnerH * (0.6f + (0.05f * (_0x2dc590ca % 5)));
            _0x4fc65730.DOAnchorPosY(_0x4fc65730.anchoredPosition.y - _0xda28d61b, 1.05f + (0.07f * (_0x2dc590ca % 4))).SetEase(Ease.InQuad).SetLink(_0x4fc65730.gameObject);
            _0xdb54ddea.DOFade(0f, 1.2f).SetEase(Ease.InQuad).SetLink(_0xdb54ddea.gameObject);
        }
    }

    private void OnDestroy()
    {
        this._0x0c6cde4e();
        DOTween.Kill(this);
    }

    public void _0x38f09d8d(bool _0xa59f529e)
    {
        for (int _0x3a0cf638 = 0; _0x3a0cf638 < this._0xac70bc7a.Count; _0x3a0cf638++)
        {
            this._0xac70bc7a[_0x3a0cf638]._0x609285d4(_0xa59f529e);
        }

        if (this._0x5b0c78b1 == null)
        {
            return;
        }

        if (_0xa59f529e)
        {
            this._0x5b0c78b1.Pause();
        }
        else
        {
            this._0x5b0c78b1.Play();
        }
    }

    public static readonly float InnerH = 672f;
    private void _0x577b26e0()
    {
        for (int _0x60c81c4b = 0; _0x60c81c4b < this._0xc19db01f.Count; _0x60c81c4b++)
        {
            this._0xc19db01f[_0x60c81c4b].color = _0xfbd72b05.WithAlpha(_0xfbd72b05.Gold, 0f);
            this._0xc19db01f[_0x60c81c4b].gameObject.SetActive(false);
        }
    }

    public static readonly float CabinetH = 762f;
    private readonly List<Image> _0x0bd9ba4a = new List<Image>();
    public void _0x5365892d()
    {
        for (int _0x53a3efd4 = 0; _0x53a3efd4 < this._0x0bd9ba4a.Count; _0x53a3efd4++)
        {
            if (this._0x0bd9ba4a[_0x53a3efd4] != null)
            {
                Destroy(this._0x0bd9ba4a[_0x53a3efd4].gameObject);
            }
        }

        this._0x0bd9ba4a.Clear();
    }

    private Image _0xbee57d70()
    {
        for (int _0x3a2f43e8 = 0; _0x3a2f43e8 < this._0xc19db01f.Count; _0x3a2f43e8++)
        {
            if (!this._0xc19db01f[_0x3a2f43e8].gameObject.activeSelf)
            {
                this._0xc19db01f[_0x3a2f43e8].gameObject.SetActive(true);
                return this._0xc19db01f[_0x3a2f43e8];
            }
        }

        RectTransform _0x7bbba82f = _0xcc3029b1.Inner(this._0xc4b89a52, _0x89d253e7._0xb75ebf07(new byte[4] { 28, 55, 52, 44 }, 91), 0f, 0f, this._0xf58d0ae2, this._0xc6d241c9);
        Image _0x3094e368 = _0xcc3029b1.Plate(_0x7bbba82f, this._0x17e714ca, _0xfbd72b05.WithAlpha(_0xfbd72b05.Gold, 0f), 1.1f);
        this._0xc19db01f.Add(_0x3094e368);
        return _0x3094e368;
    }

    public void _0xccc519a4(Color _0x1ad84d03)
    {
        if (this._0xb74464a8 != null)
        {
            this._0xb74464a8.color = _0x1ad84d03;
        }
    }

    public void _0x9d1721eb()
    {
        this._0x577b26e0();
        this._0x0c6cde4e();
        for (int _0x323f26b4 = 0; _0x323f26b4 < this._0xac70bc7a.Count; _0x323f26b4++)
        {
            this._0xac70bc7a[_0x323f26b4]._0x63663a10();
        }
    }

    private Sprite[] _0x7f0bfe9a;
    public bool _0xfff94c19()
    {
        for (int _0xbbf6a540 = 0; _0xbbf6a540 < this._0xac70bc7a.Count; _0xbbf6a540++)
        {
            if (this._0xac70bc7a[_0xbbf6a540]._0x5769e318)
            {
                return true;
            }
        }

        return false;
    }

    private Image _0xb74464a8;
    public void _0xba4c19ee(Transform _0xbe905ab7, Sprite _0xf135c1f1, Sprite _0xcc2de185, Sprite _0x2f984842, Sprite[] _0x5f3240ea, int[, ] _0x90d315e4, int _0x5cad1994)
    {
        this._0x7f0bfe9a = _0x5f3240ea;
        this._0x17e714ca = _0xcc2de185;
        this._0x71b1d3ff = _0x2f984842;
        this._0xf58d0ae2 = InnerW / _0x97c3b88a.Reels;
        this._0xc6d241c9 = InnerH / _0x97c3b88a.Rows;
        this._0xee4c8b31 = _0xcc3029b1.Node(_0xbe905ab7, _0x89d253e7._0xb75ebf07(new byte[9] { 101, 82, 82, 91, 117, 88, 86, 69, 83 }, 55), 0.5f, BoardAnchorY, CabinetW, CabinetH);
        this._0xb74464a8 = _0xcc3029b1.Plate(this._0xee4c8b31, _0xf135c1f1, Color.white, 1.2f);
        this._0xc4b89a52 = _0xcc3029b1.Inner(this._0xee4c8b31, _0x89d253e7._0xb75ebf07(new byte[8] { 175, 145, 150, 180, 153, 129, 157, 138 }, 248), 0f, 0f, InnerW, InnerH);
        for (int _0xdd80bec1 = 0; _0xdd80bec1 < _0x97c3b88a.Reels; _0xdd80bec1++)
        {
            float _0x6ba67675 = (_0xdd80bec1 - 2) * this._0xf58d0ae2;
            RectTransform _0x92d7cfe6 = _0xcc3029b1.Inner(this._0xee4c8b31, _0x89d253e7._0xb75ebf07(new byte[4] { 47, 24, 24, 17 }, 125), _0x6ba67675, 0f, this._0xf58d0ae2, InnerH);
            int[] _0xbfc170b6 = new int[_0x97c3b88a.Rows];
            for (int _0xf9df2786 = 0; _0xf9df2786 < _0x97c3b88a.Rows; _0xf9df2786++)
            {
                _0xbfc170b6[_0xf9df2786] = _0x90d315e4 != null ? _0x90d315e4[_0xdd80bec1, _0xf9df2786] : 0;
            }

            _0xa64c3fbd _0xe7605069 = _0x92d7cfe6.gameObject.AddComponent<_0xa64c3fbd>();
            _0xe7605069._0x4d3b513a(_0x92d7cfe6, _0x5f3240ea, this._0xf58d0ae2, this._0xc6d241c9, _0xbfc170b6, _0x5cad1994 + (_0xdd80bec1 * 7919));
            this._0xac70bc7a.Add(_0xe7605069);
        }
    }

    /// Lights the cells of every paying line in sequence and punches the symbols on them.
    public void _0xcb6c82d1(_0x2937008f _0x4ab26396)
    {
        this._0x577b26e0();
        this._0x0c6cde4e();
        if (_0x4ab26396 == null || _0x4ab26396.WinningLines.Count == 0)
        {
            return;
        }

        this._0x5b0c78b1 = DOTween.Sequence().SetLink(this.gameObject);
        for (int _0xf1e7ce7b = 0; _0xf1e7ce7b < _0x4ab26396.WinningLines.Count; _0xf1e7ce7b++)
        {
            int _0x5f75da3f = _0x4ab26396.WinningLines[_0xf1e7ce7b];
            int _0x469e9094 = _0x4ab26396.WinningRuns[_0xf1e7ce7b];
            int[] _0x74a17188 = _0x97c3b88a.Lines[_0x5f75da3f];
            for (int _0xa13ca208 = 0; _0xa13ca208 < _0x469e9094 && _0xa13ca208 < this._0xac70bc7a.Count; _0xa13ca208++)
            {
                int _0xd51343e3 = _0x74a17188[_0xa13ca208];
                Image _0x06793678 = this._0xbee57d70();
                RectTransform _0x13a1c0ee = _0x06793678.rectTransform;
                _0x13a1c0ee.anchoredPosition = new Vector2((_0xa13ca208 - 2) * this._0xf58d0ae2, (1 - _0xd51343e3) * this._0xc6d241c9);
                _0x13a1c0ee.sizeDelta = new Vector2(this._0xf58d0ae2 * 1.02f, this._0xc6d241c9 * 0.94f);
                _0x06793678.color = _0xfbd72b05.WithAlpha(_0xfbd72b05.Gold, 0f);
                this._0x5b0c78b1.Insert(_0xf1e7ce7b * 0.30f, _0x06793678.DOFade(0.62f, 0.14f).SetLink(_0x06793678.gameObject));
                this._0x5b0c78b1.Insert((_0xf1e7ce7b * 0.30f) + 0.22f, _0x06793678.DOFade(0.22f, 0.22f).SetLink(_0x06793678.gameObject));
                int _0x094610dc = _0xd51343e3;
                _0xa64c3fbd _0xfb9d909e = this._0xac70bc7a[_0xa13ca208];
                this._0x5b0c78b1.InsertCallback(_0xf1e7ce7b * 0.30f, () => _0xfb9d909e._0x872a7577(_0x094610dc));
            }
        }
    }

    /// Reels land left to right: reel 0 at 0.90 s, then +0.35 s each, so the last one settles
    /// at 2.30 s. The staggered landing is what makes a still frame read as "mid-spin".
    public void _0x2eb2acbe(int[, ] _0x1dd02c52, float _0xc0109908, float _0xbefc2c0d)
    {
        for (int _0x94d73cf6 = 0; _0x94d73cf6 < this._0xac70bc7a.Count; _0x94d73cf6++)
        {
            int[] _0xcd0ec631 = new int[_0x97c3b88a.Rows];
            for (int _0x6bccf443 = 0; _0x6bccf443 < _0x97c3b88a.Rows; _0x6bccf443++)
            {
                _0xcd0ec631[_0x6bccf443] = _0x1dd02c52[_0x94d73cf6, _0x6bccf443];
            }

            this._0xac70bc7a[_0x94d73cf6]._0xf39dc8b3(_0xcd0ec631, _0xc0109908 + (_0xbefc2c0d * _0x94d73cf6));
        }
    }

    private float _0xc6d241c9;
    private float _0xf58d0ae2;
    public float _0x1448d5d6
    {
        get
        {
            return this._0xf58d0ae2;
        }
    }

    private RectTransform _0xee4c8b31;
    private void _0x0c6cde4e()
    {
        if (this._0x5b0c78b1 != null)
        {
            this._0x5b0c78b1.Kill();
            this._0x5b0c78b1 = null;
        }
    }
}

internal static class _0x89d253e7
{
    internal static string _0xb75ebf07(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}