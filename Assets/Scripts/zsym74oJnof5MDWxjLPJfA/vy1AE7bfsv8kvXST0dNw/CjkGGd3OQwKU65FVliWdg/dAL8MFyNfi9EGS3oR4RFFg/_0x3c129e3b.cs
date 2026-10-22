using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x3c129e3b : MonoBehaviour
{
    private void Start()
    {
        if (this.IsLoadCurrentScene)
            this.Button.onClick.AddListener(() =>
            {
                _0x19b9e3e8.Instance._0xcd25bcc1(SceneManager.GetActiveScene().buildIndex);
            });
        else
            this.Button.onClick.AddListener(() => _0x19b9e3e8.Instance._0xcd25bcc1(this.LoadSceneId));
    }

    public bool IsLoadCurrentScene;
    public Button Button;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public int LoadSceneId;
}