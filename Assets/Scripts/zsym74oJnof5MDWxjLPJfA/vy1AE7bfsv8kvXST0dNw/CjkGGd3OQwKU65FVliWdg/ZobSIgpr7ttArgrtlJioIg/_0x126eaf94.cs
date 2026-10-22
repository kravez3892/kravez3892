using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x126eaf94 : MonoBehaviour
{
    public bool IsScaledDownOnAwake = true;
    private void _0x0e0cb41b()
    {
        if (this.OuterBackground != null)
        {
            Image _0x83065e50 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x83065e50, true);
            _0x83065e50.DOFade(1f, this.ScaleDuration / 2f);
        }
    }

    private bool _0x683d7009 => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    private void _0x7a30466b()
    {
        if (this.OuterBackground != null)
        {
            Image _0xade82b54 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xade82b54, true);
            _0xade82b54.DOFade(1f, 0f);
        }
    }

    public GameObject Content;
    public float ScaleDuration = 0.4f;
    public void _0x859748b3()
    {
        this._0x7a30466b();
        this.Content.SetActive(true);
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.localScale = Vector3.one;
        _0xb5c3d2c9.Instance._0x07520bba(_0xb5c3d2c9.Instance.CurrentPanelIndex);
    }

    public void _0x73b77ed6()
    {
        this._0x9a7ae706();
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
        {
            this.Content.SetActive(false);
        });
    }

    private void _0x0dc60237()
    {
        if (this.OuterBackground != null)
        {
            Image _0x767404c9 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x767404c9, true);
            _0x767404c9.DOFade(0f, 0.01f);
        }

        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, 0.01f);
    }

    public GameObject OuterBackground;
    public Ease Ease = Ease.OutSine;
    public TMP_Text MainText;
    public void Show()
    {
        this._0x0e0cb41b();
        if (this.Content != null)
        {
            DOTween.Kill(this.Content.transform, true);
            this.Content.SetActive(true);
            this.Content.transform.DOScale(1f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
            {
                _0xb5c3d2c9.Instance._0x07520bba(_0xb5c3d2c9.Instance.CurrentPanelIndex);
            });
        }
    }

    public TMP_Text HeaderText;
    private void _0x9a7ae706()
    {
        if (this.OuterBackground != null)
        {
            Image _0xa4d18c94 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xa4d18c94, true);
            _0xa4d18c94.DOFade(0f, this.ScaleDuration);
        }
    }

    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.OuterBackground != null)
            this.OuterBackground.gameObject.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0x0dc60237();
    }
}