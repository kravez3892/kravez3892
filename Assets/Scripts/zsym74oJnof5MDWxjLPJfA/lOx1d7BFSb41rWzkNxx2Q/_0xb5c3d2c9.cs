using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0x283dfe71;

public class _0xb5c3d2c9 : MonoBehaviour
{
    private void _0x3c7cd7bd(int _0xf39fe206)
    {
        this.LastPanelIndexes.Add(_0xf39fe206);
        this.CurrentPanelIndex = _0xf39fe206;
        for (int _0x9f5aea91 = 0; _0x9f5aea91 < this.Panels.Count; _0x9f5aea91++)
            if (_0x9f5aea91 != _0xf39fe206 && this.Panels[_0x9f5aea91] != null)
                this.Panels[_0x9f5aea91]._0x73b77ed6();
    }

    private void SwitchSplash()
    {
        if (_0xe1cce099.Instance.IsTutorialEnabled && !_0x19b9e3e8._0x8441741f._0x45897a57)
            this._0x75d56673(_0x0485a4d3.TUTORIAL0);
        else
            this._0x75d56673(_0x0485a4d3.DEFAULT);
    }

    private void Start()
    {
        this._0x9d1db27a();
    }

    private void _0xf6b56d3b(int _0x410d6d72)
    {
        this._0xfa1e3aec(_0x410d6d72);
        this._0x03b307be(_0x410d6d72);
        this.CurrentPanelIndex = _0x410d6d72;
        this.Panels[_0x410d6d72]._0x859748b3();
    }

    public float StaticBlurMaterialInitialValue;
    private void _0x9d1db27a()
    {
        this._0xf6b56d3b(_0x0485a4d3.SPLASH);
        if (_0x19b9e3e8.Instance._0x19c2917e == _0xf15fd126.SCENE_0)
        {
        }
        else
        {
            this.Invoke(nameof(this.SwitchSplash), _0x36fa1fc7.Instance.DefaultAnimationTime);
        }
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xb5c3d2c9>();
    }

    public bool IsShowSplashOnStart = true;
    public List<_0x126eaf94> Panels;
    private void _0xfa1e3aec(int _0xd15bc74e)
    {
        this.LastPanelIndexes.Add(_0xd15bc74e);
        this.CurrentPanelIndex = _0xd15bc74e;
        for (int _0x48e43760 = 0; _0x48e43760 < this.Panels.Count; _0x48e43760++)
            if (_0x48e43760 != _0xd15bc74e && this.Panels[_0x48e43760] != null)
                this.Panels[_0x48e43760]._0x73b77ed6();
    }

    private _0x126eaf94 _0xcebd0368(int _0x3f9d0747)
    {
        return this.Panels[_0x3f9d0747];
    }

    public void _0x75d56673(int _0xe07ef75f)
    {
        this._0xfa1e3aec(_0xe07ef75f);
        this._0x03b307be(_0xe07ef75f);
        this.CurrentPanelIndex = _0xe07ef75f;
        this.Panels[_0xe07ef75f].Show();
    }

    [HideInInspector]
    public List<int> LastPanelIndexes = new()
    {
        1
    };
    public int CurrentPanelIndex;
    public float ScaleDuration = 0.4f;
    public static _0xb5c3d2c9 Instance;
    public void _0x07520bba(int _0x09c5130f)
    {
        if (_0x09c5130f == _0x0485a4d3.SPLASH && _0x19b9e3e8.Instance._0x19c2917e != _0xf15fd126.SCENE_0)
            _0x36fa1fc7.Instance._0x9e4953f2();
        if (_0x19b9e3e8.Instance._0x19c2917e != _0xf15fd126.SCENE_0)
        {
            if (_0x09c5130f == _0x0485a4d3.SPLASH || _0x09c5130f == _0x0485a4d3.TUTORIAL0)
                _0x19b9e3e8.Instance._0x3a1c9510(false);
            else if (_0x09c5130f == _0x0485a4d3.DEFAULT)
                _0x19b9e3e8.Instance._0x3a1c9510(true);
        }
    }

    private void _0x03b307be(int _0x32b99a6e)
    {
        if (_0x32b99a6e == _0x0485a4d3.SPLASH)
            _0x36fa1fc7.Instance._0xf3a7b89b();
        if (_0x19b9e3e8.Instance._0x19c2917e == _0xf15fd126.SCENE_0)
        {
        }
    }

    public void _0xdb0751f1()
    {
        this.LastPanelIndexes.RemoveAll(_0x3c86a077 => _0x3c86a077 == this.CurrentPanelIndex);
        int _0xe7f75a42 = this.LastPanelIndexes.Last();
        this._0x03b307be(_0xe7f75a42);
        this._0x3c7cd7bd(_0xe7f75a42);
        this.CurrentPanelIndex = _0xe7f75a42;
        this.Panels[_0xe7f75a42].Show();
    }
}