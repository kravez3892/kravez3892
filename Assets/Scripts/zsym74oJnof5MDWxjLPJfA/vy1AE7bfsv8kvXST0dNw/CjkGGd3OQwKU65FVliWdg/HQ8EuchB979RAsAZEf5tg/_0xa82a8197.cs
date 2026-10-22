using TMPro;
using UnityEngine;
using static _0x283dfe71;

public class _0xa82a8197 : MonoBehaviour
{
    private void Start()
    {
        if (this.MoneyCountText == null)
        {
            TMP_Text _0x1a9b2383;
            if (this.gameObject.TryGetComponent(out _0x1a9b2383))
                this.MoneyCountText = _0x1a9b2383;
        }

        this._0x7d6ee3a2();
    }

    public TMP_Text MoneyCountText;
    public void _0x7d6ee3a2()
    {
        this.MoneyCountText.text = _0x7c26fac4._0xaf9e7d41.ToString();
    }
}