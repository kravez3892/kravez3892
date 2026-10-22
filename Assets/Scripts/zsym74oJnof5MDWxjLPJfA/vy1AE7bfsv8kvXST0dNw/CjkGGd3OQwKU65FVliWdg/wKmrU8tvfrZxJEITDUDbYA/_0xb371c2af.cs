using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xb371c2af : MonoBehaviour
{
    public TMP_Text ContentAdditionalText;
    public void Show()
    {
        this.Content.SetActive(true);
        if ((DOTween.TweensByTarget(this.Content.transform)?.Count ?? 0) > 0)
            DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
        else
            this.Content.transform.DOScale(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
    }

    public bool IsScaledDownOnAwake = true;
    private bool _0xc8ebf9c9 => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    private void _0x5e06cbda()
    {
        DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(0f, 0.01f);
        else
            this.Content.transform.DOScale(0f, 0.01f);
        this.Content.SetActive(false);
    }

    public Image ContentImage;
    private void Start()
    {
    // Content.SetActive(false);
    }

    public bool IsOnlyYScale;
    public void _0x44d439e0()
    {
        if (this.Content.gameObject.activeSelf)
        {
            DOTween.Kill(this.Content.transform, true);
            if (this.IsOnlyYScale)
                this.Content.transform.DOScaleY(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
            else
                this.Content.transform.DOScale(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
        }
    }

    public TMP_Text ContentHeaderText;
    public TMP_Text ContentMainText;
    public float scaleDuration = 0.4f;
    public GameObject Content;
    public Ease ease = Ease.OutSine;
    public static void HideAllPops()
    {
        _0xc20c9bcf.Instance._0x2583cc0f();
    }

    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0x5e06cbda();
    }
}