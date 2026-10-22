using TMPro;
using UnityEngine;

/// The template defines more panels than this game dresses, and everything left undressed
/// keeps its placeholder string - "Lorem Ipsum", "HEADER", "Move items left". Rule C.15 says
/// those must never reach a screen, so every panel this game does not use has its labels
/// blanked at run time.
///
/// Blanked, NOT deactivated: the controllers address panels by index and a pulled-out object
/// would break navigation. Clearing the text is enough and costs nothing.
public sealed class _0x43a8a078 : MonoBehaviour
{
    /// SPLASH (0) and DEFAULT (1) are the two this game builds its own content into.
    private bool _0x156f8b51(int _0x29456029)
    {
        return _0x29456029 == _0x283dfe71._0x0485a4d3.SPLASH || _0x29456029 == _0x283dfe71._0x0485a4d3.DEFAULT;
    }

    private void _0x39c8c1b0(_0x126eaf94 _0x636ad6ec)
    {
        if (_0x636ad6ec == null)
        {
            return;
        }

        if (_0x636ad6ec.HeaderText != null)
        {
            _0x636ad6ec.HeaderText.text = string.Empty;
        }

        if (_0x636ad6ec.MainText != null)
        {
            _0x636ad6ec.MainText.text = string.Empty;
        }

        if (_0x636ad6ec.Content == null)
        {
            return;
        }

        TMP_Text[] _0xba1f3291 = _0x636ad6ec.Content.GetComponentsInChildren<TMP_Text>(true);
        for (int _0xc77c27e2 = 0; _0xc77c27e2 < _0xba1f3291.Length; _0xc77c27e2++)
        {
            if (_0xba1f3291[_0xc77c27e2] != null)
            {
                _0xba1f3291[_0xc77c27e2].text = string.Empty;
            }
        }
    }

    private void Start()
    {
        _0xb5c3d2c9 _0x38f0cc29 = _0xb5c3d2c9.Instance;
        if (_0x38f0cc29 == null || _0x38f0cc29.Panels == null)
        {
            return;
        }

        for (int _0x8f16c129 = 0; _0x8f16c129 < _0x38f0cc29.Panels.Count; _0x8f16c129++)
        {
            if (this._0x156f8b51(_0x8f16c129))
            {
                continue;
            }

            this._0x39c8c1b0(_0x38f0cc29.Panels[_0x8f16c129]);
        }
    }
}