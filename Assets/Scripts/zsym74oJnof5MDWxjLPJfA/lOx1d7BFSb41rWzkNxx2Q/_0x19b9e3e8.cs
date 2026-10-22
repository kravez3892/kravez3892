using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static _0x283dfe71;

public class _0x19b9e3e8 : MonoBehaviour
{
    public static _0x19b9e3e8 Instance;
    private static _0x2bc4bf01 _0x0d4e42ce => _0x2bc4bf01.ALL_SCENES_SETTING_SINGLETONS[0];

    public void _0x765c4c36()
    {
        foreach (_0xa82a8197 _0xb4e1042c in this.MoneyCountContainers)
            _0xb4e1042c._0x7d6ee3a2();
    }

    public bool _0x44dd02f8 { get; private set; }

    public Button DeleteProgressDataButton;
    public static _0x2bc4bf01 _0x8441741f => _0x2bc4bf01.ALL_SCENES_SETTING_SINGLETONS[Instance._0x19c2917e];

    [HideInInspector]
    public List<_0xa82a8197> MoneyCountContainers = new();
    private static _0x2bc4bf01 GAME_INDEX_SETTINGS(int _0xd12a01ea)
    {
        return _0x2bc4bf01.ALL_SCENES_SETTING_SINGLETONS[_0xd12a01ea];
    }

    public void _0x3a1c9510(bool _0x2de82322)
    {
        this._0x44dd02f8 = _0x2de82322;
        this._0x186e9585(!this._0x44dd02f8);
        Physics2D.simulationMode = this._0x44dd02f8 ? SimulationMode2D.FixedUpdate : SimulationMode2D.Script;
        if (this.EnvironmentWithTweensToToggle != null)
            this._0x3e57c81d(this.EnvironmentWithTweensToToggle);
    }

    public static bool IsAfterLevelFailed = false;
    private static void MakeGrid(List<RectTransform> _0x15853f54, AspectRatioFitter _0x8bd24756, float _0xae5d9cc6, int _0xe4d98383, int _0x0ace1541)
    {
        _0x8bd24756.aspectMode = AspectRatioFitter.AspectMode.WidthControlsHeight;
        _0x8bd24756.aspectRatio = _0xae5d9cc6;
        foreach (RectTransform _0xabd28bcd in _0x15853f54)
        {
            int _0x810c9ded = _0xabd28bcd.transform.GetSiblingIndex();
            _0xabd28bcd.anchorMin = new Vector3(Mathf.FloorToInt((float)_0x810c9ded % _0xe4d98383) * (1f / _0xe4d98383), (_0x0ace1541 - (Mathf.FloorToInt((float)_0x810c9ded / _0xe4d98383) % _0x0ace1541 + 1f)) * (1f / _0x0ace1541));
            _0xabd28bcd.anchorMax = new Vector3(Mathf.FloorToInt((float)_0x810c9ded % _0xe4d98383 + 1f) * (1f / _0xe4d98383), (_0x0ace1541 - Mathf.FloorToInt((float)_0x810c9ded / _0xe4d98383) % _0x0ace1541) * (1f / _0x0ace1541));
            _0xabd28bcd.offsetMin = Vector2.zero;
            _0xabd28bcd.offsetMax = Vector2.zero;
        }
    }

    public void _0x490f153b()
    {
        _0x8441741f._0x45897a57 = true;
    }

    private IEnumerator _0xe2b1cb5b(string _0x32ff98e3)
    {
        _0xb5c3d2c9.Instance._0x75d56673(_0x0485a4d3.SPLASH);
        //AudioController.Instance.SaveLastMusicTimes();
        AsyncOperation _0x7727395f = SceneManager.LoadSceneAsync(_0x32ff98e3);
        while (!_0x7727395f.isDone)
            yield return null;
    }

    private static void ExitGame()
    {
        Application.Quit();
    }

    public Transform EnvironmentWithTweensToToggle;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x19b9e3e8>();
        this.RootGameObject = GameObject.FindWithTag(_0x31957204._0x82e80178(new byte[4] { 245, 200, 200, 211 }, 167));
        if (this._0x19c2917e == _0xf15fd126.SCENE_0)
            this._0x3a1c9510(true);
        else
            this._0x3a1c9510(false);
        this.MoneyCountContainers = this.RootGameObject.GetComponentsInChildren<_0xa82a8197>(true).ToList();
    }

    public static bool IsAfterLevelComplete;
    private void Start()
    {
        if (this._0x19c2917e != _0xf15fd126.SCENE_0)
            Screen.orientation = ScreenOrientation.Portrait;
        this.DeleteProgressDataButton?.onClick.AddListener(() =>
        {
            PlayerPrefs.DeleteAll();
            //AudioController.Instance.UpdateMusics();
            //AudioController.Instance.UpdateSfxes();
            Instance._0xcd25bcc1(_0xf15fd126.SCENE_0);
        });
        this.ShowResetTutorialButton?.onClick.AddListener(() =>
        {
            _0x8441741f._0x45897a57 = false;
            _0xc20c9bcf.Instance._0x2583cc0f();
            _0xb5c3d2c9.Instance._0x75d56673(_0x0485a4d3.TUTORIAL0);
        });
    }

    public Canvas MainCanvas;
    private void _0x186e9585(bool _0x2cef3a65)
    {
        Rigidbody2D[] _0xa0f1314d = this.RootGameObject.GetComponentsInChildren<Rigidbody2D>(true);
        foreach (Rigidbody2D _0x59d12294 in _0xa0f1314d)
            if (_0x2cef3a65)
                _0x59d12294.constraints = RigidbodyConstraints2D.FreezeAll;
            else
                _0x59d12294.constraints = RigidbodyConstraints2D.None;
    }

    [HideInInspector]
    public GameObject RootGameObject; // tag - "Root"
    public Transform Environment;
    private void _0x3e57c81d(Transform _0x83c036e7)
    {
        Transform[] _0x2aaa8d25 = _0x83c036e7.GetComponentsInChildren<Transform>();
        foreach (Transform _0x2509fdfa in _0x2aaa8d25)
            if (_0x2509fdfa != null && DOTween.IsTweening(_0x2509fdfa))
            {
                if (this._0x44dd02f8)
                    DOTween.Play(_0x2509fdfa);
                else
                    DOTween.Pause(_0x2509fdfa);
            }
    }

    public void _0xcd25bcc1(int _0x84898809)
    {
        //if (SceneManager.GetActiveScene().buildIndex == sceneIndex)
        //    AdsInitializer.Instance?.ShowAd();
        this.StartCoroutine(this._0x59121604(_0x84898809));
    }

    public Button ShowResetTutorialButton;
    private IEnumerator _0x59121604(int _0xb112a4f6)
    {
        _0xb5c3d2c9.Instance._0x75d56673(_0x0485a4d3.SPLASH);
        AsyncOperation _0x97003baf = SceneManager.LoadSceneAsync(_0xb112a4f6);
        while (!_0x97003baf.isDone)
            yield return null;
    }

    private void _0xd9c39f1e()
    {
        IsAfterLevelComplete = true;
        Instance._0xcd25bcc1(_0xf15fd126.SCENE_0);
    }

    public int _0x19c2917e => SceneManager.GetActiveScene().buildIndex;

    public void _0xec85a977()
    {
        this._0xcd25bcc1(SceneManager.GetActiveScene().buildIndex);
    }
}

internal static class _0x31957204
{
    internal static string _0x82e80178(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}