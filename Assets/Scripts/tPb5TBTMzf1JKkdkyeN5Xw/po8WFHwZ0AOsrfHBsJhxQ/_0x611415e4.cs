using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class _0x611415e4 : MonoBehaviour
{
    private Vector3 _0x73ab0dc4 { get; set; }

    private _0xe7c0f788 _0x36d3f799 = _0xe7c0f788.Portrait;
    private Vector3 _0x063ff37d { get; set; }
    private Vector3 _0xbd3764e4 { get; set; }

    private void Awake()
    {
        this._0x1d12d461 = this.GetComponent<Camera>();
        _0xb603b3df = this;
        this._0x040676a8();
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = this._0x57778058;
        Matrix4x4 _0x63fb6700 = Gizmos.matrix;
        Gizmos.matrix = Matrix4x4.TRS(this.transform.position, this.transform.rotation, Vector3.one);
        if (this._0x1d12d461.orthographic)
        {
            float _0x48f1555a = this._0x1d12d461.farClipPlane - this._0x1d12d461.nearClipPlane;
            float _0xf744bf79 = (this._0x1d12d461.farClipPlane + this._0x1d12d461.nearClipPlane) * 0.5f;
            Gizmos.DrawWireCube(new Vector3(0, 0, _0xf744bf79), new Vector3(this._0x1d12d461.orthographicSize * 2 * this._0x1d12d461.aspect, this._0x1d12d461.orthographicSize * 2, _0x48f1555a));
        }
        else
        {
            Gizmos.DrawFrustum(Vector3.zero, this._0x1d12d461.fieldOfView, this._0x1d12d461.farClipPlane, this._0x1d12d461.nearClipPlane, this._0x1d12d461.aspect);
        }

        Gizmos.matrix = _0x63fb6700;
    }

    private Vector3 _0x49168760 { get; set; }

    private void _0x040676a8()
    {
        float _0xf2a35ee8, _0xaaa30582, _0xcca2ce70, _0x504c1327;
        if (this._0x36d3f799 == _0xe7c0f788.Landscape)
            this._0x1d12d461.orthographicSize = 1f / this._0x1d12d461.aspect * this._0x95ddf1f2 / 2f;
        else
            this._0x1d12d461.orthographicSize = this._0x95ddf1f2 / 2f;
        this._0x51b7b8a3 = 2f * this._0x1d12d461.orthographicSize;
        this._0xf3c43226 = this._0x51b7b8a3 * this._0x1d12d461.aspect;
        float _0x70ce4cdc = this._0x1d12d461.transform.position.x;
        float _0x354afd34 = this._0x1d12d461.transform.position.y;
        _0xf2a35ee8 = _0x70ce4cdc - this._0xf3c43226 / 2;
        _0xaaa30582 = _0x70ce4cdc + this._0xf3c43226 / 2;
        _0xcca2ce70 = _0x354afd34 + this._0x51b7b8a3 / 2;
        _0x504c1327 = _0x354afd34 - this._0x51b7b8a3 / 2;
        this._0xbd3764e4 = new Vector3(_0xf2a35ee8, _0x504c1327, 0);
        this._0x49168760 = new Vector3(_0x70ce4cdc, _0x504c1327, 0);
        this._0x73e5d2fd = new Vector3(_0xaaa30582, _0x504c1327, 0);
        this._0x063ff37d = new Vector3(_0xf2a35ee8, _0x354afd34, 0);
        this._0x73ab0dc4 = new Vector3(_0x70ce4cdc, _0x354afd34, 0);
        this._0x0294a577 = new Vector3(_0xaaa30582, _0x354afd34, 0);
        this._0x54924fd3 = new Vector3(_0xf2a35ee8, _0xcca2ce70, 0);
        this._0x8d1ab7db = new Vector3(_0x70ce4cdc, _0xcca2ce70, 0);
        this._0xbe8f7593 = new Vector3(_0xaaa30582, _0xcca2ce70, 0);
    }

    private Vector3 _0x0294a577 { get; set; }

    public enum _0xe7c0f788
    {
        Landscape,
        Portrait
    }

    //public bool executeInUpdate;
    private float _0xf3c43226 { get; set; }
    private Vector3 _0xbe8f7593 { get; set; }
    private Vector3 _0x73e5d2fd { get; set; }

    private new Camera _0x1d12d461;
    private float _0x95ddf1f2 = 1;
    private Color _0x57778058 = Color.white;
    private float _0x51b7b8a3 { get; set; }
    private Vector3 _0x8d1ab7db { get; set; }
    private Vector3 _0x54924fd3 { get; set; }

    private static _0x611415e4 _0xb603b3df;
}