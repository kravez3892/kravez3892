using UnityEngine;
using UnityEngine.UI;

public class _0xcf3b50ee : MonoBehaviour
{
    public bool IsPhysicsRunOnClick;
    private void Start()
    {
        this.Button.onClick.AddListener(() => _0x19b9e3e8.Instance._0x3a1c9510(this.IsPhysicsRunOnClick));
    }

    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public Button Button;
}