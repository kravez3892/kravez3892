using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0x283dfe71;

public class _0xc20c9bcf : MonoBehaviour
{
    public List<GameObject> GameObjectsToHide;
    private void Start()
    {
        this.BackgroundHidden();
        foreach (_0xb371c2af _0xb7471693 in this.Pops)
            if (_0xb7471693 != null)
                _0xb7471693.gameObject.SetActive(true);
    }

    public List<int> LastPopIndexes = new();
    public int CurrentPopIndex;
    private void _0xb67033df(bool _0x4f020d33 = false)
    {
        for (int _0x93c647c9 = 0; _0x93c647c9 < this.Pops.Count; ++_0x93c647c9)
            if (this.Pops[_0x93c647c9] != null && !(_0x93c647c9 == this.CurrentPopIndex && _0x4f020d33))
                this.Pops[_0x93c647c9]._0x44d439e0();
    }

    public void _0x2583cc0f()
    {
        this.LastPopIndexes.Clear();
        this._0xb67033df();
        foreach (GameObject _0x1ae0406a in this.GameObjectsToHide)
            if (_0x1ae0406a != null)
                _0x1ae0406a.SetActive(true);
        this._0xb00ed32b();
    }

    public GameObject BlurBackground;
    public static _0xc20c9bcf Instance;
    public void _0x131be90d()
    {
        this.LastPopIndexes.RemoveAll(_0x3c86a077 => _0x3c86a077 == this.CurrentPopIndex);
        if (this.LastPopIndexes.Count <= 0)
            this._0x2583cc0f();
        else
            this._0xba487545(this.LastPopIndexes.Last());
    }

    public _0xb371c2af _0x37f39018(int _0x44172730)
    {
        return this.Pops[_0x44172730];
    }

    private void _0xb00ed32b()
    {
        this.Invoke(nameof(this.BackgroundHidden), this.ScaleDuration);
    }

    private void BackgroundHidden()
    {
        this.BlurBackground.gameObject.SetActive(false);
    }

    public void _0xba487545(int _0xb3559299)
    {
        this.CurrentPopIndex = _0xb3559299;
        this.LastPopIndexes.Add(this.CurrentPopIndex);
        this._0xb67033df(true);
        this._0x3efb7fec();
        this.Pops[_0xb3559299].Show();
        foreach (GameObject _0x0297688e in this.GameObjectsToHide)
            _0x0297688e.SetActive(false);
    }

    public float ScaleDuration = 0.4f;
    public List<_0xb371c2af> Pops;
    private void _0x3efb7fec()
    {
        this.BlurBackground.gameObject.SetActive(true);
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xc20c9bcf>();
    }
}