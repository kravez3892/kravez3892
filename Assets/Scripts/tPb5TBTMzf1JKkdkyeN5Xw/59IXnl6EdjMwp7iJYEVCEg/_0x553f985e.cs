using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class _0x553f985e : MonoBehaviour
{
    private float _0x4b2016ff = 1.5f;
    private float _0x1908600a = 4;
    private float _0xd0141be2;
    private TMP_Text _0x7772292f;
    private AspectRatioFitter _0x2b50d7f0;
    private float _0xc4391582 = 0.6f;
    private void Update()
    {
        int _0x220964df = 1;
        if (this._0x7254bf75.Count > 0)
        {
            string _0x9648d2f4 = this._0x7772292f.text;
            foreach (string _0xeb024d5d in this._0x7254bf75)
                while (_0x9648d2f4.Contains(_0xeb024d5d))
                    _0x9648d2f4 = _0x9648d2f4.Replace(_0xeb024d5d, "");
            _0x220964df = _0x9648d2f4.Length;
        }
        else
        {
            _0x220964df = this._0x7772292f.text.Length;
        }

        float _0x1cf02d41 = Mathf.Clamp(this._0xd0141be2 + this._0xc4391582 * _0x220964df, this._0x4b2016ff, this._0x1908600a);
        if (!Mathf.Approximately(this._0x2b50d7f0.aspectRatio, _0x1cf02d41))
            this._0x2b50d7f0.aspectRatio = _0x1cf02d41;
    }

    private List<string> _0x7254bf75 = new();
}