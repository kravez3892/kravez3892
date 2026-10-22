using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class _0xbcb1bc3a : MonoBehaviour
{
    private static _0xbcb1bc3a _0x9479f79a;
    private Touch? _0xb2163e82()
    {
        if (!_0x19b9e3e8.Instance._0x44dd02f8)
            return null;
        foreach (Touch _0x1beddfe3 in Touch.activeTouches)
            if (!_0x1beddfe3.ended)
                if (this._0xf4831574(_0x1beddfe3))
                    return _0x1beddfe3;
        return null;
    }

    private bool _0xf4831574(Touch? _0x79d76f3e)
    {
        if (!_0x79d76f3e.HasValue)
            return false;
        Vector3 _0xa2a01adf = Camera.main.ScreenToWorldPoint(_0x79d76f3e.Value.screenPosition);
        Vector3 _0x4b2fdaa9 = _0xa2a01adf;
        _0x4b2fdaa9.z = this.CameraTouchBounds.transform.position.z;
        if (this.CameraTouchBounds.bounds.Contains(_0x4b2fdaa9))
            return true;
        _0x79d76f3e = null;
        return false;
    }

    private void _0x49581485(Touch? _0xd0d2ecc4)
    {
        if (!_0x19b9e3e8.Instance._0x44dd02f8)
        {
            _0xd0d2ecc4 = null;
            return;
        }

        int _0x568feff4 = _0xd0d2ecc4.Value.touchId;
        _0xd0d2ecc4 = Touch.activeTouches.FirstOrDefault(_0x0c084fd2 => _0x0c084fd2.touchId == _0x568feff4);
        if (!this._0xf4831574(_0xd0d2ecc4.Value))
            _0xd0d2ecc4 = null;
    }

    public BoxCollider2D CameraTouchBounds;
    private Touch? _0x60b0989f(Bounds _0x55a17a16, TouchPhase _0x92066079)
    {
        if (!_0x19b9e3e8.Instance._0x44dd02f8)
            return null;
        foreach (Touch _0x1e34c902 in Touch.activeTouches)
            if (_0x1e34c902.phase == _0x92066079)
            {
                Vector3 _0xa318e63b = Camera.main.ScreenToWorldPoint(_0x1e34c902.screenPosition);
                Vector3 _0xfa11a30c = new(_0xa318e63b.x, _0xa318e63b.y, _0x55a17a16.center.z);
                if (_0x55a17a16.Contains(_0xfa11a30c) && this._0xf4831574(_0x1e34c902))
                    return _0x1e34c902;
            }

        return null;
    }

    private void Awake()
    {
        EnhancedTouchSupport.Enable();
        _0x9479f79a = this.gameObject.GetComponent<_0xbcb1bc3a>();
    }

    private Touch? _0xaf0ccbae()
    {
        if (!_0x19b9e3e8.Instance._0x44dd02f8)
            return null;
        foreach (Touch _0xe8b8b8a4 in Touch.activeTouches)
            if (_0xe8b8b8a4.ended)
                if (this._0xf4831574(_0xe8b8b8a4))
                    return _0xe8b8b8a4;
        return null;
    }

    private Touch? _0x1d931d8f(Bounds _0x2b95fde5)
    {
        if (!_0x19b9e3e8.Instance._0x44dd02f8)
            return null;
        foreach (Touch _0xd10d232e in Touch.activeTouches)
            if (_0xd10d232e.ended)
            {
                Vector3 _0x8d059098 = Camera.main.ScreenToWorldPoint(_0xd10d232e.screenPosition);
                Vector3 _0x70e7a7b6 = new(_0x8d059098.x, _0x8d059098.y, _0x2b95fde5.center.z);
                if (_0x2b95fde5.Contains(_0x70e7a7b6) && this._0xf4831574(_0xd10d232e))
                    return _0xd10d232e;
            }

        return null;
    }

    private Touch? _0x5b0b686b(Bounds _0x75c3cb37)
    {
        if (!_0x19b9e3e8.Instance._0x44dd02f8)
            return null;
        foreach (Touch _0x655c7c0b in Touch.activeTouches)
            if (!_0x655c7c0b.ended)
            {
                Vector3 _0xcb79af51 = Camera.main.ScreenToWorldPoint(_0x655c7c0b.screenPosition);
                Vector3 _0x0321e009 = new(_0xcb79af51.x, _0xcb79af51.y, _0x75c3cb37.center.z);
                if (_0x75c3cb37.Contains(_0x0321e009) && this._0xf4831574(_0x655c7c0b))
                    return _0x655c7c0b;
            }

        return null;
    }

    private bool _0x2d8de055(Touch? _0x6fbdb883, Bounds _0x5d95a7a2, TouchPhase _0x95c33c4f)
    {
        if (!_0x19b9e3e8.Instance._0x44dd02f8)
        {
            _0x6fbdb883 = null;
            return false;
        }

        if (_0x6fbdb883 != null)
            if (_0x6fbdb883.Value.phase == _0x95c33c4f)
            {
                Vector3 _0xf643eb76 = Camera.main.ScreenToWorldPoint(_0x6fbdb883.Value.screenPosition);
                Vector3 _0xfcc5e002 = new(_0xf643eb76.x, _0xf643eb76.y, _0x5d95a7a2.center.z);
                if (_0x5d95a7a2.Contains(_0xfcc5e002) && this._0xf4831574(_0x6fbdb883.Value))
                    return true;
            }

        return false;
    }
}