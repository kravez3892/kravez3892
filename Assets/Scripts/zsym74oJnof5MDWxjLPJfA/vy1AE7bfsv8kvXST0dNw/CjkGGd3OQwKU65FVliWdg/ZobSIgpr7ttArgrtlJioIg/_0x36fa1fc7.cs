using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x36fa1fc7 : MonoBehaviour
{
    public GameObject Content;
    public static _0x36fa1fc7 Instance;
    public float FirstAnimationTime = 10.0f;
    public void _0x655eacda()
    {
        {
#if B_LOGS
            {
                Debug.Log($"[Test] Animate Force");
            }
#endif
        }

        this._0xa7ec9ea4?.Kill();
        if (AnimationSlider != null)
            this.AnimationSlider.value = 1f;
        _0xa67478e8 = false;
    }

    public GameObject Background;
    public void _0x2ae73bba()
    {
        this._0xa7ec9ea4?.Pause();
    }

    private static bool _0xa67478e8 = false;
    public Slider AnimationSlider;
    public void _0x9e4953f2()
    {
        this._0xf3a7b89b();
        bool _0xb13bffee = _0xa67478e8;
        this._0xa7ec9ea4 = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0xabbb50d1 => this.AnimationSlider.value = _0xabbb50d1, _0xb13bffee ? 1f : this.SecondPassSliderValue, this.DefaultAnimationTime)).SetEase(Ease.Linear);
        _0xa67478e8 = !_0xa67478e8;
    }

    public float DefaultAnimationTime = 0.4f;
    public void _0xbd171668()
    {
        this._0xa7ec9ea4?.Play();
    }

    private Sequence _0xa7ec9ea4;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x36fa1fc7>();
    }

    public GameObject Error;
    public void _0xf3a7b89b()
    {
        this._0xa7ec9ea4?.Kill();
        this.AnimationSlider.value = _0xa67478e8 ? this.SecondPassSliderValue : 0.05f;
    }

    private void _0x068a5b1a()
    {
        this.AnimationSlider.value = 0.05f;
        _0xa67478e8 = !_0xa67478e8;
        this._0xa7ec9ea4 = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0xabbb50d1 => this.AnimationSlider.value = _0xabbb50d1, 1f, this.FirstAnimationTime)).SetEase(Ease.Linear).OnComplete(() =>
        {
            _0x03d625e4._0xd7248771?._0x85443f32();
        });
    }

    public float SecondPassSliderValue = 0.5f;
    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == _0x283dfe71._0xf15fd126.SCENE_0 && !_0xa67478e8)
        {
            this._0x068a5b1a();
        }
        else
        {
            this._0x9e4953f2();
        }
    }
}