using UnityEngine;

/// Scores a resolved 5 x 3 grid: five paylines left to right from reel 0, WILD substitution,
/// SCATTER paid from anywhere. Pure logic, no Unity objects - which is what lets the exact
/// same code score the validation sweep inside ReelStripBuilder.
public static class _0x4bf33ba1
{
    public static int CountScatters(int[, ] _0x97e13996)
    {
        int _0x2446e783 = 0;
        for (int _0x9d53336a = 0; _0x9d53336a < _0x97c3b88a.Reels; _0x9d53336a++)
        {
            for (int _0x7f1f8a27 = 0; _0x7f1f8a27 < _0x97c3b88a.Rows; _0x7f1f8a27++)
            {
                if (_0x97c3b88a.IsScatter(_0x97e13996[_0x9d53336a, _0x7f1f8a27]))
                {
                    _0x2446e783++;
                }
            }
        }

        return _0x2446e783;
    }

    /// grid[reel, row]; row 0 is the top row.
    public static _0x2937008f Resolve(int[, ] _0xe9856180, long _0x07ea668b)
    {
        long _0xdc3a8302 = 0L;
        _0x2937008f _0xc1d5747c = new _0x2937008f();
        int _0x7cddb816 = _0x97c3b88a.Lines.Length;
        for (int _0x7dc8eec8 = 0; _0x7dc8eec8 < _0x7cddb816; _0x7dc8eec8++)
        {
            int[] _0xedd11a23 = _0x97c3b88a.Lines[_0x7dc8eec8];
            int _0x202dce35 = -1;
            for (int _0x9be31390 = 0; _0x9be31390 < _0x97c3b88a.Reels; _0x9be31390++)
            {
                int _0x47c411f9 = _0xe9856180[_0x9be31390, _0xedd11a23[_0x9be31390]];
                if (_0x97c3b88a.IsScatter(_0x47c411f9))
                {
                    break;
                }

                if (!_0x97c3b88a.IsWild(_0x47c411f9))
                {
                    _0x202dce35 = _0x47c411f9;
                    break;
                }
            }

            if (_0x202dce35 < 0)
            {
                // an opening made only of wilds pays as the top symbol
                _0x202dce35 = _0x97c3b88a.Wild;
            }

            int _0xdf12ff47 = 0;
            for (int _0x4455fe44 = 0; _0x4455fe44 < _0x97c3b88a.Reels; _0x4455fe44++)
            {
                int _0x408ba204 = _0xe9856180[_0x4455fe44, _0xedd11a23[_0x4455fe44]];
                if (_0x408ba204 == _0x202dce35 || _0x97c3b88a.IsWild(_0x408ba204))
                {
                    _0xdf12ff47++;
                }
                else
                {
                    break;
                }
            }

            if (_0xdf12ff47 >= _0x97c3b88a.MinRun)
            {
                long win = _0x07ea668b * _0x97c3b88a.Multiplier(_0x202dce35, _0xdf12ff47) / _0x97c3b88a.LineCount;
                _0xdc3a8302 += win;
                _0xc1d5747c._0xafc7cc06(_0x7dc8eec8, _0xdf12ff47, _0x202dce35);
            }
        }

        int _0xb3965b04 = CountScatters(_0xe9856180);
        long _0x00977da1 = 0L;
        if (_0xb3965b04 >= _0x97c3b88a.MinRun)
        {
            int _0xe29b2e85 = Mathf.Min(_0xb3965b04, 5);
            _0x00977da1 = _0x07ea668b * _0x97c3b88a.Multiplier(_0x97c3b88a.Scatter, _0xe29b2e85);
        }

        return _0xc1d5747c._0xc6557b45(_0xdc3a8302, _0x00977da1, _0xb3965b04);
    }

    /// How many cells of the grid carry one symbol - the album and the daily challenges both
    /// count landings this way.
    public static int CountSymbol(int[, ] _0x4e7779a0, int _0x0ede4def)
    {
        int _0x3fbe2fcf = 0;
        for (int _0xac3d2472 = 0; _0xac3d2472 < _0x97c3b88a.Reels; _0xac3d2472++)
        {
            for (int _0xc6c9aa5a = 0; _0xc6c9aa5a < _0x97c3b88a.Rows; _0xc6c9aa5a++)
            {
                if (_0x4e7779a0[_0xac3d2472, _0xc6c9aa5a] == _0x0ede4def)
                {
                    _0x3fbe2fcf++;
                }
            }
        }

        return _0x3fbe2fcf;
    }
}