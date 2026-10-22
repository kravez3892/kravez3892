using UnityEngine;

public class _0xe1cce099 : MonoBehaviour
{
    private void _0xbacb1b53()
    {
        {
#if !B_LOGS
        {
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
        }
#endif
        }

        QualitySettings.vSyncCount = 1;
        Application.runInBackground = true;
    //Application.targetFrameRate = 60;
    // Time.fixedDeltaTime = 0.03f; // USE CUSTOM PHYSICS TIME FOR OPTIMIZATION IF NEEDED
    // Add this once at startup to silence the specific assertion
    }

    public static _0xe1cce099 Instance;
    public bool IsBestScoreEnabled;
    public bool IsOnlyWinGameEndEnabled;
    public bool IsTimerEnabled;
    public bool IsLevelIncrementOnWin;
    public bool IsCheckScoreEnabled;
    public bool IsTutorialEnabled;
    public bool IsSkipSplashEnabled;
    public bool IsLevelSelectorEnabled;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this.gameObject.GetComponent<_0xe1cce099>();
            DontDestroyOnLoad(this.gameObject);
            this._0xbacb1b53();
        }
        else
        {
            this._0xaa1a3d0d();
            Destroy(this.gameObject);
        }
    }

    private void _0xaa1a3d0d()
    {
    }

    public bool IsStoryEnabled;
}