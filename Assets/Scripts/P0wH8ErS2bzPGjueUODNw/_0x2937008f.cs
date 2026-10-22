using System.Collections.Generic;

/// One resolved spin. A data object with no constructor (rule C.59): field initialisers plus
/// an Init that returns the object, so `new SpinOutcome().Init(...)` is the only way in.
public sealed class _0x2937008f
{
    public int BestSymbol;
    public readonly List<int> WinningRuns = new List<int>();
    public readonly List<int> WinningLines = new List<int>();
    public int BestRun;
    public long TotalWin;
    public bool _0xe731da3d(long _0xe64250d9)
    {
        return _0xe64250d9 > 0L && this.TotalWin >= _0xe64250d9 * 10L;
    }

    public long LineWin;
    public readonly List<int> WinningSymbols = new List<int>();
    public _0x2937008f _0xc6557b45(long _0x1b547075, long _0x033de97e, int _0xf8d11a87)
    {
        this.LineWin = _0x1b547075;
        this.ScatterWin = _0x033de97e;
        this.ScatterCount = _0xf8d11a87;
        this.TotalWin = _0x1b547075 + _0x033de97e;
        this.BestRun = 0;
        this.BestSymbol = -1;
        return this;
    }

    public int ScatterCount;
    public long ScatterWin;
    public _0x2937008f _0xafc7cc06(int _0x34e080ec, int _0xb70773cc, int _0x81097ed0)
    {
        this.WinningLines.Add(_0x34e080ec);
        this.WinningRuns.Add(_0xb70773cc);
        this.WinningSymbols.Add(_0x81097ed0);
        if (_0xb70773cc > this.BestRun)
        {
            this.BestRun = _0xb70773cc;
            this.BestSymbol = _0x81097ed0;
        }

        return this;
    }
}