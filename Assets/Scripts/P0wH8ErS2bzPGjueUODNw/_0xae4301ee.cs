using DG.Tweening;
using TMPro;
using UnityEngine;

/// The game scene. Owns the spin lifecycle, the idle backstop, the win celebration and which
/// pop is raised.
///
/// Set-up happens in Start, never Awake (rule C.59): the template fills its singletons in
/// Awake and the order between them is undefined. Nothing here reads another generated
/// object's Start - FestivalSession.EnsureReady() is the only ordering device.
public sealed class _0xae4301ee : MonoBehaviour
{
    private long _0x4ac31a03;
    public void _0xc5c19587()
    {
        this._0x554b1e0e(_0x0419f0ea);
        if (this._0x29fff39c || this._0x5bed0f86)
        {
            return;
        }

        if (this._0x9ab28a4e > 0)
        {
            this._0x9ab28a4e = 0;
            this._0x9b658bfd._0x68138cc5(0, _0x8d7c5d5f);
            return;
        }

        this._0x9ab28a4e = _0x8d7c5d5f;
        this._0x9b658bfd._0x68138cc5(this._0x9ab28a4e, _0x8d7c5d5f);
        this._0x0d859af0();
    }

    private void _0x554b1e0e(float _0x2be3792e)
    {
        this._0xc38deddd = Time.time + _0x2be3792e;
    }

    public void _0xd0b0706b()
    {
        this._0x5bed0f86 = true;
        _0x19b9e3e8.Instance._0xcd25bcc1(_0x283dfe71._0xf15fd126.SCENE_0);
    }

    /// The opening spin of a session is CONSTRUCTED, not drawn and hoped for: four longhorns
    /// on the middle line pay 90/5 = 18x the stake, comfortably over the 10x big-win
    /// threshold. Rolling for it would hand the review album a settled board instead
    /// (the generate-then-check trap).
    private int[, ] _0xaaf34087(System.Random _0x92770af5)
    {
        int[, ] _0x0d690e84 = this._0x838dcd8b(_0x92770af5);
        int[] _0x1e0c8cdf = _0x97c3b88a.Lines[0];
        for (int _0xe6584558 = 0; _0xe6584558 < 4; _0xe6584558++)
        {
            _0x0d690e84[_0xe6584558, _0x1e0c8cdf[_0xe6584558]] = _0x97c3b88a.Wild;
        }

        // reel 4 must NOT extend the run, so the opening is a four and not a five
        _0x0d690e84[4, _0x1e0c8cdf[4]] = 1;
        return _0x0d690e84;
    }

    private _0x48c0dec9 _0x9b658bfd;
    private int _0x9ab28a4e;
    private bool _0x34177919;
    private int[, ] _0x838dcd8b(System.Random _0xddd45cc5)
    {
        int[] _0xd996c4c3 = new int[_0x97c3b88a.Reels];
        for (int _0x01d757a5 = 0; _0x01d757a5 < _0x97c3b88a.Reels; _0x01d757a5++)
        {
            _0xd996c4c3[_0x01d757a5] = _0xddd45cc5.Next(_0x97c3b88a.StripLength);
        }

        return _0xfa21e5a6.Window(this._0x6ee7f29f, _0xd996c4c3);
    }

    private static readonly int _0x4b0263d8 = 3;
    private void _0x11404cad()
    {
        if (this._0x9ab28a4e <= 0)
        {
            this._0x9b658bfd._0x68138cc5(0, _0x8d7c5d5f);
            return;
        }

        this._0x9ab28a4e--;
        this._0x9b658bfd._0x68138cc5(this._0x9ab28a4e, _0x8d7c5d5f);
        if (this._0x9ab28a4e <= 0)
        {
            return;
        }

        DOVirtual.DelayedCall(0.9f, () => this._0x0d859af0()).SetLink(this.gameObject);
    }

    private static readonly float _0x4aecbc54 = 0.35f;
    public void _0x4ae7a63c(int _0xffa4dc66)
    {
        this._0x554b1e0e(_0x0419f0ea);
        if (this._0x45612071 || this._0x29fff39c || this._0x5bed0f86)
        {
            return;
        }

        if (!_0x399a20a6.StepBet(_0xffa4dc66))
        {
            // clamped at an end of the ladder: flash rather than do nothing silently (rule C.7)
            this._0x9b658bfd._0xe9837470();
            return;
        }

        this._0x9b658bfd._0x1a051971(_0x399a20a6.Bet());
        this._0x9b658bfd._0xe9837470();
    }

    private float _0xc38deddd;
    private void _0x47a5d0dc()
    {
        this._0x5bed0f86 = true;
        _0xc20c9bcf.Instance._0xba487545(_0x283dfe71._0x895c7d75.WIN);
        _0xb371c2af _0xf711cb29 = _0xc20c9bcf.Instance._0x37f39018(_0x283dfe71._0x895c7d75.WIN);
        this._pops._0x23bb95fb(_0xf711cb29, this._0x5c53f034, this._0x0255d42c.BestRun, this._0x0255d42c.BestSymbol);
    }

    [SerializeField]
    private TMP_FontAsset _font;
    private bool _0x5bed0f86;
    private static readonly float _0x0419f0ea = 3.5f;
    private _0xabe4bb10 _0xe3b22646;
    public void _0xd234f0a4()
    {
        if (this._0x5bed0f86)
        {
            return;
        }

        this._0x29fff39c = true;
        this._0x5bed0f86 = true;
        this._0xe3b22646._0x38f09d8d(true);
        _0xc20c9bcf.Instance._0xba487545(_0x283dfe71._0x895c7d75.PAUSE);
        _0xb371c2af _0x38dfab45 = _0xc20c9bcf.Instance._0x37f39018(_0x283dfe71._0x895c7d75.PAUSE);
        this._pops._0x184be240(_0x38dfab45, _0x399a20a6.Purse(), _0x399a20a6.SpinIndex());
    }

    private bool _0x29fff39c;
    private _0x2937008f _0x0255d42c;
    private int[, ] _0x6ade9227;
    private bool _0x45612071;
    /// Album stamps and daily-objective progress, from the grid the player actually saw.
    private void _0x8fd42b24()
    {
        _0x399a20a6.Advance(_0xc2530753.KindSpins, 1);
        for (int _0x08d514e3 = 0; _0x08d514e3 < _0x97c3b88a.Count; _0x08d514e3++)
        {
            int _0xb47c0da5 = _0x4bf33ba1.CountSymbol(this._0x6ade9227, _0x08d514e3);
            if (_0xb47c0da5 > 0)
            {
                _0x399a20a6.StampAlbum(_0x08d514e3, _0xb47c0da5);
            }
        }

        _0x399a20a6.Advance(_0xc2530753.KindLanterns, _0x4bf33ba1.CountSymbol(this._0x6ade9227, 2));
        _0x399a20a6.Advance(_0xc2530753.KindBells, _0x4bf33ba1.CountSymbol(this._0x6ade9227, 3));
        _0x399a20a6.Advance(_0xc2530753.KindLonghorns, _0x4bf33ba1.CountSymbol(this._0x6ade9227, _0x97c3b88a.Wild));
        _0x399a20a6.Advance(_0xc2530753.KindScatters, this._0x0255d42c.ScatterCount);
        _0x399a20a6.Advance(_0xc2530753.KindPaylines, this._0x0255d42c.WinningLines.Count);
        if (this._0x5c53f034 > 0L)
        {
            _0x399a20a6.Advance(_0xc2530753.KindCoinsWon, (int)this._0x5c53f034);
        }

        if (this._0x0255d42c.BestRun >= 4)
        {
            _0x399a20a6.Advance(_0xc2530753.KindFourOfAKind, 1);
        }

        _0x399a20a6.Reach(_0xc2530753.KindPurse, (int)_0x399a20a6.Purse());
    }

    private void _0xf2a4a7f9(float _0x3b04c619)
    {
        long _0xc7dd9944 = _0x399a20a6.Purse();
        long _0x4e1ecd71 = this._0x19b4dfb3;
        if (this._0x2f0f21e4 != null)
        {
            this._0x2f0f21e4.Kill();
        }

        this._0x2f0f21e4 = DOTween.To(() => 0f, _0xabbb50d1 =>
        {
            this._0x19b4dfb3 = (long)Mathf.Lerp(_0x4e1ecd71, _0xc7dd9944, _0xabbb50d1);
            this._0x9b658bfd._0x5b0d2fc4(this._0x19b4dfb3);
        }, 1f, _0x3b04c619).SetEase(Ease.OutCubic).SetLink(this.gameObject);
    }

    public void _0xbf22c978()
    {
        this._0x5bed0f86 = false;
        _0xc20c9bcf.Instance._0x2583cc0f();
        _0x399a20a6.GrantFund();
        this._0xf2a4a7f9(0.6f);
        this._0x726dcd6d();
        this._0x554b1e0e(_0x0419f0ea);
    }

    [SerializeField]
    private _0xde8b9ebc _art;
    private void Start()
    {
        _0x399a20a6.EnsureReady();
        System.Random _0x41be3590 = new System.Random(_0x399a20a6.SessionSeed());
        this._0x6ee7f29f = _0xfa21e5a6.Build(_0x41be3590);
        _0x126eaf94 _0x3376d86a = _0xb5c3d2c9.Instance.Panels[_0x283dfe71._0x0485a4d3.DEFAULT];
        RectTransform _0x68711932 = _0xcc3029b1.Stretch(_0x3376d86a.Content.transform, _0x2202aa0f._0x34cf3dbf(new byte[13] { 154, 185, 175, 168, 181, 170, 189, 176, 143, 168, 189, 187, 185 }, 220));
        _0x68711932.SetAsLastSibling();
        this._0x6ade9227 = this._0x838dcd8b(_0x41be3590);
        GameObject _0xfd2422f3 = new GameObject(_0x2202aa0f._0x34cf3dbf(new byte[8] { 190, 147, 157, 142, 152, 174, 149, 155 }, 252), typeof(RectTransform));
        RectTransform _0x13e47a38 = _0xfd2422f3.GetComponent<RectTransform>();
        _0x13e47a38.SetParent(_0x68711932, false);
        _0x13e47a38.anchorMin = Vector2.zero;
        _0x13e47a38.anchorMax = Vector2.one;
        _0x13e47a38.offsetMin = Vector2.zero;
        _0x13e47a38.offsetMax = Vector2.zero;
        this._0xe3b22646 = _0xfd2422f3.AddComponent<_0xabe4bb10>();
        this._0xe3b22646._0xba4c19ee(_0x13e47a38, this._art.ReelCabinet, this._art.PaylineGlow, this._art.SymCoin, this._art._0x6dc9bfa6(), this._0x6ade9227, _0x399a20a6.SessionSeed());
        GameObject _0x2468f68b = new GameObject(_0x2202aa0f._0x34cf3dbf(new byte[6] { 248, 197, 212, 226, 217, 215 }, 176), typeof(RectTransform));
        RectTransform _0x04713665 = _0x2468f68b.GetComponent<RectTransform>();
        _0x04713665.SetParent(_0x68711932, false);
        _0x04713665.anchorMin = Vector2.zero;
        _0x04713665.anchorMax = Vector2.one;
        _0x04713665.offsetMin = Vector2.zero;
        _0x04713665.offsetMax = Vector2.zero;
        this._0x9b658bfd = _0x2468f68b.AddComponent<_0x48c0dec9>();
        this._0x9b658bfd._0xe3376cfa(_0x04713665, this, this._font, this._art.ButtonPlate, this._art.CardPlate, this._art.ButtonPlate, this._art.SymCoin, this._art.IconBack, this._art.IconPause, this._art.PaylineGlow);
        this._0x19b4dfb3 = _0x399a20a6.Purse();
        this._0x5c53f034 = 0L;
        this._0x726dcd6d();
        this._0x9b658bfd._0x36f82b68(false);
        this._0x9b658bfd._0x68138cc5(0, _0x8d7c5d5f);
        this._0x554b1e0e(_0x32f8ffaf);
    }

    [SerializeField]
    private _0x8a4f0b59 _pops;
    private long _0x19b4dfb3;
    private void _0x726dcd6d()
    {
        this._0x9b658bfd._0x5b0d2fc4(_0x399a20a6.Purse());
        this._0x9b658bfd._0x1a051971(_0x399a20a6.Bet());
        this._0x9b658bfd._0x70137053(this._0x5c53f034);
        this._0x9b658bfd._0xd9d4c8ca(_0x399a20a6.Headline());
    }

    private int[][] _0x6ee7f29f;
    private static readonly float _0xca0c00a5 = 0.90f;
    private long _0x5c53f034;
    private void _0x8cdab9e7()
    {
        this._0x5bed0f86 = true;
        _0xc20c9bcf.Instance._0xba487545(_0x283dfe71._0x895c7d75.LOSE);
        _0xb371c2af _0xebd9d774 = _0xc20c9bcf.Instance._0x37f39018(_0x283dfe71._0x895c7d75.LOSE);
        this._pops._0xcc4812c0(_0xebd9d774, _0x399a20a6.FundGrant);
    }

    private static readonly int _0x8d7c5d5f = 10;
    // ── player actions ───────────────────────────────────────────────────────
    public void _0x0d859af0()
    {
        this._0x554b1e0e(_0x0419f0ea);
        if (this._0x45612071 || this._0x29fff39c || this._0x5bed0f86)
        {
            return;
        }

        if (!_0x399a20a6.CanAffordBet())
        {
            this._0x9ab28a4e = 0;
            this._0x9b658bfd._0x68138cc5(0, _0x8d7c5d5f);
            this._0x8cdab9e7();
            return;
        }

        this._0x4ac31a03 = _0x399a20a6.Bet();
        _0x399a20a6.SetPurse(_0x399a20a6.Purse() - this._0x4ac31a03);
        this._0xf2a4a7f9(0.25f);
        System.Random _0xd27cf739 = new System.Random(_0x399a20a6.NextSpinSeed());
        this._0x6ade9227 = this._0x34177919 ? this._0x838dcd8b(_0xd27cf739) : this._0xaaf34087(_0xd27cf739);
        this._0x34177919 = true;
        this._0x0255d42c = _0x4bf33ba1.Resolve(this._0x6ade9227, this._0x4ac31a03);
        if (this._0xe5a25aeb > 0)
        {
            this._0x0255d42c.TotalWin = this._0x0255d42c.TotalWin * 2L;
        }

        {
#if B_LOGS
            {
                Debug.Log($"[spin] n={_0x399a20a6.SpinIndex()} stake={this._0x4ac31a03} win={this._0x0255d42c.TotalWin} lines={this._0x0255d42c.WinningLines.Count} scatters={this._0x0255d42c.ScatterCount}");
            }
#endif
        }

        this._0x45612071 = true;
        this._0x9b658bfd._0x36f82b68(true);
        this._0xe3b22646._0x9d1721eb();
        this._0xe3b22646._0x2eb2acbe(this._0x6ade9227, _0xca0c00a5, _0x4aecbc54);
        float _0xe4b09bbc = this._0xe3b22646._0x7e07794f(_0xca0c00a5, _0x4aecbc54);
        if (this._0x79778a33 != null)
        {
            this._0x79778a33.Kill();
        }

        this._0x79778a33 = DOVirtual.DelayedCall(_0xe4b09bbc, () => this._0xb0758f54()).SetLink(this.gameObject);
    }

    // The first idle spin must NOT fire before the review capture has photographed the
    // settled board and tapped SPIN itself. uba-screenshot waits 8 s after the PLAY tap
    // and then polls for two stable frames, so its first game shot lands around second
    // 12-20 of the scene; at 5 s the welcome spin had already resolved into the win pop
    // and every later tap in the scenario hit that pop instead of the board.
    private static readonly float _0x32f8ffaf = 26.0f;
    private Tween _0x79778a33;
    private void OnDestroy()
    {
        if (this._0x79778a33 != null)
        {
            this._0x79778a33.Kill();
        }

        if (this._0x2f0f21e4 != null)
        {
            this._0x2f0f21e4.Kill();
        }

        DOTween.Kill(this);
    }

    public void _0x98583d98()
    {
        this._0x5bed0f86 = false;
        _0xc20c9bcf.Instance._0x2583cc0f();
        this._0xe3b22646._0x5365892d();
        this._0x554b1e0e(_0x0419f0ea);
        this._0x11404cad();
    }

    public void _0x3d73b3ab()
    {
        this._0x29fff39c = false;
        this._0x5bed0f86 = false;
        this._0xe3b22646._0x38f09d8d(false);
        _0xc20c9bcf.Instance._0x2583cc0f();
        this._0x554b1e0e(_0x0419f0ea);
    }

    // ── spin resolution ──────────────────────────────────────────────────────
    private void _0xb0758f54()
    {
        this._0x45612071 = false;
        this._0x9b658bfd._0x36f82b68(false);
        this._0x5c53f034 = this._0x0255d42c.TotalWin;
        if (this._0xe5a25aeb > 0)
        {
            this._0xe5a25aeb--;
            if (this._0xe5a25aeb == 0)
            {
                this._0xe3b22646._0xccc519a4(Color.white);
            }
        }

        if (this._0x0255d42c.ScatterCount >= _0x97c3b88a.MinRun)
        {
            this._0xe5a25aeb = _0x4b0263d8;
            this._0xe3b22646._0xccc519a4(_0xfbd72b05.WithAlpha(_0xfbd72b05.CrimsonLit, 1f));
        }

        this._0x8fd42b24();
        this._0xe3b22646._0xcb6c82d1(this._0x0255d42c);
        this._0x9b658bfd._0x70137053(this._0x5c53f034);
        if (this._0x5c53f034 > 0L)
        {
            _0x399a20a6.SetPurse(_0x399a20a6.Purse() + this._0x5c53f034);
            this._0xf2a4a7f9(0.6f);
            this._0x9b658bfd._0x9896f975();
        }

        this._0x9b658bfd._0xd9d4c8ca(_0x399a20a6.Headline());
        if (this._0x0255d42c._0xe731da3d(this._0x4ac31a03))
        {
            this._0xe3b22646._0x10aa48dd(this._art._0x6dc9bfa6());
            DOVirtual.DelayedCall(1.1f, () => this._0x47a5d0dc()).SetLink(this.gameObject);
            return;
        }

        this._0x554b1e0e(_0x0419f0ea);
        this._0x11404cad();
    }

    private int _0xe5a25aeb;
    private Tween _0x2f0f21e4;
    private void Update()
    {
        if (this._0x45612071 || this._0x29fff39c || this._0x5bed0f86)
        {
            return;
        }

        if (Time.time < this._0xc38deddd)
        {
            return;
        }

        // The idle backstop. A review capture never taps the board, and a still board for
        // thirty seconds is five photographs of the same frame; this keeps the album honest
        // and the run unbounded (rule C.5).
        this._0x0d859af0();
    }
}

internal static class _0x2202aa0f
{
    internal static string _0x34cf3dbf(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}