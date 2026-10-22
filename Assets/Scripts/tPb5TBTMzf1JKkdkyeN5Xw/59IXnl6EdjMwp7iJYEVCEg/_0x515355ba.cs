using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x515355ba : MonoBehaviour
{
    private Image _0x9168f21d;
    private void Update()
    {
        this._0x2333a3ae();
    }

    private void _0x2333a3ae()
    {
        if (this._0x9168f21d.canvasRenderer.GetColor() != this._0xde21f967.canvasRenderer.GetColor())
            this._0xde21f967.canvasRenderer.SetColor(this._0x9168f21d.canvasRenderer.GetColor());
    }

    private TMP_Text _0xde21f967;
}