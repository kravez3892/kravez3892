using UnityEngine;

/// Builds the machine itself, once per session, from a seeded draw - so reel neighbourhoods,
/// near misses and clustering differ session to session and not only the numbers in the HUD
/// (rule C.11). The composition of a strip is fixed (SlotSymbols.Composition); what the
/// generator rolls is the ORDER.
///
/// Nothing is shipped on hope: every candidate machine is swept with the SAME resolver the
/// game scores with, and accepted only if it measures inside the band. Measured over 200
/// machines x 20 000 spins: RTP 0.9406 (sd 0.0187), 98.5% accepted on the first attempt, so
/// the hardcoded fallback is a safety net and never the game.
public static class _0xfa21e5a6
{
    public static readonly int SweepSpins = 20000;
    /// The safety net, never the game: a hand-checked machine used only if twenty seeded
    /// draws in a row all missed the band.
    private static int[][] Fallback()
    {
        return new int[][]
        {
            new int[]
            {
                6,
                4,
                2,
                5,
                1,
                3,
                6,
                0,
                4,
                5,
                2,
                6,
                3,
                4,
                1,
                5,
                7,
                2,
                6,
                0,
                3,
                4,
                1,
                5
            },
            new int[]
            {
                3,
                5,
                6,
                1,
                4,
                2,
                5,
                3,
                0,
                6,
                4,
                1,
                5,
                2,
                6,
                3,
                4,
                0,
                2,
                7,
                5,
                6,
                1,
                4
            },
            new int[]
            {
                5,
                2,
                4,
                6,
                3,
                1,
                4,
                5,
                6,
                0,
                2,
                3,
                5,
                4,
                1,
                6,
                7,
                3,
                2,
                5,
                0,
                4,
                6,
                1
            },
            new int[]
            {
                4,
                6,
                1,
                3,
                5,
                2,
                6,
                4,
                0,
                5,
                3,
                1,
                4,
                6,
                2,
                5,
                3,
                7,
                0,
                6,
                1,
                4,
                5,
                2
            },
            new int[]
            {
                2,
                3,
                5,
                4,
                6,
                1,
                5,
                2,
                4,
                0,
                6,
                3,
                1,
                5,
                4,
                2,
                6,
                3,
                7,
                5,
                0,
                1,
                4,
                6
            }
        };
    }

    public static readonly float RtpFloor = 0.88f;
    public static int[, ] Window(int[][] _0x29d458ad, int[] _0xa885239f)
    {
        int[, ] _0xbeb85a8b = new int[_0x97c3b88a.Reels, _0x97c3b88a.Rows];
        for (int _0xf62ea3c8 = 0; _0xf62ea3c8 < _0x97c3b88a.Reels; _0xf62ea3c8++)
        {
            for (int _0xc0f279f4 = 0; _0xc0f279f4 < _0x97c3b88a.Rows; _0xc0f279f4++)
            {
                _0xbeb85a8b[_0xf62ea3c8, _0xc0f279f4] = _0x29d458ad[_0xf62ea3c8][(_0xa885239f[_0xf62ea3c8] + _0xc0f279f4) % _0x97c3b88a.StripLength];
            }
        }

        return _0xbeb85a8b;
    }

    public static readonly int MaxAttempts = 20;
    public static readonly float RtpCeiling = 0.99f;
    /// One shuffled strip per reel, with no three identical symbols in a row (that reads as a
    /// broken reel rather than as luck).
    private static int[][] Draw(System.Random _0x5c68bfa1)
    {
        int[][] _0x14e00138 = new int[_0x97c3b88a.Reels][];
        for (int _0xb7a4e9d8 = 0; _0xb7a4e9d8 < _0x97c3b88a.Reels; _0xb7a4e9d8++)
        {
            int[] _0x2fc4dcc8 = new int[_0x97c3b88a.StripLength];
            int _0xb60e334f = 0;
            for (int _0x2b72307b = 0; _0x2b72307b < _0x97c3b88a.Count; _0x2b72307b++)
            {
                for (int _0x279913f5 = 0; _0x279913f5 < _0x97c3b88a.Composition[_0x2b72307b]; _0x279913f5++)
                {
                    _0x2fc4dcc8[_0xb60e334f] = _0x2b72307b;
                    _0xb60e334f++;
                }
            }

            for (int _0x7805efef = _0x2fc4dcc8.Length - 1; _0x7805efef > 0; _0x7805efef--)
            {
                int _0x1df4bff1 = _0x5c68bfa1.Next(_0x7805efef + 1);
                int _0xe4ccc6db = _0x2fc4dcc8[_0x7805efef];
                _0x2fc4dcc8[_0x7805efef] = _0x2fc4dcc8[_0x1df4bff1];
                _0x2fc4dcc8[_0x1df4bff1] = _0xe4ccc6db;
            }

            for (int _0x2ab0ce01 = 0; _0x2ab0ce01 < 3; _0x2ab0ce01++)
            {
                for (int _0x14f5e8cc = 0; _0x14f5e8cc < _0x2fc4dcc8.Length; _0x14f5e8cc++)
                {
                    int _0x72afaeac = _0x2fc4dcc8[(_0x14f5e8cc + _0x2fc4dcc8.Length - 2) % _0x2fc4dcc8.Length];
                    int _0x21571c3b = _0x2fc4dcc8[(_0x14f5e8cc + _0x2fc4dcc8.Length - 1) % _0x2fc4dcc8.Length];
                    if (_0x72afaeac == _0x2fc4dcc8[_0x14f5e8cc] && _0x21571c3b == _0x2fc4dcc8[_0x14f5e8cc])
                    {
                        int _0x3decd6cd = _0x5c68bfa1.Next(_0x2fc4dcc8.Length);
                        int _0x77c0a4df = _0x2fc4dcc8[_0x14f5e8cc];
                        _0x2fc4dcc8[_0x14f5e8cc] = _0x2fc4dcc8[_0x3decd6cd];
                        _0x2fc4dcc8[_0x3decd6cd] = _0x77c0a4df;
                    }
                }
            }

            _0x14e00138[_0xb7a4e9d8] = _0x2fc4dcc8;
        }

        return _0x14e00138;
    }

    /// A symbol that is missing from two or more reels can never make a five, and the paytable
    /// then lies about what the machine can do.
    private static bool EverySymbolWidelyPresent(int[][] _0x0e8c5633)
    {
        for (int _0xa09c1ac0 = 0; _0xa09c1ac0 < _0x97c3b88a.Count; _0xa09c1ac0++)
        {
            int _0x55f1b611 = 0;
            for (int _0xcdce9d91 = 0; _0xcdce9d91 < _0x97c3b88a.Reels; _0xcdce9d91++)
            {
                bool _0xf96a1cb9 = false;
                for (int _0xe74e0b83 = 0; _0xe74e0b83 < _0x0e8c5633[_0xcdce9d91].Length; _0xe74e0b83++)
                {
                    if (_0x0e8c5633[_0xcdce9d91][_0xe74e0b83] == _0xa09c1ac0)
                    {
                        _0xf96a1cb9 = true;
                        break;
                    }
                }

                if (!_0xf96a1cb9)
                {
                    _0x55f1b611++;
                }
            }

            if (_0x55f1b611 > 1)
            {
                return false;
            }
        }

        return true;
    }

    private static float Sweep(int[][] _0xe8bf815e, System.Random _0x77f63031)
    {
        long _0xbed907d0 = 0L;
        long _0x6a2cd11c = 0L;
        int[] _0x704682e8 = new int[_0x97c3b88a.Reels];
        for (int _0xadfed0d6 = 0; _0xadfed0d6 < SweepSpins; _0xadfed0d6++)
        {
            for (int _0x670440e0 = 0; _0x670440e0 < _0x97c3b88a.Reels; _0x670440e0++)
            {
                _0x704682e8[_0x670440e0] = _0x77f63031.Next(_0x97c3b88a.StripLength);
            }

            _0x2937008f _0x4438839f = _0x4bf33ba1.Resolve(Window(_0xe8bf815e, _0x704682e8), SweepBet);
            _0xbed907d0 += SweepBet;
            _0x6a2cd11c += _0x4438839f.TotalWin;
        }

        if (_0xbed907d0 <= 0L)
        {
            return 0f;
        }

        return (float)_0x6a2cd11c / (float)_0xbed907d0;
    }

    public static int[][] Build(System.Random _0x35446629)
    {
        for (int _0xd435c6f0 = 0; _0xd435c6f0 < MaxAttempts; _0xd435c6f0++)
        {
            int[][] _0x5f446be9 = Draw(_0x35446629);
            float _0x1ffbff25 = Sweep(_0x5f446be9, _0x35446629);
            bool _0x522fc77d = EverySymbolWidelyPresent(_0x5f446be9);
            bool _0x2c6b72d2 = PaysEarly(_0x5f446be9, _0x35446629);
            {
#if B_LOGS
                {
                    Debug.Log($"[strips] attempt={_0xd435c6f0} rtp={_0x1ffbff25:F4} spread={_0x522fc77d} early={_0x2c6b72d2}");
                }
#endif
            }

            if (_0x1ffbff25 >= RtpFloor && _0x1ffbff25 <= RtpCeiling && _0x522fc77d && _0x2c6b72d2)
            {
                return _0x5f446be9;
            }
        }

        {
#if B_LOGS
            {
                Debug.Log(_0xd81c2057._0x6fcbc68f(new byte[67] { 38, 14, 9, 15, 20, 13, 14, 32, 93, 24, 11, 24, 15, 4, 93, 28, 9, 9, 24, 16, 13, 9, 93, 16, 20, 14, 14, 24, 25, 93, 9, 21, 24, 93, 31, 28, 19, 25, 93, 80, 93, 8, 14, 20, 19, 26, 93, 9, 21, 24, 93, 27, 28, 17, 17, 31, 28, 30, 22, 93, 16, 28, 30, 21, 20, 19, 24 }, 125));
            }
#endif
        }

        return Fallback();
    }

    public static readonly long SweepBet = 50L;
    /// A machine that pays nothing in its first dozen spins feels broken, however honest its
    /// long-run return is.
    private static bool PaysEarly(int[][] _0x2ccce2d3, System.Random _0x50a04035)
    {
        int[] _0x0172dc82 = new int[_0x97c3b88a.Reels];
        for (int _0x4feecebb = 0; _0x4feecebb < 12; _0x4feecebb++)
        {
            for (int _0x0256b7d6 = 0; _0x0256b7d6 < _0x97c3b88a.Reels; _0x0256b7d6++)
            {
                _0x0172dc82[_0x0256b7d6] = _0x50a04035.Next(_0x97c3b88a.StripLength);
            }

            _0x2937008f _0x5edbc4f7 = _0x4bf33ba1.Resolve(Window(_0x2ccce2d3, _0x0172dc82), SweepBet);
            if (_0x5edbc4f7.WinningLines.Count > 0)
            {
                return true;
            }
        }

        return false;
    }
}

internal static class _0xd81c2057
{
    internal static string _0x6fcbc68f(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}