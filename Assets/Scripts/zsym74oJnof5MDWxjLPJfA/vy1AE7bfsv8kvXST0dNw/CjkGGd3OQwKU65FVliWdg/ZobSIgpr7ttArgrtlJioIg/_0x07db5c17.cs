using UnityEngine;
using UnityEngine.UI;

public class _0x07db5c17 : MonoBehaviour
{
    public Button NextTutorialButton;
    public bool IsTutorialEndPanel;
    public Button TutorialEndButton;
    public int EndTutorialPanelIndex = 1;
    public int NextTutorialPanelIndex;
    private void Start()
    {
        if (this.NextTutorialButton != null)
        {
            if (this.IsTutorialEndPanel)
            {
                this.NextTutorialButton.onClick.AddListener(() => _0xb5c3d2c9.Instance._0x75d56673(this.EndTutorialPanelIndex));
                this.NextTutorialButton.onClick.AddListener(() => _0x19b9e3e8.Instance._0x490f153b());
            }
            else
            {
                this.NextTutorialButton.onClick.AddListener(() => _0xb5c3d2c9.Instance._0x75d56673(this.NextTutorialPanelIndex));
            }
        }

        if (this.TutorialEndButton != null)
        {
            this.TutorialEndButton.onClick.AddListener(() => _0xb5c3d2c9.Instance._0x75d56673(this.EndTutorialPanelIndex));
            this.TutorialEndButton.onClick.AddListener(() => _0x19b9e3e8.Instance._0x490f153b());
        }
    }
}