using UnityEngine;
using UnityEngine.UI;

public class _0x56edb119 : MonoBehaviour
{
    private void Start()
    {
        if (this.IsShowLastPop)
            this.Button.onClick.AddListener(() =>
            {
                _0xc20c9bcf.Instance._0x131be90d();
            });
        else if (this.IsHideAllPops)
            this.Button.onClick.AddListener(() => _0xc20c9bcf.Instance._0x2583cc0f());
        else
            this.Button.onClick.AddListener(() => _0xc20c9bcf.Instance._0xba487545(this.PopToShowIndex));
    }

    public bool IsShowLastPop;
    public Button Button;
    public bool IsHideAllPops;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public int PopToShowIndex;
}