using UnityEngine;
using UnityEngine.UI;

public class _0xe0a7eb59 : MonoBehaviour
{
    private int _0x075f1399;
    private Button _0x4e3dbcce;
    private bool _0xc182f5e7;
    private void Awake()
    {
        if (this._0x4e3dbcce == null)
            if (!this.TryGetComponent(out this._0x4e3dbcce))
                this._0x4e3dbcce = this.GetComponentInChildren<Button>();
    }

    private void Start()
    {
        if (this._0xc182f5e7)
            this._0x4e3dbcce.onClick.AddListener(() => _0xb5c3d2c9.Instance._0xdb0751f1());
        else
            this._0x4e3dbcce.onClick.AddListener(() => _0xb5c3d2c9.Instance._0x75d56673(this._0x075f1399));
    }
}