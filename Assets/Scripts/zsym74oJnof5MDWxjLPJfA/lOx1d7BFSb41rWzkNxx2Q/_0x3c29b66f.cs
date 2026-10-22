using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x3c29b66f : MonoBehaviour
{
    public List<Button> HomeButtons = new();
    private IEnumerator _0x674dc50e()
    {
        this._0xd8de9220();
        while (!this.IsGameEnd && this.TimeLeft > 0 && _0x19b9e3e8.Instance._0x19c2917e == this.CurrentGameIndex)
        {
            yield return new WaitForSeconds(1f);
            if (_0x19b9e3e8.Instance._0x44dd02f8)
            {
                if (this.IsGameEnd)
                    break;
                this.TimeLeft--;
                this._0xd8de9220();
            }
        }

        if (!this.IsGameEnd)
            this._0x57ca442c();
    }

    private void Start()
    {
        this.IsGameEnd = false;
        this.TimeLeft = this._0xbde0609b;
        this.CurrentGameIndex = _0x19b9e3e8.Instance._0x19c2917e;
        foreach (Button _0xe4b352ff in this.HomeButtons)
            _0xe4b352ff.onClick.AddListener(() =>
            {
                this._0x03dac9c0();
            });
        foreach (Button _0x3ee7848b in this.PauseButtons)
            _0x3ee7848b.onClick.AddListener(() =>
            {
                _0x19b9e3e8.Instance._0x3a1c9510(false);
                _0xc20c9bcf.Instance._0xba487545(_0x283dfe71._0x895c7d75.PAUSE);
            });
        this._0xcb35af08();
        this.LevelNumberText.ForEach(_0x19a0c54c => _0x19a0c54c.text = $"LVL {_0x19b9e3e8._0x8441741f._0x06b4f889 + 1}");
        if (_0xe1cce099.Instance.IsTimerEnabled)
        {
            this._0xd8de9220();
            this.StartCoroutine(this._0x674dc50e());
        }
    }

    [HideInInspector]
    public int ScoreCurrent;
    public void _0x03dac9c0()
    {
        _0x19b9e3e8.Instance._0x3a1c9510(true);
        _0x19b9e3e8.Instance._0xcd25bcc1(_0x283dfe71._0xf15fd126.SCENE_0);
    }

    public List<TMP_Text> SubtitleText = new();
    private static _0x3c29b66f _0x6e970685;
    private void _0xcb35af08()
    {
        if (_0xe1cce099.Instance.IsCheckScoreEnabled)
            this.ScoreText.ForEach(_0x19a0c54c => _0x19a0c54c.text = $"{this.ScoreCurrent}/{this._0xba945b9c}");
        else
            this.ScoreText.ForEach(_0x19a0c54c => _0x19a0c54c.text = $"{this.ScoreCurrent}");
    }

    public List<TMP_Text> ScoreText = new();
    public List<TMP_Text> TimerText = new();
    private void _0xd8de9220()
    {
        this.TimerText.ForEach(_0x19a0c54c => _0x19a0c54c.text = TimeSpan.FromSeconds(this.TimeLeft).ToString(_0x42e3dea1._0xcbdc0656(new byte[6] { 185, 185, 136, 238, 167, 167 }, 212)));
    }

    private int _0xbde0609b => this.CustomTimeInitial + _0x19b9e3e8._0x8441741f._0x06b4f889 * 10;

    public List<TMP_Text> LevelNumberText = new();
    public void _0xe01b6fe1(int scoreToAdd)
    {
        if (!this.IsGameEnd)
        {
            this.ScoreCurrent += scoreToAdd;
            this._0xcb35af08();
            this._0x7a39f5b9();
        }
    }

    [HideInInspector]
    public int CurrentGameIndex;
    public void _0x57ca442c()
    {
        if (_0xe1cce099.Instance.IsOnlyWinGameEndEnabled)
            this._0xd14cacfb();
        if (!this.IsGameEnd)
        {
            this._0x15b6ed09();
            _0x19b9e3e8.IsAfterLevelComplete = false;
            _0x19b9e3e8.IsAfterLevelFailed = true;
            _0xb371c2af _0x95796032 = _0xc20c9bcf.Instance._0x37f39018(_0x283dfe71._0x895c7d75.LOSE).GetComponent<_0xb371c2af>();
            if (_0xe1cce099.Instance.IsCheckScoreEnabled)
                _0x95796032.ContentMainText.text = $"{this.ScoreCurrent}/{this._0xba945b9c}";
            else
                _0x95796032.ContentMainText.text = $"{this.ScoreCurrent}";
            _0x95796032.ContentAdditionalText.text = $"{0}";
            _0x283dfe71._0x7c26fac4._0xaf9e7d41 += 0;
            _0xc20c9bcf.Instance._0xba487545(_0x283dfe71._0x895c7d75.LOSE);
        }
    }

    public List<Button> PauseButtons = new();
    public int CustomTimeInitial = 30;
    private void _0x33e22bd5()
    {
        if (this.ScoreCurrent >= this._0xba945b9c)
            this._0xd14cacfb();
        else
            this._0x57ca442c();
    }

    private void Awake()
    {
        _0x6e970685 = this.gameObject.GetComponent<_0x3c29b66f>();
    }

    private void _0x7a39f5b9()
    {
        if (this.ScoreCurrent > _0x19b9e3e8._0x8441741f._0x39d3d900)
            _0x19b9e3e8._0x8441741f._0x39d3d900 = this.ScoreCurrent;
        if (_0xe1cce099.Instance.IsCheckScoreEnabled)
            if (this.ScoreCurrent >= this._0xba945b9c)
                this._0xd14cacfb();
    }

    [HideInInspector]
    public bool IsGameEnd;
    private int _0xba945b9c => this.CustomTargetScore + _0x19b9e3e8._0x8441741f._0x06b4f889 * 10;

    private void _0x15b6ed09()
    {
        this.IsGameEnd = true;
        _0x19b9e3e8.IsAfterLevelComplete = true;
    }

    [HideInInspector]
    public int TimeLeft;
    private int _0xfa33f1c8 => this.ScoreCurrent;

    public int CustomTargetScore = 10;
    public void _0xd14cacfb()
    {
        if (!this.IsGameEnd)
        {
            this._0x15b6ed09();
            _0x19b9e3e8.IsAfterLevelComplete = true;
            _0x19b9e3e8.IsAfterLevelFailed = false;
            _0xb371c2af _0x600e9042 = _0xc20c9bcf.Instance._0x37f39018(_0x283dfe71._0x895c7d75.WIN).GetComponent<_0xb371c2af>();
            if (_0xe1cce099.Instance.IsCheckScoreEnabled)
                _0x600e9042.ContentMainText.text = $"{this.ScoreCurrent}/{this._0xba945b9c}";
            else
                _0x600e9042.ContentMainText.text = $"{this.ScoreCurrent}";
            if (_0xe1cce099.Instance.IsBestScoreEnabled)
            {
                if (this.ScoreCurrent > _0x283dfe71._0x7c26fac4._0xaf9e7d41)
                    _0x283dfe71._0x7c26fac4._0xaf9e7d41 = this.ScoreCurrent;
                _0x600e9042.ContentAdditionalText.text = $"{_0x283dfe71._0x7c26fac4._0xaf9e7d41}";
            }
            else
            {
                _0x600e9042.ContentAdditionalText.text = $"{this._0xfa33f1c8}";
                _0x283dfe71._0x7c26fac4._0xaf9e7d41 += this._0xfa33f1c8;
            }

            if (_0xe1cce099.Instance.IsLevelIncrementOnWin)
                ++_0x19b9e3e8._0x8441741f._0x06b4f889;
            _0xc20c9bcf.Instance._0xba487545(_0x283dfe71._0x895c7d75.WIN);
        }
    }
}

internal static class _0x42e3dea1
{
    internal static string _0xcbdc0656(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}