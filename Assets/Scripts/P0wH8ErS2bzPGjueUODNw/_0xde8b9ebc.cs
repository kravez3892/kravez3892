using UnityEngine;

/// Every sprite this game draws, held as ONE serialized block so each director carries a
/// single field in the scene instead of seventeen. References are {fileID, guid} and nothing
/// is ever looked up by name or loaded from Resources - those break under obfuscation.
[System.Serializable]
public sealed class _0xde8b9ebc
{
    public Sprite PaylineGlow;
    private Sprite[] _0x48966e08;
    public Sprite SymBell;
    public Sprite SymStar;
    public Sprite IconBack;
    public Sprite SymCoin;
    public Sprite DecorGarland;
    public Sprite SymLantern;
    public Sprite SymHorn;
    public Sprite _0x58665a31(int _0x029e904c)
    {
        Sprite[] _0x9a64692f = this._0x6dc9bfa6();
        if (_0x029e904c < 0 || _0x029e904c >= _0x9a64692f.Length)
        {
            return null;
        }

        return _0x9a64692f[_0x029e904c];
    }

    public Sprite EmblemMark;
    public Sprite CardPlate;
    public Sprite ButtonPlate;
    public Sprite ReelCabinet;
    public Sprite IconPause;
    public Sprite SymLonghorn;
    public Sprite SymRibbon;
    public Sprite IconClose;
    public Sprite SymDrum;
    /// The eight reel faces in symbol-id order, matching SlotSymbols.Names.
    public Sprite[] _0x6dc9bfa6()
    {
        if (this._0x48966e08 != null)
        {
            return this._0x48966e08;
        }

        this._0x48966e08 = new Sprite[]
        {
            this.SymLonghorn,
            this.SymHorn,
            this.SymLantern,
            this.SymBell,
            this.SymDrum,
            this.SymRibbon,
            this.SymCoin,
            this.SymStar
        };
        return this._0x48966e08;
    }
}