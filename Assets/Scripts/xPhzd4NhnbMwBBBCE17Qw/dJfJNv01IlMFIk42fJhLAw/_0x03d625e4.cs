using AndroidInstallReferrer;
using DG.Tweening;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Unity.Notifications.Android;
using Unity.Services.Authentication;
using Unity.Services.CloudSave;
using Unity.Services.CloudSave.Models;
using Unity.Services.CloudSave.Models.Data.Player;
using Unity.Services.Core;
using Unity.Services.PushNotifications;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Application = UnityEngine.Application;

public class _0x03d625e4 : MonoBehaviour
{
    private bool _0x947cd640 = false;
    private void _0xe5201a27(string _0x7c3ce8fe)
    {
        bool _0x306b89be = !string.IsNullOrEmpty(_0x7c3ce8fe);
        if (_0x306b89be)
        {
            {
#if B_LOGS
                Debug.Log(_0xe1f5a500._0x3f4c2f3e(new byte[13] { 184, 183, 134, 144, 151, 190, 195, 176, 139, 140, 148, 217, 195 }, 227) + _0x7c3ce8fe);
#endif
            }

            _0xe6549544(_0x7c3ce8fe);
            return;
        }
        else
        {
            {
#if B_LOGS
                Debug.Log(_0xe1f5a500._0x3f4c2f3e(new byte[39] { 130, 141, 188, 170, 173, 132, 249, 159, 184, 181, 181, 187, 184, 186, 178, 249, 59, 95, 75, 249, 158, 184, 180, 188, 249, 241, 183, 182, 249, 191, 176, 183, 184, 181, 249, 140, 139, 149, 240 }, 217));
#endif
            }

            _0x0c410d79();
            return;
        }
    }

    public void _0x85443f32()
    {
        if (_0x0bbd3ce9)
            return;
        {
#if B_LOGS
            {
                Debug.Log(_0xe1f5a500._0x3f4c2f3e(new byte[33] { 111, 96, 81, 71, 64, 105, 20, 96, 93, 89, 81, 70, 20, 91, 65, 64, 20, 25, 10, 20, 89, 91, 66, 81, 20, 64, 91, 20, 71, 87, 81, 90, 81 }, 52));
            }
#endif
        }

        _0x0c410d79();
    }

    private string _0xb7f0ed11 = "";
    private bool _0xb6f89f72()
    {
        var _0x5104b4b7 = Keyboard.current;
        return _0x5104b4b7 != null && _0x5104b4b7.escapeKey.wasPressedThisFrame;
    }

    private void _0x0fece9fe(string _0x51b5426d)
    {
        Dictionary<string, object> _0xe5fad1d7;
        try
        {
            _0xe5fad1d7 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x51b5426d);
        }
        catch
        {
            return;
        }

        var _0x2e541c56 = ReadPushField(_0xe5fad1d7, _0xe1f5a500._0x3f4c2f3e(new byte[3] { 186, 189, 163 }, 207));
        if (string.IsNullOrWhiteSpace(_0x2e541c56))
            return;
        _0x2e541c56 = _0x2e541c56.Trim();
        if (!IsHttpUrl(_0x2e541c56))
            return;
        if (string.Equals(_0x2e541c56, _0xd39d4dd2, StringComparison.Ordinal))
            return;
        _0xd39d4dd2 = _0x2e541c56;
        OpenUrlExternally(_0x2e541c56);
    }

    private void _0xde6bb759(string _0x0ce0649b)
    {
        if (string.IsNullOrEmpty(_0x0ce0649b))
            return;
        if (TryOpenExternalLikeChrome(_0x0ce0649b))
            return;
        OpenUrlExternally(_0x0ce0649b);
    }

    private string _0xdd83582e()
    {
        try
        {
            using (var _0xd69a0a09 = new AndroidJavaClass(_0xe1f5a500._0x3f4c2f3e(new byte[30] { 107, 103, 101, 38, 125, 102, 97, 124, 113, 59, 108, 38, 120, 100, 105, 113, 109, 122, 38, 93, 102, 97, 124, 113, 88, 100, 105, 113, 109, 122 }, 8)))
            {
                var _0x81858701 = _0xd69a0a09.GetStatic<AndroidJavaObject>(_0xe1f5a500._0x3f4c2f3e(new byte[15] { 233, 255, 248, 248, 239, 228, 254, 203, 233, 254, 227, 252, 227, 254, 243 }, 138));
                var _0xd0f8e1e9 = _0x81858701.Call<AndroidJavaObject>(_0xe1f5a500._0x3f4c2f3e(new byte[21] { 117, 119, 102, 83, 98, 98, 126, 123, 113, 115, 102, 123, 125, 124, 81, 125, 124, 102, 119, 106, 102 }, 18));
                using (var _0x2455f9f9 = new AndroidJavaClass(_0xe1f5a500._0x3f4c2f3e(new byte[26] { 101, 106, 96, 118, 107, 109, 96, 42, 115, 97, 102, 111, 109, 112, 42, 83, 97, 102, 87, 97, 112, 112, 109, 106, 99, 119 }, 4)))
                {
                    return _0x2455f9f9.CallStatic<string>(_0xe1f5a500._0x3f4c2f3e(new byte[19] { 247, 245, 228, 212, 245, 246, 241, 229, 252, 228, 197, 227, 245, 226, 209, 247, 245, 254, 228 }, 144), _0xd0f8e1e9);
                }
            }
        }
        catch
        {
            return "";
        }
    }

    private IEnumerator _0xcce82d78()
    {
        {
#if B_LOGS
            {
                Debug.Log(_0xe1f5a500._0x3f4c2f3e(new byte[26] { 203, 196, 245, 227, 228, 205, 176, 217, 254, 249, 228, 249, 241, 252, 249, 234, 245, 194, 245, 246, 246, 245, 226, 245, 226, 176 }, 144));
            }
#endif
        }

        bool _0xe6682904 = false;
        InstallReferrer.GetReferrer((_0xfa037556) =>
        {
            Debug.Log(_0xe1f5a500._0x3f4c2f3e(new byte[24] { 145, 158, 175, 185, 190, 234, 152, 175, 172, 175, 184, 184, 175, 184, 151, 234, 173, 175, 190, 234, 40, 76, 88, 234 }, 202) + _0x32facfa8);
            if (_0xfa037556.IsSuccess)
            {
                _0x32facfa8 = _0xfa037556.InstallReferrer ?? "";
                {
#if B_LOGS
                    Debug.Log(_0xe1f5a500._0x3f4c2f3e(new byte[28] { 189, 178, 131, 149, 146, 198, 180, 131, 128, 131, 148, 148, 131, 148, 187, 198, 181, 147, 133, 133, 131, 149, 149, 198, 4, 96, 116, 198 }, 230) + _0x32facfa8);
#endif
                }
            }
            else
            {
                {
#if B_LOGS
                    Debug.Log(_0xe1f5a500._0x3f4c2f3e(new byte[27] { 97, 110, 95, 73, 78, 26, 104, 95, 92, 95, 72, 72, 95, 72, 103, 26, 124, 91, 83, 86, 95, 94, 26, 216, 188, 168, 26 }, 58) + _0xfa037556);
#endif
                }

                _0x32facfa8 = "";
            }

            _0x0af44a59 = true;
        });
        StartCoroutine(_0x0c231f95(2f));
        yield return new WaitUntil(() => _0x0af44a59);
        {
#if B_LOGS
            Debug.Log($"[Test] check google atr {_0x32facfa8}");
#endif
        }

        bool _0xf5d96a34 = _0x32facfa8.Contains(_0xe1f5a500._0x3f4c2f3e(new byte[6] { 86, 82, 93, 88, 85, 12 }, 49));
        _0xe6682904 = _0xf5d96a34 || _0x32facfa8.Contains(_0xe1f5a500._0x3f4c2f3e(new byte[18] { 154, 139, 139, 136, 213, 146, 149, 136, 143, 154, 156, 137, 154, 150, 213, 152, 148, 150 }, 251)) || _0x32facfa8.Contains(_0xe1f5a500._0x3f4c2f3e(new byte[17] { 99, 114, 114, 113, 44, 100, 99, 97, 103, 96, 109, 109, 105, 44, 97, 109, 111 }, 2));
        _0xa92be3a9 = _0xf5d96a34 ? "" : (_0xe6682904 ? "" : _0xa92be3a9);
        _0xa92be3a9 = _0xa92be3a9 ?? "";
        _0xcff77f08 = _0xcff77f08 ?? "";
        {
#if B_LOGS
            Debug.Log($"[Test] oneLinkData (FB): {_0xa92be3a9}");
#endif
        }
    }

    private async void Start()
    {
        await _0xd0cb6c33();
    }

    private void _0x4f95de60()
    {
        if (_0xf5731cdb)
        {
            WLog(_0xe1f5a500._0x3f4c2f3e(new byte[18] { 213, 232, 249, 228, 176, 241, 252, 226, 245, 241, 244, 233, 176, 227, 248, 255, 231, 254 }, 144));
            return;
        }

        _0x0d907438(false);
        WLog(_0xe1f5a500._0x3f4c2f3e(new byte[46] { 184, 148, 156, 155, 213, 162, 144, 151, 163, 156, 144, 130, 213, 165, 128, 134, 157, 213, 187, 154, 129, 156, 147, 156, 150, 148, 129, 156, 154, 155, 213, 221, 157, 148, 135, 145, 130, 148, 135, 144, 213, 151, 148, 150, 158, 220 }, 245));
        ++_0x1057781f;
        _0xd583a229();
        if (_0x1057781f <= 1)
            return;
        if (_0x48328738())
        {
            WLog(_0xe1f5a500._0x3f4c2f3e(new byte[37] { 158, 163, 178, 175, 251, 168, 176, 178, 171, 171, 190, 191, 251, 246, 229, 251, 171, 180, 171, 174, 171, 168, 251, 168, 175, 178, 183, 183, 251, 180, 171, 190, 181, 190, 191, 225, 251 }, 219) + _0x7695dc33.Count);
            return;
        }

        Application.Quit();
    }

    private void _0xe6549544(string _0x56eedd61)
    {
        _0xe82762a9();
        StartCoroutine(_0x30b82ce1(_0x56eedd61));
    }

    private bool _0x50448bde = false;
    private async Task<bool> _0xb012237c(int _0xf4f43ac2 = 5, int _0x1a2eb2a1 = 500)
    {
        List<EntityData> _0x1136a7be = new List<EntityData>();
        int _0xec6b18b5 = 0;
        do
        {
            try
            {
                _0x1136a7be = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0xe1f5a500._0x3f4c2f3e(new byte[8] { 192, 220, 209, 201, 213, 194, 249, 212 }, 176), _0xe61dc0c7, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0xe1f5a500._0x3f4c2f3e(new byte[9] { 36, 62, 29, 63, 36, 59, 44, 46, 52 }, 77) }), new QueryOptions())).ToList();
            }
            catch (Exception e)
            {
                {
#if B_LOGS
                    {
                        Debug.Log(_0xe1f5a500._0x3f4c2f3e(new byte[32] { 195, 204, 253, 235, 236, 197, 184, 233, 237, 253, 234, 225, 217, 235, 225, 246, 251, 202, 253, 235, 237, 244, 236, 235, 184, 253, 234, 234, 247, 234, 162, 184 }, 152) + e.Message);
                    }
#endif
                }
            }

            await Task.Delay(_0x1a2eb2a1);
        }
        while (_0x1136a7be.Count == 0 && _0xec6b18b5++ < _0xf4f43ac2);
        {
#if B_LOGS
            {
                Debug.Log(_0xe1f5a500._0x3f4c2f3e(new byte[32] { 49, 62, 15, 25, 30, 55, 74, 35, 25, 58, 24, 3, 28, 11, 9, 19, 74, 59, 31, 15, 24, 19, 74, 24, 15, 25, 31, 6, 30, 25, 80, 74 }, 106) + JsonConvert.SerializeObject(_0x1136a7be, Formatting.Indented));
            }
#endif
        }

        {
#if B_LOGS
            {
                Debug.Log(_0xe1f5a500._0x3f4c2f3e(new byte[38] { 205, 194, 243, 229, 226, 203, 182, 223, 229, 198, 228, 255, 224, 247, 245, 239, 182, 199, 227, 243, 228, 239, 182, 228, 243, 229, 227, 250, 226, 229, 182, 245, 249, 227, 248, 226, 172, 182 }, 150) + _0x1136a7be.Count);
            }
#endif
        }

        bool _0xcddefbed = true;
        if (_0x1136a7be.Count == 0)
        {
            _0xcddefbed = false;
        }
        else
        {
            _0xcddefbed = _0x1136a7be.Any(_0xb88be86c => _0xb88be86c.Data.Any(IsPrivacyItemTrue));
        }

        {
#if B_LOGS
            {
                Debug.Log(_0xe1f5a500._0x3f4c2f3e(new byte[25] { 215, 216, 233, 255, 248, 209, 172, 197, 255, 220, 254, 229, 250, 237, 239, 245, 172, 254, 233, 255, 249, 224, 248, 182, 172 }, 140) + _0xcddefbed);
            }
#endif
        }

        return _0xcddefbed;
    }

    private string _0x7e3d2f2a = "";
    internal bool isApplicationPause = false;
    private string _0x32facfa8 = "";
    internal bool firstLoadShown = false;
    private bool _0xf5731cdb = false;
    private string _0xa92be3a9 { get; set; }

    private IEnumerator _0x08f76fdc(IEnumerator _0xcd157186, TaskCompletionSource<bool> _0xbed3462f)
    {
        yield return _0xcd157186;
        _0xbed3462f.SetResult(true);
    }

    internal Button _0x0e5546c0(string _0xb20a2e24, Transform _0x668eb719)
    {
        var _0x528ed12b = new GameObject(_0xb20a2e24 + _0xe1f5a500._0x3f4c2f3e(new byte[3] { 254, 200, 210 }, 188), typeof(RectTransform), typeof(Image), typeof(Button));
        var _0x782fc553 = _0x528ed12b.GetComponent<RectTransform>();
        _0x782fc553.SetParent(_0x668eb719, false);
        var _0xc2dfd300 = _0x528ed12b.GetComponent<Image>();
        _0xc2dfd300.color = new Color(0.92f, 0.92f, 0.95f, 1f);
        var _0x9f34bbf3 = _0x528ed12b.GetComponent<Button>();
        var _0x569b88b4 = _0x9f34bbf3.colors;
        _0x569b88b4.highlightedColor = new Color(0.85f, 0.85f, 0.9f);
        _0x569b88b4.pressedColor = new Color(0.8f, 0.8f, 0.88f);
        _0x9f34bbf3.colors = _0x569b88b4;
        var _0x9dc35e1b = new GameObject(_0xe1f5a500._0x3f4c2f3e(new byte[4] { 112, 65, 92, 80 }, 36), typeof(RectTransform), typeof(Text));
        var _0xadb22c4b = _0x9dc35e1b.GetComponent<RectTransform>();
        _0xadb22c4b.SetParent(_0x528ed12b.transform, false);
        _0xadb22c4b.anchorMin = Vector2.zero;
        _0xadb22c4b.anchorMax = Vector2.one;
        _0xadb22c4b.offsetMin = _0xadb22c4b.offsetMax = Vector2.zero;
        var _0xc1d98896 = _0x9dc35e1b.GetComponent<Text>();
        _0xc1d98896.text = _0xb20a2e24;
        _0xc1d98896.alignment = TextAnchor.MiddleCenter;
        _0xc1d98896.color = Color.black;
        _0xc1d98896.font = Resources.GetBuiltinResource<Font>(_0xe1f5a500._0x3f4c2f3e(new byte[9] { 40, 27, 0, 8, 5, 71, 29, 29, 15 }, 105));
        _0xc1d98896.fontSize = 28;
        WLog(_0xe1f5a500._0x3f4c2f3e(new byte[14] { 8, 57, 46, 42, 63, 46, 9, 62, 63, 63, 36, 37, 107, 108 }, 75) + _0xb20a2e24 + _0xe1f5a500._0x3f4c2f3e(new byte[1] { 10 }, 45));
        return _0x9f34bbf3;
    }

    private async Task _0x2c00dba2()
    {
        {
#if B_LOGS
            Debug.Log($"[Test] Send click");
#endif
        }

        _0x3c5e3f17 = _0xe1f5a500._0x3f4c2f3e(new byte[5] { 187, 188, 177, 174, 184 }, 221);
        _0x40873579 = /*IsRunningOnEmulator() ? "running" :*/ "";
        _0xb7f0ed11 = DateTime.UtcNow.Ticks.ToString();
        _0xc5c47805 = "";
        JObject _0x86a7e7bf = _0x6af9b688(_0x7e3d2f2a, _0x72852a8f, _0x2d990cc7, _0x6edbf36e, _0x32facfa8, _0xa92be3a9, _0xcff77f08, _0x9b3dca3e, _0x0466e3cc, _0x4a87025d, _0x3c5e3f17, _0xc5c47805, _0x27c364a2, _0x604e9d81, _0xe025dced.ToString(), _0x7409a44f, _0xb7f0ed11, _0x40873579, _0xe61dc0c7, _0xfdb088f2, _0xdacb783f, _0x367381fa, _0xd138a518());
        var _0xededff57 = _0xe931a70a(_0x86a7e7bf.ToString(), _0xe61dc0c7);
        {
#if B_LOGS
            {
                Debug.Log($"[Test][First Run] Send Payload for first run: {_0x86a7e7bf}");
            }
#endif
        }

        try
        {
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0xe1f5a500._0x3f4c2f3e(new byte[7] { 150, 135, 159, 138, 137, 135, 130 }, 230) + _0xe61dc0c7, _0xededff57 } });
            await Task.Delay(500);
            string _0x3e517a5c = "";
            for (int _0xb64e46a1 = 0; _0xb64e46a1 < 20; _0xb64e46a1++)
            {
                if (await _0xb012237c(1, 1))
                {
                    await _0x5974f6f2(_0xe1f5a500._0x3f4c2f3e(new byte[7] { 175, 161, 162, 174, 166, 168, 169 }, 205));
                    _0x0c410d79();
                    return;
                }

                _0x3e517a5c = await _0x70af4a9e(1, 500);
                if (!string.IsNullOrEmpty(_0x3e517a5c))
                    break;
            }

            _0xe5201a27(_0x3e517a5c);
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0xe1f5a500._0x3f4c2f3e(new byte[22] { 40, 39, 54, 32, 39, 46, 83, 52, 22, 29, 22, 1, 18, 31, 83, 22, 1, 1, 28, 1, 73, 83 }, 115) + e.Message);
#endif
            }

            _0x0c410d79();
        }
    }

    private void _0xf5801677()
    {
        WLog(_0xe1f5a500._0x3f4c2f3e(new byte[21] { 126, 87, 68, 82, 65, 87, 68, 83, 22, 84, 87, 85, 93, 22, 70, 68, 83, 69, 69, 83, 82 }, 54));
        if (Time.frameCount == _0xbc0103c6)
            return;
        _0xbc0103c6 = Time.frameCount;
        if (_0xa949f7e2())
            return;
        _0x4f95de60();
    }

    private void _0xd9e0b19c()
    {
        {
#if B_LOGS
            Debug.Log(_0xe1f5a500._0x3f4c2f3e(new byte[22] { 233, 230, 215, 193, 198, 239, 146, 225, 198, 221, 192, 215, 246, 215, 196, 219, 209, 215, 251, 220, 212, 221 }, 178));
#endif
        }

        _0x27c364a2 = SystemInfo.deviceModel;
        _0x604e9d81 = Application.version;
        _0xe025dced = Application.installMode;
        _0x7409a44f = Application.installerName;
        _0x7e3d2f2a = Application.identifier;
        _0x2d990cc7 = _0xa52f12af();
        _0x9b3dca3e = _0xdd83582e();
        _0x4a87025d = SystemInfo.deviceUniqueIdentifier;
        _0xfdb088f2 = SystemInfo.graphicsDeviceName;
        _0xdacb783f = SystemInfo.processorType;
        {
#if B_LOGS
            {
                _0x604e9d81 = _0xe1f5a500._0x3f4c2f3e(new byte[5] { 15, 22, 15, 22, 15 }, 56);
                _0xe025dced = ApplicationInstallMode.Store;
                _0x7409a44f = _0xe1f5a500._0x3f4c2f3e(new byte[19] { 252, 240, 242, 177, 254, 241, 251, 237, 240, 246, 251, 177, 233, 250, 241, 251, 246, 241, 248 }, 159);
                _0x9b3dca3e = _0xe1f5a500._0x3f4c2f3e(new byte[8] { 173, 165, 184, 188, 177, 232, 189, 169 }, 200);
                _0x4a87025d = Guid.NewGuid().ToString().Replace(_0xe1f5a500._0x3f4c2f3e(new byte[1] { 139 }, 166), "");
            }
#endif
        }

        {
#if B_LOGS
            Debug.Log(_0xe1f5a500._0x3f4c2f3e(new byte[17] { 55, 56, 9, 31, 24, 49, 76, 8, 9, 26, 33, 3, 8, 9, 0, 86, 76 }, 108) + _0x27c364a2);
            Debug.Log(_0xe1f5a500._0x3f4c2f3e(new byte[19] { 23, 24, 41, 63, 56, 17, 108, 45, 60, 60, 26, 41, 62, 63, 37, 35, 34, 118, 108 }, 76) + _0x604e9d81);
            Debug.Log(_0xe1f5a500._0x3f4c2f3e(new byte[20] { 115, 124, 77, 91, 92, 117, 8, 65, 70, 91, 92, 73, 68, 68, 101, 71, 76, 77, 18, 8 }, 40) + _0xe025dced);
            Debug.Log(_0xe1f5a500._0x3f4c2f3e(new byte[23] { 38, 41, 24, 14, 9, 32, 93, 20, 19, 14, 9, 28, 17, 17, 24, 15, 46, 9, 18, 15, 24, 71, 93 }, 125) + _0x7409a44f);
            Debug.Log(_0xe1f5a500._0x3f4c2f3e(new byte[14] { 179, 188, 141, 155, 156, 181, 200, 137, 152, 152, 161, 140, 210, 200 }, 232) + _0x7e3d2f2a);
            Debug.Log(_0xe1f5a500._0x3f4c2f3e(new byte[14] { 220, 211, 226, 244, 243, 218, 167, 230, 227, 241, 206, 227, 189, 167 }, 135) + _0x2d990cc7);
            Debug.Log(_0xe1f5a500._0x3f4c2f3e(new byte[18] { 107, 100, 85, 67, 68, 109, 16, 69, 67, 85, 66, 113, 87, 85, 94, 68, 10, 16 }, 48) + _0x9b3dca3e);
            Debug.Log(_0xe1f5a500._0x3f4c2f3e(new byte[17] { 59, 52, 5, 19, 20, 61, 64, 19, 25, 19, 36, 5, 22, 41, 4, 90, 64 }, 96) + _0x4a87025d);
            Debug.Log(_0xe1f5a500._0x3f4c2f3e(new byte[12] { 58, 53, 4, 18, 21, 60, 65, 6, 17, 20, 91, 65 }, 97) + _0xfdb088f2);
            Debug.Log(_0xe1f5a500._0x3f4c2f3e(new byte[12] { 241, 254, 207, 217, 222, 247, 138, 201, 218, 223, 144, 138 }, 170) + _0xdacb783f);
#endif
        }
    }

    private static readonly string WindowsDesktopUserAgent = _0xe1f5a500._0x3f4c2f3e(new byte[111] { 221, 255, 234, 249, 252, 252, 241, 191, 165, 190, 160, 176, 184, 199, 249, 254, 244, 255, 231, 227, 176, 222, 196, 176, 161, 160, 190, 160, 171, 176, 199, 249, 254, 166, 164, 171, 176, 232, 166, 164, 185, 176, 209, 224, 224, 252, 245, 199, 245, 242, 219, 249, 228, 191, 165, 163, 167, 190, 163, 166, 176, 184, 219, 216, 196, 221, 220, 188, 176, 252, 249, 251, 245, 176, 215, 245, 243, 251, 255, 185, 176, 211, 248, 226, 255, 253, 245, 191, 161, 162, 160, 190, 160, 190, 160, 190, 160, 176, 195, 241, 246, 241, 226, 249, 191, 165, 163, 167, 190, 163, 166 }, 144);
    private JObject _0x6af9b688(params string[] _0x25a4b000)
    {
        JObject _0xdde7e1a0 = new JObject();
        foreach (var _0x42fafa50 in _0x25a4b000)
        {
            string _0x69d1493b = _0x82ac796b();
            {
#if B_LOGS
                Debug.Log($"[Test] Crypto key={_0x69d1493b} val={_0x42fafa50}");
#endif
            }

            _0xdde7e1a0.Add(_0x69d1493b, _0x42fafa50 == null ? "" : _0x42fafa50);
        }

        return _0xdde7e1a0;
    }

    private static string ReadPushField(Dictionary<string, object> _0x633a10ff, string _0x52bd56c5)
    {
        if (_0x633a10ff == null || string.IsNullOrEmpty(_0x52bd56c5))
            return string.Empty;
        if (_0x633a10ff.TryGetValue(_0xe1f5a500._0x3f4c2f3e(new byte[16] { 250, 251, 224, 253, 242, 253, 247, 245, 224, 253, 251, 250, 208, 245, 224, 245 }, 148), out var raw))
        {
            try
            {
                var _0x49b7f1b8 = JsonConvert.DeserializeObject<Dictionary<string, object>>(raw?.ToString());
                if (_0x49b7f1b8 != null && _0x49b7f1b8.TryGetValue(_0x52bd56c5, out var nestedVal))
                {
                    var _0xb049d463 = nestedVal?.ToString();
                    if (!string.IsNullOrEmpty(_0xb049d463))
                        return _0xb049d463;
                }
            }
            catch
            {
            }
        }

        if (_0x633a10ff.TryGetValue(_0x52bd56c5, out var flatVal))
            return flatVal?.ToString() ?? string.Empty;
        return string.Empty;
    }

    // WEB VIEW LOGIC END
    internal void _0xd583a229()
    {
        // Ensure channel exists (safe to call multiple times)
        var _0xfdcc83a3 = new AndroidNotificationChannel
        {
            Id = _0xe1f5a500._0x3f4c2f3e(new byte[15] { 18, 19, 16, 23, 3, 26, 2, 41, 21, 30, 23, 24, 24, 19, 26 }, 118),
            Name = _0xe1f5a500._0x3f4c2f3e(new byte[15] { 172, 141, 142, 137, 157, 132, 156, 200, 171, 128, 137, 134, 134, 141, 132 }, 232),
            Importance = Importance.High,
            Description = _0xe1f5a500._0x3f4c2f3e(new byte[21] { 172, 142, 133, 142, 153, 138, 135, 203, 133, 132, 159, 130, 141, 130, 136, 138, 159, 130, 132, 133, 152 }, 235)
        };
        AndroidNotificationCenter.RegisterNotificationChannel(_0xfdcc83a3);
        // Build notification
        var _0xe74a52f2 = new AndroidNotification
        {
            Title = _0xccaa15ba[UnityEngine.Random.Range(0, _0xccaa15ba.Length)],
            Text = _0xe1f5a500._0x3f4c2f3e(new byte[21] { 10, 57, 46, 107, 50, 36, 62, 107, 56, 62, 57, 46, 107, 63, 36, 107, 46, 51, 34, 63, 116 }, 75),
            FireTime = System.DateTime.Now
        };
        // Send immediately
        AndroidNotificationCenter.SendNotification(_0xe74a52f2, _0xe1f5a500._0x3f4c2f3e(new byte[15] { 20, 21, 22, 17, 5, 28, 4, 47, 19, 24, 17, 30, 30, 21, 28 }, 112));
    }

    internal Rect lastSafe = Rect.zero;
    private RectTransform _0xd74deb8e;
    private string _0x4a87025d = "";
    private async Task<bool> _0x29306495()
    {
        {
#if B_LOGS
            Debug.Log(_0xe1f5a500._0x3f4c2f3e(new byte[29] { 199, 200, 249, 239, 232, 193, 188, 213, 239, 204, 238, 245, 234, 253, 255, 229, 221, 242, 248, 207, 253, 234, 249, 248, 223, 244, 249, 255, 247 }, 156));
#endif
        }

        string _0xd58e4437 = "";
        for (int _0x7f04a2f2 = 0; _0x7f04a2f2 < 2; _0x7f04a2f2++)
        {
            if (await _0xb012237c(1, 100))
            {
                await _0x5974f6f2(_0xe1f5a500._0x3f4c2f3e(new byte[7] { 38, 40, 43, 39, 47, 33, 32 }, 68));
                _0x0c410d79();
                return true;
            }

            _0xd58e4437 = await _0x70af4a9e(1, 100);
            if (!string.IsNullOrEmpty(_0xd58e4437))
                break;
        }

        try
        {
            if (!string.IsNullOrEmpty(_0xd58e4437))
            {
                if (!string.IsNullOrEmpty(_0x24d4a25d))
                {
                    _0xd58e4437 = _0xf63ee8d3(_0xd58e4437, _0x24d4a25d);
                    {
#if B_LOGS
                        Debug.Log(_0xe1f5a500._0x3f4c2f3e(new byte[53] { 17, 30, 47, 57, 62, 23, 106, 9, 43, 41, 34, 47, 46, 106, 44, 35, 36, 43, 38, 31, 56, 38, 106, 61, 35, 62, 34, 106, 57, 47, 36, 46, 35, 46, 106, 168, 204, 216, 106, 57, 34, 37, 61, 106, 29, 47, 40, 28, 35, 47, 61, 112, 106 }, 74) + _0xd58e4437);
#endif
                    }
                }
                else
                {
                    {
#if B_LOGS
                        Debug.Log(_0xe1f5a500._0x3f4c2f3e(new byte[39] { 61, 50, 3, 21, 18, 59, 70, 37, 7, 5, 14, 3, 2, 70, 0, 15, 8, 7, 10, 51, 20, 10, 70, 132, 224, 244, 70, 21, 14, 9, 17, 70, 49, 3, 4, 48, 15, 3, 17 }, 102));
#endif
                    }
                }

                _0x42ad53e0 = true;
                _0xe6549544(_0xd58e4437);
                return true;
            }

            return false;
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0xe1f5a500._0x3f4c2f3e(new byte[44] { 252, 243, 194, 212, 211, 250, 135, 226, 223, 196, 194, 215, 211, 206, 200, 201, 135, 208, 207, 206, 203, 194, 135, 196, 207, 194, 196, 204, 206, 201, 192, 135, 212, 198, 209, 194, 195, 135, 203, 206, 201, 204, 157, 135 }, 167) + e.Message);
                }
#endif
            }

            return true;
        }
    }

    private IEnumerator _0x43bb1e21(string _0x70fd33a7)
    {
        if (Permission.HasUserAuthorizedPermission(_0x70fd33a7))
            yield break;
        bool _0x3926d549 = false;
        var _0xc83ffa86 = new PermissionCallbacks();
        _0xc83ffa86.PermissionGranted += _0xecd3fb2f => _0x3926d549 = true;
        _0xc83ffa86.PermissionDenied += _0xecd3fb2f => _0x3926d549 = true;
        Permission.RequestUserPermission(_0x70fd33a7, _0xc83ffa86);
        yield return new WaitUntil(() => _0x3926d549);
    }

    public void _0x0c410d79()
    {
        isDestroyedForce = true;
        StopAllCoroutines();
        {
#if B_LOGS
            Debug.Log(_0xe1f5a500._0x3f4c2f3e(new byte[18] { 227, 236, 221, 203, 204, 229, 152, 244, 217, 205, 214, 219, 208, 152, 255, 217, 213, 221 }, 184));
#endif
        }

        _0x36fa1fc7.Instance?._0x655eacda();
        _0xb5c3d2c9.Instance._0x75d56673(_0x283dfe71._0x0485a4d3.DEFAULT);
    }

    private void OnApplicationFocus(bool _0x243faad8)
    {
        isApplicationFocus = _0x243faad8;
        if (_0x243faad8 && _0x0bbd3ce9)
        {
            _0xe82762a9();
        }
    }

    private bool _0xa3e2578e = false;
    //    private async Task<string> GetMyip()
    //    {
    //        string result = "";
    //        var processorType = SystemInfo.processorType;
    //        //        {
    //        //#if NOT_B_STARTED
    //        //#endif
    //        if (!processorType.Contains("armv7", StringComparison.OrdinalIgnoreCase) && !processorType.Contains("x86-64", StringComparison.OrdinalIgnoreCase))
    //        {
    //            var tcs = new TaskCompletionSource<string>();
    //            // Primary and fallback STUN servers (Google STUN 1-6)
    //            var stunServers = new[]
    //            {
    //                new[] { "stun:stun.l.google.com:19302" },      // Primary
    //                //new[] { "stun:stun1.l.google.com:19302" },     // Fallback 1
    //                //new[] { "stun:stun2.l.google.com:19302" },     // Fallback 2
    //                //new[] { "stun:stun3.l.google.com:19302" },     // Fallback 3
    //                //new[] { "stun:stun4.l.google.com:19302" },     // Fallback 4
    //                //new[] { "stun:stun5.l.google.com:19302" },     // Fallback 5
    //                //new[] { "stun:stun6.l.google.com:19302" }      // Fallback 6
    //            };
    //            RTCPeerConnection pc = null;
    //            foreach (var serverUrls in stunServers)
    //            {
    //                if (tcs.Task.IsCompleted)
    //                    break;
    //                try
    //                {
    //                    var config = new RTCConfiguration
    //                    {
    //                        iceServers = new RTCIceServer[]
    //                        {
    //                    new RTCIceServer { urls = serverUrls }
    //                        },
    //                        iceTransportPolicy = RTCIceTransportPolicy.All
    //                    };
    //                    pc = new RTCPeerConnection(ref config);
    //                    pc.OnIceCandidate = candidate =>
    //                    {
    //                        if (candidate == null || tcs.Task.IsCompleted)
    //                            return;
    //                        if (candidate.Type == RTCIceCandidateType.Srflx || candidate.Type == RTCIceCandidateType.Prflx)
    //                        {
    //                            string address = candidate.Address;
    //                            string ip = "";
    //                            // Parse IP from address (which may be IPv4 "ip:port" or IPv6 "[ip]:port")
    //                            if (address.StartsWith("[") && address.Contains("]:"))
    //                            {
    //                                // IPv6 format: [2001:db8::1]:12345
    //                                int endBracket = address.IndexOf(']');
    //                                ip = address.Substring(1, endBracket - 1);
    //                            }
    //                            else if (address.Contains(':'))
    //                            {
    //                                // IPv4 format: 192.168.1.1:12345
    //                                int lastColon = address.LastIndexOf(':');
    //                                ip = address.Substring(0, lastColon);
    //                            }
    //                            else
    //                            {
    //                                // No port, just IP
    //                                ip = address;
    //                            }
    //                            {
    //#if B_LOGS
    //                                {
    //                                    Debug.Log($"[test STUN] Public IP: {ip} from {serverUrls[0]}");
    //                                }
    //#endif
    //                            }
    //                            tcs.TrySetResult(ip);
    //                        }
    //                    };
    //                    pc.CreateDataChannel("init");
    //                    var offerOp = pc.CreateOffer();
    //                    while (!offerOp.IsDone)
    //                        await Task.Yield();
    //                    var desc = offerOp.Desc;
    //                    pc.SetLocalDescription(ref desc);
    //                    float timeout = 10f;
    //                    float t = 0f;
    //                    while (!tcs.Task.IsCompleted && t < timeout)
    //                    {
    //                        await Task.Delay(100);
    //                        t += 0.1f;
    //                    }
    //                    if (tcs.Task.IsCompleted)
    //                    {
    //                        result = tcs.Task.Result;
    //                        break;
    //                    }
    //                    {
    //#if B_LOGS
    //                        {
    //                            Debug.Log($"[test STUN] Failed with {serverUrls[0]}, trying next...");
    //                        }
    //#endif
    //                    }
    //                }
    //                catch (Exception ex)
    //                {
    //#if B_LOGS
    //                    {
    //                        Debug.Log($"[test STUN] Error with {serverUrls[0]}: {ex.Message}");
    //                    }
    //#endif
    //                    if (pc != null)
    //                    {
    //                        pc.Close();
    //                        pc.Dispose();
    //                    }
    //                }
    //            }
    //            if (!tcs.Task.IsCompleted)
    //                result = "";
    //        }
    //        //#if NOT_B_STARTED
    //        //            else
    //        //        if(result == "")
    //        //        {
    //        //            {
    //        //#if B_LOGS
    //        //                {
    //        //                    Debug.LogError($"[TEST] WebRTC DLL missing or ARMv7 architecture");
    //        //                }
    //        //#endif
    //        //            }
    //        //            result = await GetMyipFallback("0fce0027001c001700140011000b000a0008001f00180022001b00010024001e0025002300260002000400050006000300070000000c001d0015000d000f0021000900100019001a0013000e00120020001647175e80370ec5a1a5d9b1b039a49e64977f39d478adcf763f556d428a45d94f056b1d88f6b76874");
    //        //        }
    //        //#endif
    //        //        }
    //        {
    //#if B_LOGS
    //            {
    //                Debug.Log($"[Test] Get my ip: {result}");
    //            }
    //#endif
    //        }
    //        return result;
    //    }
    private async Task<string> _0x12127396()
    {
        var _0x098adef4 = _0xe1f5a500._0x3f4c2f3e(new byte[40] { 11, 23, 23, 19, 16, 89, 76, 76, 20, 20, 20, 77, 0, 15, 12, 22, 7, 5, 15, 2, 17, 6, 77, 0, 12, 14, 76, 0, 7, 13, 78, 0, 4, 10, 76, 23, 17, 2, 0, 6 }, 99);
        using (UnityWebRequest _0xb355e3da = UnityWebRequest.Get(_0x098adef4))
        {
            await _0xb355e3da.SendWebRequest();
            string[] _0xe0f96535 = _0xb355e3da.downloadHandler.text.Split('\n');
            foreach (string _0x00b2bac6 in _0xe0f96535)
            {
                if (_0x00b2bac6.StartsWith(_0xe1f5a500._0x3f4c2f3e(new byte[3] { 216, 193, 140 }, 177)))
                {
                    string _0xf0685ada = _0x00b2bac6.Substring(3);
                    {
#if B_LOGS
                        {
                            Debug.Log($"[Test] User ip (FALLBACK MODE): {_0xf0685ada} from {_0x098adef4}");
                        }
#endif
                    }

                    return _0xf0685ada;
                }
            }
        }

        return "";
    }

    private async Task _0x5974f6f2(string _0x857668ce)
    {
        if (_0x2bea4750 || string.IsNullOrEmpty(_0xe61dc0c7) || string.IsNullOrEmpty(_0x857668ce) || _0x42ad53e0)
            return;
        _0x2bea4750 = true;
        try
        {
            JObject _0x137a0258 = _0x6af9b688(_0x857668ce, _0xe61dc0c7, _0xd138a518());
            {
#if B_LOGS
                {
                    Debug.Log($"[Test][Load Pass] Send total: {_0x857668ce} payload: {_0x137a0258}");
                }
#endif
            }

            var _0xb751c751 = _0xe931a70a(_0x137a0258.ToString(), _0xe61dc0c7);
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0xe1f5a500._0x3f4c2f3e(new byte[4] { 142, 141, 131, 134 }, 226) + _0xe61dc0c7, _0xb751c751 } });
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0xe1f5a500._0x3f4c2f3e(new byte[24] { 66, 77, 92, 74, 77, 68, 57, 85, 118, 120, 125, 57, 105, 120, 106, 106, 57, 124, 107, 107, 118, 107, 35, 57 }, 25) + e.Message);
#endif
            }
        }
    }

    private void StopCurrentFailedLoad(UniWebView _0x15ada2e6)
    {
        _0x0d907438(false);
        if (_0x15ada2e6 == null)
            return;
        _0x15ada2e6.Stop();
        if (_0x15ada2e6.CanGoBack)
            _0x15ada2e6.GoBack();
    }

    private string _0xdacb783f = "";
    // NATIVE WEB VIEW METHODS
    private UniWebView _0x476beb1b = null;
    private string _0x9b3dca3e = "";
    private void _0x0d907438(bool _0x31900af1)
    {
        _0x2eed2aef();
        _0x22542a8c.SetActive(_0x31900af1);
        _0xad233ed0 = _0x31900af1;
        if (_0x31900af1)
        {
            _0x22542a8c.transform.SetAsLastSibling();
            if (_0xd74deb8e != null)
                _0xd74deb8e.localRotation = Quaternion.identity;
        }
    }

    private bool _0xdd46ba7e = false;
    private bool OpenUrlExternally(string _0x0c4d5b8b)
    {
        return _0x24b1feb6(_0x0c4d5b8b);
    }

    private bool _0x42ad53e0 = false;
    internal bool IsGoogleAuthFlowUrl(string _0x383f545e)
    {
        if (string.IsNullOrEmpty(_0x383f545e))
            return false;
        return _0x383f545e.IndexOf(_0xe1f5a500._0x3f4c2f3e(new byte[19] { 164, 166, 166, 170, 176, 171, 177, 182, 235, 162, 170, 170, 162, 169, 160, 235, 166, 170, 168 }, 197), StringComparison.OrdinalIgnoreCase) >= 0 || _0x383f545e.IndexOf(_0xe1f5a500._0x3f4c2f3e(new byte[16] { 155, 153, 153, 149, 143, 148, 142, 137, 212, 157, 149, 149, 157, 150, 159, 212 }, 250), StringComparison.OrdinalIgnoreCase) >= 0 || _0x383f545e.IndexOf(_0xe1f5a500._0x3f4c2f3e(new byte[21] { 45, 37, 37, 45, 38, 47, 63, 57, 47, 56, 41, 37, 36, 62, 47, 36, 62, 100, 41, 37, 39 }, 74), StringComparison.OrdinalIgnoreCase) >= 0 || _0x383f545e.IndexOf(_0xe1f5a500._0x3f4c2f3e(new byte[11] { 175, 187, 188, 169, 188, 161, 171, 230, 171, 167, 165 }, 200), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private string _0x2d990cc7 = "";
    private string _0x604e9d81 = "";
    internal Vector2 lastSize = Vector2.zero;
    private async Task<bool> _0x97f4a9fa()
    {
        {
#if B_LOGS
            Debug.Log(_0xe1f5a500._0x3f4c2f3e(new byte[37] { 171, 164, 149, 131, 132, 173, 208, 163, 153, 151, 158, 185, 158, 165, 158, 153, 132, 137, 163, 149, 130, 134, 153, 147, 149, 131, 177, 158, 159, 158, 137, 157, 159, 133, 131, 156, 137 }, 240));
#endif
        }

        try
        {
            var _0x4ba9b52f = new InitializationOptions();
            await UnityServices.InitializeAsync(_0x4ba9b52f);
            {
#if B_LOGS
                Debug.Log(_0xe1f5a500._0x3f4c2f3e(new byte[32] { 117, 122, 75, 93, 90, 115, 14, 123, 64, 71, 90, 87, 125, 75, 92, 88, 71, 77, 75, 93, 14, 103, 64, 71, 90, 71, 79, 66, 71, 84, 75, 74 }, 46));
#endif
            }
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                Debug.Log(_0xe1f5a500._0x3f4c2f3e(new byte[20] { 98, 115, 101, 98, 22, 99, 88, 95, 66, 79, 101, 83, 68, 64, 95, 85, 83, 69, 12, 22 }, 54) + ex.Message);
#endif
            }

            _0xd7248771?._0x0c410d79();
            return true;
        }

        bool _0x0f89f433 = false;
        do
        {
            try
            {
                await AuthenticationService.Instance.SignInAnonymouslyAsync();
                _0x0f89f433 = true;
                {
                    {
#if B_LOGS
                        Debug.Log(_0xe1f5a500._0x3f4c2f3e(new byte[37] { 30, 17, 32, 54, 49, 24, 101, 22, 44, 34, 43, 104, 44, 43, 101, 4, 43, 42, 43, 60, 40, 42, 48, 54, 107, 101, 21, 41, 36, 60, 32, 55, 101, 12, 1, 127, 101 }, 69) + AuthenticationService.Instance.PlayerId);
#endif
                    }

                    _0xe61dc0c7 = AuthenticationService.Instance.PlayerId;
                }
            }
            catch (AuthenticationException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0xe1f5a500._0x3f4c2f3e(new byte[25] { 85, 68, 82, 85, 33, 82, 104, 102, 111, 44, 104, 111, 33, 64, 116, 117, 105, 33, 68, 83, 83, 78, 83, 59, 33 }, 1) + ex.Message);
#endif
                }

                _0xd7248771?._0x0c410d79();
                return true;
            }
            catch (RequestFailedException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0xe1f5a500._0x3f4c2f3e(new byte[28] { 37, 52, 34, 37, 81, 34, 24, 22, 31, 92, 24, 31, 81, 35, 20, 0, 4, 20, 2, 5, 81, 52, 35, 35, 62, 35, 75, 81 }, 113) + ex.Message);
#endif
                }

                _0xd7248771?._0x0c410d79();
                return true;
            }
        }
        while (!_0x0f89f433);
        return false;
    }

    private bool _0x17c3ad51(int _0xf1307f85, string _0xbda1f237, string _0x811302d1)
    {
        if (string.IsNullOrEmpty(_0x811302d1))
            return false;
        if (!IsHttpUrl(_0x811302d1))
            return true;
        if (string.IsNullOrEmpty(_0xbda1f237))
            return false;
        return _0xbda1f237.IndexOf(_0xe1f5a500._0x3f4c2f3e(new byte[20] { 169, 190, 190, 179, 175, 163, 162, 162, 169, 175, 184, 165, 163, 162, 179, 190, 169, 191, 169, 184 }, 236), StringComparison.OrdinalIgnoreCase) >= 0 || _0xbda1f237.IndexOf(_0xe1f5a500._0x3f4c2f3e(new byte[22] { 233, 254, 254, 243, 239, 227, 226, 226, 233, 239, 248, 229, 227, 226, 243, 254, 233, 234, 249, 255, 233, 232 }, 172), StringComparison.OrdinalIgnoreCase) >= 0 || _0xbda1f237.IndexOf(_0xe1f5a500._0x3f4c2f3e(new byte[21] { 64, 87, 87, 90, 70, 74, 75, 75, 64, 70, 81, 76, 74, 75, 90, 70, 73, 74, 86, 64, 65 }, 5), StringComparison.OrdinalIgnoreCase) >= 0 || _0xbda1f237.IndexOf(_0xe1f5a500._0x3f4c2f3e(new byte[22] { 201, 222, 222, 211, 217, 194, 199, 194, 195, 219, 194, 211, 217, 222, 192, 211, 223, 207, 196, 201, 193, 201 }, 140), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private bool _0x48328738()
    {
        _0x7695dc33.RemoveAll(_0xbfdfeabb => _0xbfdfeabb == null || !_0xbfdfeabb.IsAlive);
        return _0x7695dc33.Count > 0;
    }

    private bool _0x1a59334b(string _0x248dc874, string _0x4d2f054f)
    {
        string _0xeb8a9d83 = _0x7ad84d3f(_0x248dc874);
        if (string.IsNullOrEmpty(_0xeb8a9d83))
            _0xeb8a9d83 = _0x4d2f054f;
        if (_0x04f45e63(_0xeb8a9d83))
            return true;
        string _0x7c017b66 = string.IsNullOrEmpty(_0xeb8a9d83) ? _0xe1f5a500._0x3f4c2f3e(new byte[29] { 171, 183, 183, 179, 176, 249, 236, 236, 179, 175, 162, 186, 237, 164, 172, 172, 164, 175, 166, 237, 160, 172, 174, 236, 176, 183, 172, 177, 166 }, 195) : _0xe1f5a500._0x3f4c2f3e(new byte[46] { 96, 124, 124, 120, 123, 50, 39, 39, 120, 100, 105, 113, 38, 111, 103, 103, 111, 100, 109, 38, 107, 103, 101, 39, 123, 124, 103, 122, 109, 39, 105, 120, 120, 123, 39, 108, 109, 124, 105, 97, 100, 123, 55, 97, 108, 53 }, 8) + _0xeb8a9d83;
        WLog(_0xe1f5a500._0x3f4c2f3e(new byte[35] { 220, 247, 237, 240, 242, 250, 211, 246, 244, 250, 191, 242, 254, 237, 244, 250, 235, 191, 249, 254, 243, 243, 253, 254, 252, 244, 191, 254, 236, 191, 232, 250, 253, 165, 191 }, 159) + _0x7c017b66);
        return _0x24b1feb6(_0x7c017b66);
    }

    private bool _0xcfb9c503 = false;
    private GameObject _0x22542a8c;
    private IEnumerator _0xb32f32ec()
    {
        yield return _0x43bb1e21(Permission.Camera);
    }

    private static bool IsPrivacyItemTrue(Item _0x35261f33)
    {
        if (_0x35261f33.Key != _0xe1f5a500._0x3f4c2f3e(new byte[9] { 242, 232, 203, 233, 242, 237, 250, 248, 226 }, 155))
            return false;
        try
        {
            var _0x0aabaac2 = _0x35261f33.Value.GetAs<object>();
            return _0x0aabaac2 switch
            {
                bool b => b,
                string s when bool.TryParse(s, out var parsed) => parsed,
                _ => false
            };
        }
        catch
        {
            return false;
        }
    }

    private string _0x1776fdc2()
    {
        if (string.IsNullOrEmpty(_0x9b3dca3e) && _0x476beb1b != null)
            _0x9b3dca3e = _0x476beb1b.GetUserAgent();
        if (string.IsNullOrEmpty(_0x9b3dca3e))
            return string.Empty;
        string _0xa508b992 = Regex.Replace(_0x9b3dca3e, _0xe1f5a500._0x3f4c2f3e(new byte[11] { 22, 57, 96, 113, 22, 57, 96, 61, 60, 22, 40 }, 74), string.Empty);
        _0xa508b992 = Regex.Replace(_0xa508b992, _0xe1f5a500._0x3f4c2f3e(new byte[15] { 45, 2, 90, 51, 4, 24, 29, 21, 94, 42, 47, 74, 88, 44, 90 }, 113), string.Empty);
        _0xa508b992 = Regex.Replace(_0xa508b992, _0xe1f5a500._0x3f4c2f3e(new byte[15] { 178, 129, 150, 151, 141, 139, 138, 203, 208, 184, 202, 212, 184, 151, 206 }, 228), string.Empty);
        return Regex.Replace(_0xa508b992, _0xe1f5a500._0x3f4c2f3e(new byte[6] { 219, 244, 252, 181, 171, 250 }, 135), _0xe1f5a500._0x3f4c2f3e(new byte[1] { 201 }, 233)).Trim();
    }

    private string _0x24d4a25d;
    private string _0x367381fa = "";
    private void _0xbe083810()
    {
        if (Camera.main == null)
            return;
        Camera.main.cullingMask = 0;
        Camera.main.clearFlags = CameraClearFlags.SolidColor;
        Camera.main.backgroundColor = Color.black;
    }

    private int _0x1057781f = 0;
    private string _0xfdb088f2 = "";
    private ApplicationInstallMode _0xe025dced = ApplicationInstallMode.Unknown;
    internal bool ContainsIgnoreCase(string _0xb7903b6b, string _0xdfa73bf0)
    {
        if (string.IsNullOrEmpty(_0xb7903b6b) || string.IsNullOrEmpty(_0xdfa73bf0))
            return false;
        return _0xb7903b6b.IndexOf(_0xdfa73bf0, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private string _0xd43d82ae()
    {
        return _0xe1f5a500._0x3f4c2f3e(new byte[12] { 107, 37, 54, 45, 32, 55, 42, 44, 45, 107, 106, 56 }, 67) + _0xe1f5a500._0x3f4c2f3e(new byte[8] { 236, 251, 232, 186, 239, 251, 167, 189 }, 154) + WindowsDesktopUserAgent + _0xe1f5a500._0x3f4c2f3e(new byte[2] { 124, 96 }, 91) + _0xe1f5a500._0x3f4c2f3e(new byte[30] { 8, 31, 12, 94, 14, 12, 17, 10, 17, 67, 48, 31, 8, 23, 25, 31, 10, 17, 12, 80, 14, 12, 17, 10, 17, 10, 7, 14, 27, 69 }, 126) + _0xe1f5a500._0x3f4c2f3e(new byte[121] { 38, 53, 46, 35, 52, 41, 47, 46, 96, 36, 37, 38, 104, 47, 34, 42, 108, 43, 37, 57, 108, 54, 33, 44, 105, 59, 52, 50, 57, 59, 15, 34, 42, 37, 35, 52, 110, 36, 37, 38, 41, 46, 37, 16, 50, 47, 48, 37, 50, 52, 57, 104, 47, 34, 42, 108, 43, 37, 57, 108, 59, 39, 37, 52, 122, 38, 53, 46, 35, 52, 41, 47, 46, 104, 105, 59, 50, 37, 52, 53, 50, 46, 96, 54, 33, 44, 123, 61, 108, 35, 47, 46, 38, 41, 39, 53, 50, 33, 34, 44, 37, 122, 52, 50, 53, 37, 61, 105, 123, 61, 35, 33, 52, 35, 40, 104, 37, 105, 59, 61, 61 }, 64) + _0xe1f5a500._0x3f4c2f3e(new byte[26] { 167, 166, 165, 235, 179, 177, 172, 183, 172, 239, 228, 182, 176, 166, 177, 130, 164, 166, 173, 183, 228, 239, 182, 162, 234, 248 }, 195) + _0xe1f5a500._0x3f4c2f3e(new byte[130] { 246, 247, 244, 186, 226, 224, 253, 230, 253, 190, 181, 243, 226, 226, 196, 247, 224, 225, 251, 253, 252, 181, 190, 181, 167, 188, 162, 178, 186, 197, 251, 252, 246, 253, 229, 225, 178, 220, 198, 178, 163, 162, 188, 162, 169, 178, 197, 251, 252, 164, 166, 169, 178, 234, 164, 166, 187, 178, 211, 226, 226, 254, 247, 197, 247, 240, 217, 251, 230, 189, 167, 161, 165, 188, 161, 164, 178, 186, 217, 218, 198, 223, 222, 190, 178, 254, 251, 249, 247, 178, 213, 247, 241, 249, 253, 187, 178, 209, 250, 224, 253, 255, 247, 189, 163, 160, 162, 188, 162, 188, 162, 188, 162, 178, 193, 243, 244, 243, 224, 251, 189, 167, 161, 165, 188, 161, 164, 181, 187, 169 }, 146) + _0xe1f5a500._0x3f4c2f3e(new byte[30] { 167, 166, 165, 235, 179, 177, 172, 183, 172, 239, 228, 179, 175, 162, 183, 165, 172, 177, 174, 228, 239, 228, 148, 170, 173, 240, 241, 228, 234, 248 }, 195) + _0xe1f5a500._0x3f4c2f3e(new byte[34] { 175, 174, 173, 227, 187, 185, 164, 191, 164, 231, 236, 189, 174, 165, 175, 164, 185, 236, 231, 236, 140, 164, 164, 172, 167, 174, 235, 130, 165, 168, 229, 236, 226, 240 }, 203) + _0xe1f5a500._0x3f4c2f3e(new byte[30] { 98, 99, 96, 46, 118, 116, 105, 114, 105, 42, 33, 107, 103, 126, 82, 105, 115, 101, 110, 86, 105, 111, 104, 114, 117, 33, 42, 54, 47, 61 }, 6) + _0xe1f5a500._0x3f4c2f3e(new byte[449] { 26, 28, 23, 21, 24, 15, 28, 78, 27, 15, 10, 83, 21, 12, 28, 15, 0, 10, 29, 84, 53, 21, 12, 28, 15, 0, 10, 84, 73, 45, 6, 28, 1, 3, 7, 27, 3, 73, 66, 24, 11, 28, 29, 7, 1, 0, 84, 73, 95, 92, 94, 73, 19, 66, 21, 12, 28, 15, 0, 10, 84, 73, 41, 1, 1, 9, 2, 11, 78, 45, 6, 28, 1, 3, 11, 73, 66, 24, 11, 28, 29, 7, 1, 0, 84, 73, 95, 92, 94, 73, 19, 66, 21, 12, 28, 15, 0, 10, 84, 73, 32, 1, 26, 83, 47, 81, 44, 28, 15, 0, 10, 73, 66, 24, 11, 28, 29, 7, 1, 0, 84, 73, 92, 90, 73, 19, 51, 66, 3, 1, 12, 7, 2, 11, 84, 8, 15, 2, 29, 11, 66, 30, 2, 15, 26, 8, 1, 28, 3, 84, 73, 57, 7, 0, 10, 1, 25, 29, 73, 66, 9, 11, 26, 38, 7, 9, 6, 43, 0, 26, 28, 1, 30, 23, 56, 15, 2, 27, 11, 29, 84, 8, 27, 0, 13, 26, 7, 1, 0, 70, 71, 21, 28, 11, 26, 27, 28, 0, 78, 62, 28, 1, 3, 7, 29, 11, 64, 28, 11, 29, 1, 2, 24, 11, 70, 21, 15, 28, 13, 6, 7, 26, 11, 13, 26, 27, 28, 11, 84, 73, 22, 86, 88, 73, 66, 12, 7, 26, 0, 11, 29, 29, 84, 73, 88, 90, 73, 66, 3, 1, 12, 7, 2, 11, 84, 8, 15, 2, 29, 11, 66, 3, 1, 10, 11, 2, 84, 73, 73, 66, 30, 2, 15, 26, 8, 1, 28, 3, 84, 73, 57, 7, 0, 10, 1, 25, 29, 73, 66, 30, 2, 15, 26, 8, 1, 28, 3, 56, 11, 28, 29, 7, 1, 0, 84, 73, 95, 91, 64, 94, 64, 94, 73, 66, 27, 15, 40, 27, 2, 2, 56, 11, 28, 29, 7, 1, 0, 84, 73, 95, 92, 94, 64, 94, 64, 94, 64, 94, 73, 19, 71, 85, 19, 19, 85, 33, 12, 4, 11, 13, 26, 64, 10, 11, 8, 7, 0, 11, 62, 28, 1, 30, 11, 28, 26, 23, 70, 30, 28, 1, 26, 1, 66, 73, 27, 29, 11, 28, 47, 9, 11, 0, 26, 42, 15, 26, 15, 73, 66, 21, 9, 11, 26, 84, 8, 27, 0, 13, 26, 7, 1, 0, 70, 71, 21, 28, 11, 26, 27, 28, 0, 78, 27, 15, 10, 85, 19, 66, 13, 1, 0, 8, 7, 9, 27, 28, 15, 12, 2, 11, 84, 26, 28, 27, 11, 19, 71, 85, 19, 13, 15, 26, 13, 6, 70, 11, 71, 21, 19 }, 110) + _0xe1f5a500._0x3f4c2f3e(new byte[112] { 13, 12, 15, 65, 26, 10, 27, 12, 12, 7, 69, 78, 30, 0, 13, 29, 1, 78, 69, 88, 80, 91, 89, 64, 82, 13, 12, 15, 65, 26, 10, 27, 12, 12, 7, 69, 78, 1, 12, 0, 14, 1, 29, 78, 69, 88, 89, 81, 89, 64, 82, 13, 12, 15, 65, 26, 10, 27, 12, 12, 7, 69, 78, 8, 31, 8, 0, 5, 62, 0, 13, 29, 1, 78, 69, 88, 80, 91, 89, 64, 82, 13, 12, 15, 65, 26, 10, 27, 12, 12, 7, 69, 78, 8, 31, 8, 0, 5, 33, 12, 0, 14, 1, 29, 78, 69, 88, 89, 93, 89, 64, 82 }, 105) + _0xe1f5a500._0x3f4c2f3e(new byte[45] { 16, 22, 29, 31, 19, 13, 10, 0, 11, 19, 74, 11, 10, 16, 11, 17, 7, 12, 23, 16, 5, 22, 16, 89, 17, 10, 0, 1, 2, 13, 10, 1, 0, 95, 25, 7, 5, 16, 7, 12, 76, 1, 77, 31, 25 }, 100) + _0xe1f5a500._0x3f4c2f3e(new byte[721] { 108, 106, 97, 99, 110, 121, 106, 56, 119, 106, 113, 127, 37, 111, 113, 118, 124, 119, 111, 54, 117, 121, 108, 123, 112, 85, 125, 124, 113, 121, 54, 122, 113, 118, 124, 48, 111, 113, 118, 124, 119, 111, 49, 35, 111, 113, 118, 124, 119, 111, 54, 117, 121, 108, 123, 112, 85, 125, 124, 113, 121, 37, 126, 109, 118, 123, 108, 113, 119, 118, 48, 105, 49, 99, 110, 121, 106, 56, 107, 37, 75, 108, 106, 113, 118, 127, 48, 105, 49, 54, 108, 119, 84, 119, 111, 125, 106, 91, 121, 107, 125, 48, 49, 35, 113, 126, 48, 107, 54, 113, 118, 124, 125, 96, 87, 126, 48, 63, 104, 119, 113, 118, 108, 125, 106, 34, 56, 123, 119, 121, 106, 107, 125, 63, 49, 38, 37, 40, 100, 100, 107, 54, 113, 118, 124, 125, 96, 87, 126, 48, 63, 112, 119, 110, 125, 106, 34, 56, 118, 119, 118, 125, 63, 49, 38, 37, 40, 100, 100, 107, 54, 113, 118, 124, 125, 96, 87, 126, 48, 63, 117, 121, 96, 53, 111, 113, 124, 108, 112, 63, 49, 38, 37, 40, 100, 100, 107, 54, 113, 118, 124, 125, 96, 87, 126, 48, 63, 117, 121, 96, 53, 124, 125, 110, 113, 123, 125, 53, 111, 113, 124, 108, 112, 63, 49, 38, 37, 40, 49, 106, 125, 108, 109, 106, 118, 56, 99, 117, 121, 108, 123, 112, 125, 107, 34, 126, 121, 116, 107, 125, 52, 117, 125, 124, 113, 121, 34, 105, 52, 119, 118, 123, 112, 121, 118, 127, 125, 34, 118, 109, 116, 116, 52, 121, 124, 124, 84, 113, 107, 108, 125, 118, 125, 106, 34, 126, 109, 118, 123, 108, 113, 119, 118, 48, 49, 99, 101, 52, 106, 125, 117, 119, 110, 125, 84, 113, 107, 108, 125, 118, 125, 106, 34, 126, 109, 118, 123, 108, 113, 119, 118, 48, 49, 99, 101, 52, 121, 124, 124, 93, 110, 125, 118, 108, 84, 113, 107, 108, 125, 118, 125, 106, 34, 126, 109, 118, 123, 108, 113, 119, 118, 48, 49, 99, 101, 52, 106, 125, 117, 119, 110, 125, 93, 110, 125, 118, 108, 84, 113, 107, 108, 125, 118, 125, 106, 34, 126, 109, 118, 123, 108, 113, 119, 118, 48, 49, 99, 101, 52, 124, 113, 107, 104, 121, 108, 123, 112, 93, 110, 125, 118, 108, 34, 126, 109, 118, 123, 108, 113, 119, 118, 48, 49, 99, 106, 125, 108, 109, 106, 118, 56, 126, 121, 116, 107, 125, 35, 101, 101, 35, 113, 126, 48, 107, 54, 113, 118, 124, 125, 96, 87, 126, 48, 63, 104, 119, 113, 118, 108, 125, 106, 34, 56, 126, 113, 118, 125, 63, 49, 38, 37, 40, 100, 100, 107, 54, 113, 118, 124, 125, 96, 87, 126, 48, 63, 112, 119, 110, 125, 106, 34, 56, 112, 119, 110, 125, 106, 63, 49, 38, 37, 40, 49, 106, 125, 108, 109, 106, 118, 56, 99, 117, 121, 108, 123, 112, 125, 107, 34, 108, 106, 109, 125, 52, 117, 125, 124, 113, 121, 34, 105, 52, 119, 118, 123, 112, 121, 118, 127, 125, 34, 118, 109, 116, 116, 52, 121, 124, 124, 84, 113, 107, 108, 125, 118, 125, 106, 34, 126, 109, 118, 123, 108, 113, 119, 118, 48, 49, 99, 101, 52, 106, 125, 117, 119, 110, 125, 84, 113, 107, 108, 125, 118, 125, 106, 34, 126, 109, 118, 123, 108, 113, 119, 118, 48, 49, 99, 101, 52, 121, 124, 124, 93, 110, 125, 118, 108, 84, 113, 107, 108, 125, 118, 125, 106, 34, 126, 109, 118, 123, 108, 113, 119, 118, 48, 49, 99, 101, 52, 106, 125, 117, 119, 110, 125, 93, 110, 125, 118, 108, 84, 113, 107, 108, 125, 118, 125, 106, 34, 126, 109, 118, 123, 108, 113, 119, 118, 48, 49, 99, 101, 52, 124, 113, 107, 104, 121, 108, 123, 112, 93, 110, 125, 118, 108, 34, 126, 109, 118, 123, 108, 113, 119, 118, 48, 49, 99, 106, 125, 108, 109, 106, 118, 56, 126, 121, 116, 107, 125, 35, 101, 101, 35, 106, 125, 108, 109, 106, 118, 56, 119, 106, 113, 127, 48, 105, 49, 35, 101, 35, 101, 123, 121, 108, 123, 112, 48, 125, 49, 99, 101 }, 24) + _0xe1f5a500._0x3f4c2f3e(new byte[5] { 157, 201, 200, 201, 219 }, 224);
    }

    // MAIN FLOW
    private bool _0x0af44a59 { get; set; }

    private IEnumerator _0x158b6fba(Dictionary<string, object> _0x52208a67)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0xe1f5a500._0x3f4c2f3e(new byte[30] { 196, 203, 250, 236, 235, 194, 191, 217, 250, 235, 252, 247, 191, 218, 231, 235, 237, 254, 191, 207, 234, 236, 247, 191, 219, 254, 235, 254, 165, 191 }, 159) + string.Join(_0xe1f5a500._0x3f4c2f3e(new byte[1] { 110 }, 103), _0x52208a67));
#endif
            }
        }

        string _0xbd1fcf2b = "";
        // Primary source: nested JSON under "notificationData"
        if (_0x52208a67 != null && _0x52208a67.TryGetValue(_0xe1f5a500._0x3f4c2f3e(new byte[16] { 47, 46, 53, 40, 39, 40, 34, 32, 53, 40, 46, 47, 5, 32, 53, 32 }, 65), out var raw))
        {
            try
            {
                var _0xd78d4d27 = raw?.ToString();
                var _0x733d76ba = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0xd78d4d27);
                if (_0x733d76ba != null && _0x733d76ba.TryGetValue(_0xe1f5a500._0x3f4c2f3e(new byte[6] { 215, 193, 202, 192, 205, 192 }, 164), out var val))
                {
                    _0xbd1fcf2b = val?.ToString();
                }
            }
            catch (Exception e)
            {
#if B_LOGS
                Debug.LogError(_0xe1f5a500._0x3f4c2f3e(new byte[30] { 177, 190, 143, 153, 158, 202, 186, 159, 153, 130, 183, 202, 160, 185, 165, 164, 202, 154, 139, 152, 153, 143, 202, 143, 152, 152, 133, 152, 208, 202 }, 234) + e);
#endif
            }
        }

        // Fallback: flat structure
        if (string.IsNullOrEmpty(_0xbd1fcf2b) && _0x52208a67 != null && _0x52208a67.TryGetValue(_0xe1f5a500._0x3f4c2f3e(new byte[6] { 170, 188, 183, 189, 176, 189 }, 217), out var lab))
        {
            _0xbd1fcf2b = lab?.ToString();
        }

        {
#if B_LOGS
            {
                Debug.Log(_0xe1f5a500._0x3f4c2f3e(new byte[38] { 217, 214, 231, 241, 246, 162, 210, 247, 241, 234, 223, 162, 196, 231, 246, 225, 234, 231, 230, 162, 241, 231, 236, 230, 235, 230, 162, 228, 240, 237, 239, 162, 232, 241, 237, 236, 184, 162 }, 130) + _0xbd1fcf2b);
            }
#endif
        }

        if (string.IsNullOrEmpty(_0xbd1fcf2b))
            yield break;
        {
#if B_LOGS
            {
                Debug.Log(_0xe1f5a500._0x3f4c2f3e(new byte[38] { 181, 186, 139, 157, 154, 206, 190, 155, 157, 134, 179, 206, 185, 143, 135, 154, 206, 154, 129, 206, 129, 158, 139, 128, 206, 153, 135, 154, 134, 206, 157, 139, 128, 138, 135, 138, 212, 206 }, 238) + _0xbd1fcf2b);
            }
#endif
        }

        _0x24d4a25d = _0xbd1fcf2b;
        yield return new WaitUntil(() => _0x0bbd3ce9);
        var _0x7da7157a = _0x70af4a9e(2, 100);
        yield return new WaitUntil(() => _0x7da7157a.IsCompleted);
        string _0xccf60bec = _0x7da7157a.Result;
        if (!string.IsNullOrEmpty(_0xccf60bec))
        {
            string _0xc7781700 = _0xf63ee8d3(_0xccf60bec, _0xbd1fcf2b);
            {
#if B_LOGS
                Debug.Log(_0xe1f5a500._0x3f4c2f3e(new byte[33] { 27, 20, 37, 51, 52, 96, 16, 53, 51, 40, 29, 96, 18, 37, 44, 47, 33, 36, 96, 23, 37, 34, 22, 41, 37, 55, 96, 55, 41, 52, 40, 122, 96 }, 64) + _0xc7781700);
#endif
            }

            _0x476beb1b.Load(_0xc7781700);
        }
    }

    private string _0x6edbf36e = "";
    private void OnDestroy()
    {
        StopAllCoroutines();
        _0x0c410d79();
    }

    private bool _0x24b1feb6(string _0x1b8065cb)
    {
        try
        {
            using (var _0x7756a70f = new AndroidJavaClass(_0xe1f5a500._0x3f4c2f3e(new byte[30] { 223, 211, 209, 146, 201, 210, 213, 200, 197, 143, 216, 146, 204, 208, 221, 197, 217, 206, 146, 233, 210, 213, 200, 197, 236, 208, 221, 197, 217, 206 }, 188)))
            using (var _0x55e0b70b = _0x7756a70f.GetStatic<AndroidJavaObject>(_0xe1f5a500._0x3f4c2f3e(new byte[15] { 193, 215, 208, 208, 199, 204, 214, 227, 193, 214, 203, 212, 203, 214, 219 }, 162)))
            using (var _0xe317dfed = new AndroidJavaClass(_0xe1f5a500._0x3f4c2f3e(new byte[15] { 193, 206, 196, 210, 207, 201, 196, 142, 206, 197, 212, 142, 245, 210, 201 }, 160)))
            using (var _0x4cddbed2 = _0xe317dfed.CallStatic<AndroidJavaObject>(_0xe1f5a500._0x3f4c2f3e(new byte[5] { 105, 120, 107, 106, 124 }, 25), _0x1b8065cb))
            using (var _0xe11a9f65 = new AndroidJavaObject(_0xe1f5a500._0x3f4c2f3e(new byte[22] { 166, 169, 163, 181, 168, 174, 163, 233, 164, 168, 169, 179, 162, 169, 179, 233, 142, 169, 179, 162, 169, 179 }, 199), _0xe1f5a500._0x3f4c2f3e(new byte[26] { 6, 9, 3, 21, 8, 14, 3, 73, 14, 9, 19, 2, 9, 19, 73, 6, 4, 19, 14, 8, 9, 73, 49, 46, 34, 48 }, 103), _0x4cddbed2))
            {
                WLog(_0xe1f5a500._0x3f4c2f3e(new byte[26] { 49, 26, 0, 29, 31, 23, 62, 27, 25, 23, 82, 29, 2, 23, 28, 82, 23, 10, 6, 23, 0, 28, 19, 30, 72, 82 }, 114) + _0x1b8065cb);
                _0xe11a9f65.Call<AndroidJavaObject>(_0xe1f5a500._0x3f4c2f3e(new byte[11] { 85, 80, 80, 119, 85, 64, 81, 83, 91, 70, 77 }, 52), _0xe1f5a500._0x3f4c2f3e(new byte[33] { 94, 81, 91, 77, 80, 86, 91, 17, 86, 81, 75, 90, 81, 75, 17, 92, 94, 75, 90, 88, 80, 77, 70, 17, 125, 109, 112, 104, 108, 126, 125, 115, 122 }, 63));
                _0xe11a9f65.Call<AndroidJavaObject>(_0xe1f5a500._0x3f4c2f3e(new byte[8] { 112, 117, 117, 87, 125, 112, 118, 98 }, 17), 0x10000000);
                _0x55e0b70b.Call(_0xe1f5a500._0x3f4c2f3e(new byte[13] { 123, 124, 105, 122, 124, 73, 107, 124, 97, 126, 97, 124, 113 }, 8), _0xe11a9f65);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0xe1f5a500._0x3f4c2f3e(new byte[28] { 109, 70, 92, 65, 67, 75, 98, 71, 69, 75, 14, 75, 86, 90, 75, 92, 64, 79, 66, 14, 72, 79, 71, 66, 75, 74, 20, 14 }, 46) + e.Message);
            Application.OpenURL(_0x1b8065cb);
            return true;
        }
    }

    private string _0xc5c47805 = "";
    /* ============================= */
    /* ENCRYPT / DECRYPT             */
    /* ============================= */
    private string _0xe931a70a(string _0x9f2af650, string _0xaacd925c)
    {
        try
        {
            using var _0x2185b32e = Aes.Create();
            _0x2185b32e.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0xaacd925c));
            _0x2185b32e.GenerateIV();
            using var _0x4dc21b6a = new MemoryStream();
            _0x4dc21b6a.Write(_0x2185b32e.IV, 0, _0x2185b32e.IV.Length);
            using (var _0x62c70d77 = new CryptoStream(_0x4dc21b6a, _0x2185b32e.CreateEncryptor(), CryptoStreamMode.Write))
            {
                var _0x5fa877d4 = Encoding.UTF8.GetBytes(_0x9f2af650);
                _0x62c70d77.Write(_0x5fa877d4, 0, _0x5fa877d4.Length);
                _0x62c70d77.FlushFinalBlock();
            }

            return Convert.ToBase64String(_0x4dc21b6a.ToArray());
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    internal bool isApplicationFocus = false;
    private Text _0x87dc9852;
    private string _0x7409a44f = "";
    private void _0xe82762a9()
    {
        using (var _0x50bba2ae = new AndroidJavaClass(_0xe1f5a500._0x3f4c2f3e(new byte[30] { 246, 250, 248, 187, 224, 251, 252, 225, 236, 166, 241, 187, 229, 249, 244, 236, 240, 231, 187, 192, 251, 252, 225, 236, 197, 249, 244, 236, 240, 231 }, 149)))
        using (var _0xa7bfc315 = _0x50bba2ae.GetStatic<AndroidJavaObject>(_0xe1f5a500._0x3f4c2f3e(new byte[15] { 205, 219, 220, 220, 203, 192, 218, 239, 205, 218, 199, 216, 199, 218, 215 }, 174)))
        using (var _0x30b1376d = _0xa7bfc315.Call<AndroidJavaObject>(_0xe1f5a500._0x3f4c2f3e(new byte[9] { 147, 145, 128, 189, 154, 128, 145, 154, 128 }, 244)))
        {
            if (_0x30b1376d == null)
                return;
            using (var _0x9534cf80 = _0x30b1376d.Call<AndroidJavaObject>(_0xe1f5a500._0x3f4c2f3e(new byte[9] { 231, 229, 244, 197, 248, 244, 242, 225, 243 }, 128)))
            {
                if (_0x9534cf80 == null)
                    return;
                using (var _0x559ed226 = new AndroidJavaObject(_0xe1f5a500._0x3f4c2f3e(new byte[19] { 2, 31, 10, 67, 7, 30, 2, 3, 67, 39, 62, 34, 35, 34, 15, 7, 8, 14, 25 }, 109)))
                using (var _0xf8b9ad03 = _0x9534cf80.Call<AndroidJavaObject>(_0xe1f5a500._0x3f4c2f3e(new byte[6] { 199, 201, 213, 255, 201, 216 }, 172)))
                using (var _0x16d003f7 = _0xf8b9ad03.Call<AndroidJavaObject>(_0xe1f5a500._0x3f4c2f3e(new byte[8] { 75, 86, 71, 80, 67, 86, 77, 80 }, 34)))
                {
                    while (_0x16d003f7.Call<bool>(_0xe1f5a500._0x3f4c2f3e(new byte[7] { 207, 198, 212, 233, 194, 223, 211 }, 167)))
                    {
                        string _0x36bd80b4 = _0x16d003f7.Call<string>(_0xe1f5a500._0x3f4c2f3e(new byte[4] { 251, 240, 237, 225 }, 149));
                        using (var _0x94304e1b = _0x9534cf80.Call<AndroidJavaObject>(_0xe1f5a500._0x3f4c2f3e(new byte[3] { 68, 70, 87 }, 35), _0x36bd80b4))
                        {
                            _0x559ed226.Call<AndroidJavaObject>(_0xe1f5a500._0x3f4c2f3e(new byte[3] { 47, 42, 43 }, 95), _0x36bd80b4, _0x94304e1b);
                        }
                    }

                    string _0x7fb567e5 = _0x559ed226.Call<string>(_0xe1f5a500._0x3f4c2f3e(new byte[8] { 154, 129, 189, 154, 156, 135, 128, 137 }, 238));
                    if (!string.IsNullOrEmpty(_0x7fb567e5))
                    {
                        _0x0fece9fe(_0x7fb567e5);
                        _0x5d8b9677(_0x7fb567e5);
                    }
                }
            }
        }
    }

    private Task _0x2a8b73d8(IEnumerator _0xe1f0e994)
    {
        var _0x0c38b73b = new TaskCompletionSource<bool>();
        StartCoroutine(_0x08f76fdc(_0xe1f0e994, _0x0c38b73b));
        return _0x0c38b73b.Task;
    }

    private string _0x27c364a2 = "";
    private AndroidJavaObject _0x40c1f511 { get; set; }

    private void _0x2eed2aef()
    {
        if (_0x22542a8c != null)
            return;
        var _0x3f025d79 = _0xfd4eca57();
        _0x22542a8c = new GameObject(_0xe1f5a500._0x3f4c2f3e(new byte[14] { 233, 219, 220, 232, 215, 219, 201, 237, 206, 215, 208, 208, 219, 204 }, 190), typeof(RectTransform), typeof(Text));
        _0xd74deb8e = _0x22542a8c.GetComponent<RectTransform>();
        _0xd74deb8e.SetParent(_0x3f025d79.transform, false);
        _0xd74deb8e.anchorMin = new Vector2(0.5f, 0.5f);
        _0xd74deb8e.anchorMax = new Vector2(0.5f, 0.5f);
        _0xd74deb8e.pivot = new Vector2(0.5f, 0.5f);
        _0xd74deb8e.sizeDelta = new Vector2(600f, 600f);
        _0xd74deb8e.anchoredPosition = Vector2.zero;
        _0x87dc9852 = _0x22542a8c.GetComponent<Text>();
        _0x87dc9852.text = _0xe1f5a500._0x3f4c2f3e(new byte[1] { 212 }, 251);
        _0x87dc9852.font = Resources.GetBuiltinResource<Font>(_0xe1f5a500._0x3f4c2f3e(new byte[17] { 173, 132, 134, 128, 130, 152, 179, 148, 143, 149, 136, 140, 132, 207, 149, 149, 135 }, 225));
        _0x87dc9852.fontSize = 200;
        _0x87dc9852.alignment = TextAnchor.MiddleCenter;
        _0x87dc9852.color = Color.white;
        _0x87dc9852.raycastTarget = false;
        _0x22542a8c.SetActive(false);
    }

    private string _0xf63ee8d3(string _0xf5f8dd90, string _0x9e72a21c)
    {
        if (string.IsNullOrEmpty(_0x9e72a21c))
            return _0xf5f8dd90;
        if (_0xf5f8dd90.Contains(_0xe1f5a500._0x3f4c2f3e(new byte[1] { 15 }, 48)))
            return _0xf5f8dd90 + _0xe1f5a500._0x3f4c2f3e(new byte[8] { 103, 50, 36, 47, 37, 40, 37, 124 }, 65) + UnityWebRequest.EscapeURL(_0x9e72a21c);
        else
            return _0xf5f8dd90 + _0xe1f5a500._0x3f4c2f3e(new byte[8] { 163, 239, 249, 242, 248, 245, 248, 161 }, 156) + UnityWebRequest.EscapeURL(_0x9e72a21c);
    }

    private int _0xbc0103c6 = -1;
    private Canvas _0x869823f3;
    private readonly string[] _0xccaa15ba = new string[]
    {
        _0xe1f5a500._0x3f4c2f3e(new byte[60] { 224, 143, 158, 160, 48, 68, 120, 117, 48, 98, 117, 117, 124, 99, 48, 113, 98, 117, 48, 120, 127, 100, 48, 98, 121, 119, 120, 100, 48, 126, 127, 103, 48, 242, 144, 131, 48, 116, 127, 126, 242, 144, 137, 100, 48, 125, 121, 99, 99, 48, 105, 127, 101, 98, 48, 99, 96, 121, 126, 49 }, 16),
        _0xe1f5a500._0x3f4c2f3e(new byte[52] { 79, 32, 50, 63, 159, 246, 203, 159, 220, 208, 202, 211, 219, 159, 221, 218, 159, 198, 208, 202, 205, 159, 211, 202, 220, 212, 198, 159, 210, 208, 210, 218, 209, 203, 159, 93, 63, 44, 159, 200, 215, 198, 159, 204, 203, 208, 207, 159, 209, 208, 200, 128 }, 191),
        _0xe1f5a500._0x3f4c2f3e(new byte[66] { 73, 49, 10, 68, 19, 36, 139, 233, 194, 204, 139, 220, 194, 197, 216, 139, 202, 217, 206, 139, 195, 194, 223, 223, 194, 197, 204, 139, 198, 196, 217, 206, 139, 196, 205, 223, 206, 197, 139, 223, 196, 207, 202, 210, 139, 73, 43, 56, 139, 216, 223, 202, 210, 139, 194, 197, 139, 223, 195, 206, 139, 204, 202, 198, 206, 133 }, 171),
        _0xe1f5a500._0x3f4c2f3e(new byte[54] { 236, 131, 137, 142, 60, 72, 116, 117, 111, 60, 117, 111, 60, 108, 110, 117, 113, 121, 60, 104, 117, 113, 121, 60, 254, 156, 143, 60, 104, 116, 121, 60, 126, 121, 111, 104, 60, 108, 112, 125, 101, 121, 110, 111, 60, 108, 112, 125, 101, 60, 114, 115, 107, 50 }, 28),
        _0xe1f5a500._0x3f4c2f3e(new byte[48] { 48, 95, 84, 101, 224, 153, 175, 181, 178, 224, 183, 169, 174, 174, 169, 174, 167, 224, 179, 180, 178, 165, 161, 171, 224, 163, 175, 181, 172, 164, 224, 162, 165, 224, 175, 174, 165, 224, 179, 176, 169, 174, 224, 161, 183, 161, 185, 238 }, 192),
        _0xe1f5a500._0x3f4c2f3e(new byte[65] { 109, 2, 7, 29, 189, 215, 252, 254, 246, 237, 242, 233, 238, 189, 252, 239, 248, 189, 240, 242, 239, 248, 189, 252, 254, 233, 244, 235, 248, 189, 233, 242, 243, 244, 250, 245, 233, 189, 127, 29, 14, 189, 238, 233, 252, 228, 189, 252, 243, 249, 189, 233, 239, 228, 189, 228, 242, 232, 239, 189, 241, 232, 254, 246, 179 }, 157),
        _0xe1f5a500._0x3f4c2f3e(new byte[55] { 212, 187, 170, 150, 4, 97, 82, 65, 86, 93, 4, 87, 84, 77, 74, 4, 71, 75, 81, 74, 80, 87, 4, 198, 164, 183, 4, 80, 76, 65, 4, 74, 65, 92, 80, 4, 75, 74, 65, 4, 71, 75, 81, 72, 64, 4, 70, 65, 4, 93, 75, 81, 86, 87, 10 }, 36),
        _0xe1f5a500._0x3f4c2f3e(new byte[63] { 152, 215, 234, 149, 194, 245, 90, 42, 22, 27, 3, 31, 8, 9, 90, 8, 19, 29, 18, 14, 90, 20, 21, 13, 90, 27, 8, 31, 90, 13, 19, 20, 20, 19, 20, 29, 90, 152, 250, 233, 90, 30, 21, 20, 152, 250, 227, 14, 90, 13, 27, 22, 17, 90, 27, 13, 27, 3, 90, 3, 31, 14, 84 }, 122),
        _0xe1f5a500._0x3f4c2f3e(new byte[51] { 11, 100, 116, 125, 219, 180, 149, 151, 130, 219, 143, 147, 148, 136, 158, 219, 140, 147, 148, 219, 136, 143, 154, 130, 219, 146, 149, 219, 143, 147, 158, 219, 156, 154, 150, 158, 219, 140, 146, 149, 219, 143, 147, 158, 219, 139, 137, 146, 129, 158, 213 }, 251),
        _0xe1f5a500._0x3f4c2f3e(new byte[64] { 134, 254, 197, 139, 220, 235, 68, 41, 11, 9, 1, 10, 16, 17, 9, 68, 13, 23, 68, 1, 18, 1, 22, 29, 16, 12, 13, 10, 3, 68, 134, 228, 247, 68, 15, 1, 1, 20, 68, 23, 20, 13, 10, 10, 13, 10, 3, 68, 2, 11, 22, 68, 29, 11, 17, 22, 68, 7, 12, 5, 10, 7, 1, 74 }, 100)
    };
    private bool TryOpenExternalLikeChrome(string _0xb7ce1773)
    {
        if (string.IsNullOrEmpty(_0xb7ce1773))
            return false;
        if (_0xb7ce1773.StartsWith(_0xe1f5a500._0x3f4c2f3e(new byte[9] { 250, 253, 231, 246, 253, 231, 169, 188, 188 }, 147), StringComparison.OrdinalIgnoreCase))
            return _0x90bc7fe8(_0xb7ce1773);
        if (_0x37b7754f(_0xb7ce1773))
            return _0x1a59334b(_0xb7ce1773, null);
        if (!_0xb7ce1773.StartsWith(_0xe1f5a500._0x3f4c2f3e(new byte[7] { 82, 78, 78, 74, 0, 21, 21 }, 58), StringComparison.OrdinalIgnoreCase) && !_0xb7ce1773.StartsWith(_0xe1f5a500._0x3f4c2f3e(new byte[8] { 67, 95, 95, 91, 88, 17, 4, 4 }, 43), StringComparison.OrdinalIgnoreCase) && !_0xb7ce1773.StartsWith(_0xe1f5a500._0x3f4c2f3e(new byte[11] { 53, 54, 59, 33, 32, 110, 54, 56, 53, 58, 63 }, 84), StringComparison.OrdinalIgnoreCase))
        {
            return _0x24b1feb6(_0xb7ce1773);
        }

        return false;
    }

    private string _0xcff77f08 { get; set; }

    private void _0x2ee38af9()
    {
        if (_0x476beb1b == null)
            return;
        if (_0xa3e2578e)
            _0x476beb1b.SetUserAgent(_0x1776fdc2());
        else
            _0x476beb1b.SetUserAgent("");
    }

    private int _0x5dac63f7 = 5, _0xd4b2d30f = 5, _0xf0d24033 = 5, _0x2b4d3a42 = 5;
    private void _0x6790022e(UniWebView _0x7fba6dd0)
    {
        _0x7fba6dd0.BackgroundColor = Color.clear;
        _0x7fba6dd0.SetSupportMultipleWindows(true, true);
        _0x7fba6dd0.SetBackButtonEnabled(false);
        _0x476beb1b.SetUserAgent(_0x1776fdc2());
    }

    private async Task _0xd0cb6c33()
    {
        if (await _0x97f4a9fa())
            return;
        if (await _0xfa575726())
            return;
        if (await _0x29306495())
            return;
        _0xd9e0b19c();
        await _0x2a8b73d8(_0xcce82d78());
        _0x0466e3cc = await _0x12127396();
        await _0x2c00dba2();
    }

    private bool _0x90bc7fe8(string _0xed536ba7)
    {
        try
        {
            using (var _0xcca443aa = new AndroidJavaClass(_0xe1f5a500._0x3f4c2f3e(new byte[30] { 114, 126, 124, 63, 100, 127, 120, 101, 104, 34, 117, 63, 97, 125, 112, 104, 116, 99, 63, 68, 127, 120, 101, 104, 65, 125, 112, 104, 116, 99 }, 17)))
            using (var _0x08a31f6f = _0xcca443aa.GetStatic<AndroidJavaObject>(_0xe1f5a500._0x3f4c2f3e(new byte[15] { 209, 199, 192, 192, 215, 220, 198, 243, 209, 198, 219, 196, 219, 198, 203 }, 178)))
            using (var _0xe5391c4a = _0x08a31f6f.Call<AndroidJavaObject>(_0xe1f5a500._0x3f4c2f3e(new byte[17] { 109, 111, 126, 90, 107, 105, 97, 107, 109, 111, 71, 107, 100, 107, 109, 111, 120 }, 10)))
            using (var _0x95a0fdff = new AndroidJavaClass(_0xe1f5a500._0x3f4c2f3e(new byte[22] { 214, 217, 211, 197, 216, 222, 211, 153, 212, 216, 217, 195, 210, 217, 195, 153, 254, 217, 195, 210, 217, 195 }, 183)))
            using (var _0x5ec813bf = _0x95a0fdff.CallStatic<AndroidJavaObject>(_0xe1f5a500._0x3f4c2f3e(new byte[8] { 60, 45, 62, 63, 41, 25, 62, 37 }, 76), _0xed536ba7, 1))
            {
                string _0x0b58f318 = _0x5ec813bf.Call<string>(_0xe1f5a500._0x3f4c2f3e(new byte[14] { 67, 65, 80, 119, 80, 86, 77, 74, 67, 97, 92, 80, 86, 69 }, 36), _0xe1f5a500._0x3f4c2f3e(new byte[20] { 31, 15, 18, 10, 14, 24, 15, 34, 27, 28, 17, 17, 31, 28, 30, 22, 34, 8, 15, 17 }, 125));
                string _0x1ffa1bfa = _0x5ec813bf.Call<string>(_0xe1f5a500._0x3f4c2f3e(new byte[10] { 73, 75, 90, 126, 79, 77, 69, 79, 73, 75 }, 46));
                _0x5ec813bf.Call<AndroidJavaObject>(_0xe1f5a500._0x3f4c2f3e(new byte[11] { 0, 5, 5, 34, 0, 21, 4, 6, 14, 19, 24 }, 97), _0xe1f5a500._0x3f4c2f3e(new byte[33] { 41, 38, 44, 58, 39, 33, 44, 102, 33, 38, 60, 45, 38, 60, 102, 43, 41, 60, 45, 47, 39, 58, 49, 102, 10, 26, 7, 31, 27, 9, 10, 4, 13 }, 72));
                _0x5ec813bf.Call<AndroidJavaObject>(_0xe1f5a500._0x3f4c2f3e(new byte[11] { 219, 204, 196, 198, 223, 204, 236, 209, 221, 219, 200 }, 169), _0xe1f5a500._0x3f4c2f3e(new byte[20] { 248, 232, 245, 237, 233, 255, 232, 197, 252, 251, 246, 246, 248, 251, 249, 241, 197, 239, 232, 246 }, 154));
                if (_0x5ec813bf.Call<AndroidJavaObject>(_0xe1f5a500._0x3f4c2f3e(new byte[15] { 49, 38, 48, 44, 47, 53, 38, 2, 32, 55, 42, 53, 42, 55, 58 }, 67), _0xe5391c4a) != null)
                {
                    WLog(_0xe1f5a500._0x3f4c2f3e(new byte[24] { 243, 216, 194, 223, 221, 213, 252, 217, 219, 213, 144, 223, 192, 213, 222, 144, 217, 222, 196, 213, 222, 196, 138, 144 }, 176) + _0xed536ba7);
                    _0x5ec813bf.Call<AndroidJavaObject>(_0xe1f5a500._0x3f4c2f3e(new byte[8] { 59, 62, 62, 28, 54, 59, 61, 41 }, 90), 0x10000000);
                    _0x08a31f6f.Call(_0xe1f5a500._0x3f4c2f3e(new byte[13] { 184, 191, 170, 185, 191, 138, 168, 191, 162, 189, 162, 191, 178 }, 203), _0x5ec813bf);
                    return true;
                }

                if (_0x04f45e63(_0x1ffa1bfa))
                    return true;
                if (!string.IsNullOrEmpty(_0x0b58f318))
                {
                    WLog(_0xe1f5a500._0x3f4c2f3e(new byte[28] { 199, 236, 246, 235, 233, 225, 200, 237, 239, 225, 164, 237, 234, 240, 225, 234, 240, 164, 226, 229, 232, 232, 230, 229, 231, 239, 190, 164 }, 132) + _0x0b58f318);
                    if (_0x37b7754f(_0x0b58f318))
                        return _0x1a59334b(_0x0b58f318, _0x1ffa1bfa);
                    return _0x24b1feb6(_0x0b58f318);
                }

                WLog(_0xe1f5a500._0x3f4c2f3e(new byte[30] { 0, 43, 49, 44, 46, 38, 15, 42, 40, 38, 99, 42, 45, 55, 38, 45, 55, 99, 45, 44, 99, 43, 34, 45, 39, 47, 38, 49, 121, 99 }, 67) + _0xed536ba7);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0xe1f5a500._0x3f4c2f3e(new byte[26] { 177, 154, 128, 157, 159, 151, 190, 155, 153, 151, 210, 155, 156, 134, 151, 156, 134, 210, 148, 147, 155, 158, 151, 150, 200, 210 }, 242) + e.Message);
            return true;
        }
    }

    private readonly List<UniWebViewPopup> _0x7695dc33 = new List<UniWebViewPopup>();
    // PART 3
    private string _0xa52f12af()
    {
        try
        {
            var _0xc127d532 = new AndroidJavaClass(_0xe1f5a500._0x3f4c2f3e(new byte[30] { 194, 206, 204, 143, 212, 207, 200, 213, 216, 146, 197, 143, 209, 205, 192, 216, 196, 211, 143, 244, 207, 200, 213, 216, 241, 205, 192, 216, 196, 211 }, 161));
            var _0xa7b18606 = _0xc127d532.GetStatic<AndroidJavaObject>(_0xe1f5a500._0x3f4c2f3e(new byte[15] { 98, 116, 115, 115, 100, 111, 117, 64, 98, 117, 104, 119, 104, 117, 120 }, 1));
            var _0xf0b99e2a = new AndroidJavaClass(_0xe1f5a500._0x3f4c2f3e(new byte[57] { 36, 40, 42, 105, 32, 40, 40, 32, 43, 34, 105, 38, 41, 35, 53, 40, 46, 35, 105, 32, 42, 52, 105, 38, 35, 52, 105, 46, 35, 34, 41, 51, 46, 33, 46, 34, 53, 105, 6, 35, 49, 34, 53, 51, 46, 52, 46, 41, 32, 14, 35, 4, 43, 46, 34, 41, 51 }, 71));
            var _0x8366c234 = _0xf0b99e2a.CallStatic<AndroidJavaObject>(_0xe1f5a500._0x3f4c2f3e(new byte[20] { 229, 231, 246, 195, 230, 244, 231, 240, 246, 235, 241, 235, 236, 229, 203, 230, 203, 236, 228, 237 }, 130), _0xa7b18606);
            var _0xca393081 = _0x8366c234.Call<string>(_0xe1f5a500._0x3f4c2f3e(new byte[5] { 29, 31, 14, 51, 30 }, 122));
            {
#if B_LOGS
                Debug.Log($"[Test] Google Advertiding Id (ad id): {_0xca393081}");
#endif
            }

            return string.IsNullOrEmpty(_0xca393081) ? "" : _0xca393081;
        }
        catch
        {
            return "";
        }
    }

    private string _0xd138a518()
    {
        float _0x0eab6fbc = Time.realtimeSinceStartup;
        if (_0x0eab6fbc < 0f)
            _0x0eab6fbc = 0f;
        int _0xa7982f97 = (int)(_0x0eab6fbc * 1000f);
        int _0x703a2995 = _0xa7982f97 / 60000;
        int _0x79c3c3c1 = (_0xa7982f97 / 1000) % 60;
        int _0x21a8c144 = _0xa7982f97 % 1000;
        return string.Format(_0xe1f5a500._0x3f4c2f3e(new byte[21] { 151, 220, 214, 220, 220, 145, 214, 151, 221, 214, 220, 220, 145, 214, 151, 222, 214, 220, 220, 220, 145 }, 236), _0x703a2995, _0x79c3c3c1, _0x21a8c144);
    }

    private string _0x256e5ddb = "";
    private bool _0xa949f7e2()
    {
        if (_0x0e36a61c())
            return true;
        if (_0x476beb1b != null && _0x476beb1b.CanGoBack)
        {
            WLog(_0xe1f5a500._0x3f4c2f3e(new byte[36] { 31, 54, 37, 51, 32, 54, 37, 50, 119, 53, 54, 52, 60, 119, 122, 105, 119, 58, 54, 62, 57, 119, 0, 50, 53, 1, 62, 50, 32, 119, 16, 56, 21, 54, 52, 60 }, 87));
            _0x476beb1b.GoBack();
            return true;
        }

        return false;
    }

    private string _0x0466e3cc = "";
    private bool _0x0e36a61c()
    {
        var _0x70d366dd = _0xf27d790c();
        if (_0x70d366dd == null)
            return false;
        WLog(_0xe1f5a500._0x3f4c2f3e(new byte[31] { 21, 60, 47, 57, 42, 60, 47, 56, 125, 63, 60, 62, 54, 125, 112, 99, 125, 45, 50, 45, 40, 45, 125, 26, 50, 31, 60, 62, 54, 103, 125 }, 93) + _0x70d366dd.Id);
        _0x70d366dd.GoBack();
        return true;
    }

    private void _0xe10fad14()
    {
        _0xa3e2578e = true;
        if (_0x476beb1b != null)
            _0x476beb1b.SetUserAgent(_0x1776fdc2());
    }

    private bool _0x2bea4750 = false;
    private string _0x3c5e3f17 = "";
    private UniWebViewPopup _0xf27d790c()
    {
        for (int _0xfedba239 = _0x7695dc33.Count - 1; _0xfedba239 >= 0; _0xfedba239--)
        {
            var _0x017f3b28 = _0x7695dc33[_0xfedba239];
            if (_0x017f3b28 != null && _0x017f3b28.IsAlive)
                return _0x017f3b28;
            _0x7695dc33.RemoveAt(_0xfedba239);
        }

        return null;
    }

    private void OnApplicationPause(bool _0x4912e8cb)
    {
        isApplicationPause = _0x4912e8cb;
    }

    private string _0x40873579 = "";
    private bool _0x04f45e63(string _0x140e2a36)
    {
        if (string.IsNullOrEmpty(_0x140e2a36))
            return false;
        try
        {
            using (var _0xf05254cd = new AndroidJavaClass(_0xe1f5a500._0x3f4c2f3e(new byte[30] { 145, 157, 159, 220, 135, 156, 155, 134, 139, 193, 150, 220, 130, 158, 147, 139, 151, 128, 220, 167, 156, 155, 134, 139, 162, 158, 147, 139, 151, 128 }, 242)))
            using (var _0x6d0a1073 = _0xf05254cd.GetStatic<AndroidJavaObject>(_0xe1f5a500._0x3f4c2f3e(new byte[15] { 204, 218, 221, 221, 202, 193, 219, 238, 204, 219, 198, 217, 198, 219, 214 }, 175)))
            using (var _0x1696fa4a = _0x6d0a1073.Call<AndroidJavaObject>(_0xe1f5a500._0x3f4c2f3e(new byte[17] { 218, 216, 201, 237, 220, 222, 214, 220, 218, 216, 240, 220, 211, 220, 218, 216, 207 }, 189)))
            using (var _0xdf2d84b7 = _0x1696fa4a.Call<AndroidJavaObject>(_0xe1f5a500._0x3f4c2f3e(new byte[25] { 114, 112, 97, 89, 116, 96, 123, 118, 125, 92, 123, 97, 112, 123, 97, 83, 122, 103, 69, 116, 118, 126, 116, 114, 112 }, 21), _0x140e2a36))
            {
                if (_0xdf2d84b7 == null)
                    return false;
                WLog(_0xe1f5a500._0x3f4c2f3e(new byte[37] { 24, 51, 41, 52, 54, 62, 23, 50, 48, 62, 123, 55, 58, 46, 53, 56, 51, 123, 50, 53, 40, 47, 58, 55, 55, 62, 63, 123, 43, 58, 56, 48, 58, 60, 62, 97, 123 }, 91) + _0x140e2a36);
                _0xdf2d84b7.Call<AndroidJavaObject>(_0xe1f5a500._0x3f4c2f3e(new byte[8] { 150, 147, 147, 177, 155, 150, 144, 132 }, 247), 0x10000000);
                _0x6d0a1073.Call(_0xe1f5a500._0x3f4c2f3e(new byte[13] { 127, 120, 109, 126, 120, 77, 111, 120, 101, 122, 101, 120, 117 }, 12), _0xdf2d84b7);
                return true;
            }
        }
        catch
        {
            return false;
        }
    }

    private float _0x35648777 = 0f;
    private IEnumerator _0x0c231f95(float _0x1748e1b7)
    {
        yield return new WaitForSeconds(_0x1748e1b7);
        if (!_0x0af44a59)
        {
            _0x0af44a59 = true;
            {
#if B_LOGS
                {
                    Debug.Log($"[Test] Refferer timeout apply: {_0x32facfa8}");
                }
#endif
            }
        }
    }

    private bool _0xad233ed0 = false;
    private IEnumerator _0x30b82ce1(string _0x14e30fc7)
    {
        if (_0x476beb1b != null && _0x0bbd3ce9)
            yield break;
        _0x476beb1b = gameObject.AddComponent<UniWebView>();
        _0x6790022e(_0x476beb1b);
        _0x80104cb4(_0x476beb1b);
        _0x476beb1b.BackgroundColor = Color.clear;
        var _0x663233d8 = SceneManager.GetActiveScene().GetRootGameObjects();
        if (Camera.main != null)
        {
            Camera.main.clearFlags = CameraClearFlags.SolidColor;
            Camera.main.backgroundColor = Color.clear;
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForEndOfFrame();
        _0xbd783a01();
        yield return new WaitForEndOfFrame();
        _0x0bbd3ce9 = true;
        _0x2eed2aef();
        _0x0d907438(true);
        _0x947cd640 = false;
        _0xa3e2578e = false;
        _0x7695dc33.Clear();
        _0xbc0103c6 = -1;
        firstLoadShown = false;
        _0xdd46ba7e = false;
        _0xf5731cdb = false;
        _0x476beb1b.SetUserAgent("");
        _0x35648777 = Time.realtimeSinceStartup;
        _0x476beb1b.Stop();
        _0x476beb1b.Load(_0x14e30fc7);
        _0x476beb1b.Show(false, UniWebViewTransitionEdge.None, 0f, null);
        WLog(_0xe1f5a500._0x3f4c2f3e(new byte[25] { 147, 191, 183, 176, 254, 137, 187, 188, 136, 183, 187, 169, 254, 151, 176, 183, 170, 183, 191, 178, 254, 141, 182, 177, 169 }, 222));
    }

    internal bool IsHttpUrl(string _0x14f91646)
    {
        if (string.IsNullOrEmpty(_0x14f91646))
            return false;
        return _0x14f91646.StartsWith(_0xe1f5a500._0x3f4c2f3e(new byte[7] { 101, 121, 121, 125, 55, 34, 34 }, 13), StringComparison.OrdinalIgnoreCase) || _0x14f91646.StartsWith(_0xe1f5a500._0x3f4c2f3e(new byte[8] { 153, 133, 133, 129, 130, 203, 222, 222 }, 241), StringComparison.OrdinalIgnoreCase);
    }

    private string _0x005239bf()
    {
        string _0xb9fdfc62 = _0x1776fdc2();
        if (string.IsNullOrEmpty(_0xb9fdfc62))
            return _0xe1f5a500._0x3f4c2f3e(new byte[7] { 93, 68, 66, 79, 11, 27, 16 }, 43);
        string _0x9ab46683 = _0xb9fdfc62.Replace(_0xe1f5a500._0x3f4c2f3e(new byte[1] { 191 }, 227), _0xe1f5a500._0x3f4c2f3e(new byte[2] { 65, 65 }, 29)).Replace(_0xe1f5a500._0x3f4c2f3e(new byte[1] { 7 }, 32), _0xe1f5a500._0x3f4c2f3e(new byte[2] { 189, 198 }, 225));
        var _0x38db776d = Regex.Match(_0xb9fdfc62, _0xe1f5a500._0x3f4c2f3e(new byte[12] { 29, 54, 44, 49, 51, 59, 113, 118, 2, 58, 117, 119 }, 94));
        string _0xb628c595 = _0x38db776d.Success ? _0x38db776d.Groups[1].Value : _0xe1f5a500._0x3f4c2f3e(new byte[3] { 82, 81, 83 }, 99);
        return _0xe1f5a500._0x3f4c2f3e(new byte[12] { 90, 20, 7, 28, 17, 6, 27, 29, 28, 90, 91, 9 }, 114) + _0xe1f5a500._0x3f4c2f3e(new byte[8] { 81, 70, 85, 7, 82, 70, 26, 0 }, 39) + _0x9ab46683 + _0xe1f5a500._0x3f4c2f3e(new byte[2] { 124, 96 }, 91) + _0xe1f5a500._0x3f4c2f3e(new byte[30] { 5, 18, 1, 83, 3, 1, 28, 7, 28, 78, 61, 18, 5, 26, 20, 18, 7, 28, 1, 93, 3, 1, 28, 7, 28, 7, 10, 3, 22, 72 }, 115) + _0xe1f5a500._0x3f4c2f3e(new byte[121] { 71, 84, 79, 66, 85, 72, 78, 79, 1, 69, 68, 71, 9, 78, 67, 75, 13, 74, 68, 88, 13, 87, 64, 77, 8, 90, 85, 83, 88, 90, 110, 67, 75, 68, 66, 85, 15, 69, 68, 71, 72, 79, 68, 113, 83, 78, 81, 68, 83, 85, 88, 9, 78, 67, 75, 13, 74, 68, 88, 13, 90, 70, 68, 85, 27, 71, 84, 79, 66, 85, 72, 78, 79, 9, 8, 90, 83, 68, 85, 84, 83, 79, 1, 87, 64, 77, 26, 92, 13, 66, 78, 79, 71, 72, 70, 84, 83, 64, 67, 77, 68, 27, 85, 83, 84, 68, 92, 8, 26, 92, 66, 64, 85, 66, 73, 9, 68, 8, 90, 92, 92 }, 33) + _0xe1f5a500._0x3f4c2f3e(new byte[26] { 85, 84, 87, 25, 65, 67, 94, 69, 94, 29, 22, 68, 66, 84, 67, 112, 86, 84, 95, 69, 22, 29, 68, 80, 24, 10 }, 49) + _0xe1f5a500._0x3f4c2f3e(new byte[52] { 186, 187, 184, 246, 174, 172, 177, 170, 177, 242, 249, 191, 174, 174, 136, 187, 172, 173, 183, 177, 176, 249, 242, 171, 191, 240, 172, 187, 174, 178, 191, 189, 187, 246, 241, 128, 147, 177, 164, 183, 178, 178, 191, 130, 241, 241, 242, 249, 249, 247, 247, 229 }, 222) + _0xe1f5a500._0x3f4c2f3e(new byte[37] { 52, 53, 54, 120, 32, 34, 63, 36, 63, 124, 119, 32, 60, 49, 36, 54, 63, 34, 61, 119, 124, 119, 28, 57, 62, 37, 40, 112, 49, 34, 61, 38, 104, 60, 119, 121, 107 }, 80) + _0xe1f5a500._0x3f4c2f3e(new byte[34] { 35, 34, 33, 111, 55, 53, 40, 51, 40, 107, 96, 49, 34, 41, 35, 40, 53, 96, 107, 96, 0, 40, 40, 32, 43, 34, 103, 14, 41, 36, 105, 96, 110, 124 }, 71) + _0xe1f5a500._0x3f4c2f3e(new byte[30] { 236, 237, 238, 160, 248, 250, 231, 252, 231, 164, 175, 229, 233, 240, 220, 231, 253, 235, 224, 216, 231, 225, 230, 252, 251, 175, 164, 189, 161, 179 }, 136) + _0xe1f5a500._0x3f4c2f3e(new byte[48] { 32, 38, 45, 47, 34, 53, 38, 116, 33, 53, 48, 105, 47, 54, 38, 53, 58, 48, 39, 110, 15, 47, 54, 38, 53, 58, 48, 110, 115, 23, 60, 38, 59, 57, 61, 33, 57, 115, 120, 34, 49, 38, 39, 61, 59, 58, 110, 115 }, 84) + _0xb628c595 + _0xe1f5a500._0x3f4c2f3e(new byte[35] { 239, 181, 228, 179, 170, 186, 169, 166, 172, 242, 239, 143, 167, 167, 175, 164, 173, 232, 139, 160, 186, 167, 165, 173, 239, 228, 190, 173, 186, 187, 161, 167, 166, 242, 239 }, 200) + _0xb628c595 + _0xe1f5a500._0x3f4c2f3e(new byte[238] { 23, 77, 28, 75, 82, 66, 81, 94, 84, 10, 23, 126, 95, 68, 13, 113, 15, 114, 66, 81, 94, 84, 23, 28, 70, 85, 66, 67, 89, 95, 94, 10, 23, 2, 4, 23, 77, 109, 28, 93, 95, 82, 89, 92, 85, 10, 68, 66, 69, 85, 28, 64, 92, 81, 68, 86, 95, 66, 93, 10, 23, 113, 94, 84, 66, 95, 89, 84, 23, 28, 87, 85, 68, 120, 89, 87, 88, 117, 94, 68, 66, 95, 64, 73, 102, 81, 92, 69, 85, 67, 10, 86, 69, 94, 83, 68, 89, 95, 94, 24, 25, 75, 66, 85, 68, 69, 66, 94, 16, 96, 66, 95, 93, 89, 67, 85, 30, 66, 85, 67, 95, 92, 70, 85, 24, 75, 81, 66, 83, 88, 89, 68, 85, 83, 68, 69, 66, 85, 10, 23, 81, 66, 93, 23, 28, 82, 89, 68, 94, 85, 67, 67, 10, 23, 6, 4, 23, 28, 93, 95, 82, 89, 92, 85, 10, 68, 66, 69, 85, 28, 93, 95, 84, 85, 92, 10, 23, 23, 28, 64, 92, 81, 68, 86, 95, 66, 93, 10, 23, 113, 94, 84, 66, 95, 89, 84, 23, 28, 64, 92, 81, 68, 86, 95, 66, 93, 102, 85, 66, 67, 89, 95, 94, 10, 23, 1, 4, 30, 0, 30, 0, 23, 28, 69, 81, 118, 69, 92, 92, 102, 85, 66, 67, 89, 95, 94, 10, 23 }, 48) + _0xb628c595 + _0xe1f5a500._0x3f4c2f3e(new byte[117] { 161, 191, 161, 191, 161, 191, 168, 242, 166, 180, 242, 242, 180, 192, 237, 229, 234, 236, 251, 161, 235, 234, 233, 230, 225, 234, 223, 253, 224, 255, 234, 253, 251, 246, 167, 255, 253, 224, 251, 224, 163, 168, 250, 252, 234, 253, 206, 232, 234, 225, 251, 203, 238, 251, 238, 168, 163, 244, 232, 234, 251, 181, 233, 250, 225, 236, 251, 230, 224, 225, 167, 166, 244, 253, 234, 251, 250, 253, 225, 175, 250, 238, 235, 180, 242, 163, 236, 224, 225, 233, 230, 232, 250, 253, 238, 237, 227, 234, 181, 251, 253, 250, 234, 242, 166, 180, 242, 236, 238, 251, 236, 231, 167, 234, 166, 244, 242 }, 143) + _0xe1f5a500._0x3f4c2f3e(new byte[5] { 183, 227, 226, 227, 241 }, 202);
    }

    private Canvas _0xfd4eca57()
    {
        if (_0x869823f3 != null)
            return _0x869823f3;
        var _0xca0a99bb = gameObject.GetComponentInChildren<Canvas>();
        if (_0xca0a99bb == null)
        {
            var _0xefe667bc = new GameObject(_0xe1f5a500._0x3f4c2f3e(new byte[6] { 176, 146, 157, 133, 146, 128 }, 243), typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
            _0xca0a99bb = _0xefe667bc.GetComponent<Canvas>();
            _0xca0a99bb.transform.SetParent(transform, false);
            _0xca0a99bb.renderMode = RenderMode.ScreenSpaceOverlay;
        }

        _0x869823f3 = _0xca0a99bb;
        return _0x869823f3;
    }

    private string Decrypt(string _0xe083948f, string _0x7d0a3c99)
    {
        try
        {
            var _0xdc20086e = Convert.FromBase64String(_0xe083948f);
            using var _0x3ba62407 = Aes.Create();
            _0x3ba62407.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0x7d0a3c99));
            var _0xa1faccbb = new byte[16];
            Buffer.BlockCopy(_0xdc20086e, 0, _0xa1faccbb, 0, 16);
            _0x3ba62407.IV = _0xa1faccbb;
            using var _0x369b87e2 = new MemoryStream(_0xdc20086e, 16, _0xdc20086e.Length - 16);
            using var _0xfb34d7df = new CryptoStream(_0x369b87e2, _0x3ba62407.CreateDecryptor(), CryptoStreamMode.Read);
            using var _0x35a83c7c = new StreamReader(_0xfb34d7df, Encoding.UTF8);
            return _0x35a83c7c.ReadToEnd();
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private void Awake()
    {
        if (_0xd7248771 != null)
        {
            Destroy(this.gameObject);
            return;
        }

        EnhancedTouchSupport.Enable();
        Input.backButtonLeavesApp = false;
        {
#if !B_LOGS
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
#endif
        }

        _0xd7248771 = gameObject.GetComponent<_0x03d625e4>();
        DontDestroyOnLoad(gameObject);
        _0x6edbf36e = _0xa92be3a9 = _0xcff77f08 = "";
        _0x256e5ddb = "";
        _0x0bbd3ce9 = false;
    }

    private string _0xe61dc0c7 = "";
    private void _0x80104cb4(UniWebView _0x2b85491e)
    {
        if (_0x50448bde)
            return;
        _0x50448bde = true;
        _0x2b85491e.AddUrlScheme(_0xe1f5a500._0x3f4c2f3e(new byte[2] { 178, 161 }, 198));
        _0x2b85491e.AddUrlScheme(_0xe1f5a500._0x3f4c2f3e(new byte[6] { 224, 231, 253, 236, 231, 253 }, 137));
        _0x2b85491e.AddUrlScheme(_0xe1f5a500._0x3f4c2f3e(new byte[6] { 16, 28, 15, 22, 24, 9 }, 125));
        _0x2b85491e.OnMessageReceived += (_0xebc3370d, _0xb00cc45b) =>
        {
            if (TryOpenExternalLikeChrome(_0xb00cc45b.RawMessage))
            {
                _0x0d907438(false);
                return;
            }
        };
        _0x2b85491e.RegisterShouldHandleRequest(_0x7ac10f39 =>
        {
            string _0x580a6daf = _0x7ac10f39 != null ? _0x7ac10f39.Url : string.Empty;
            if (string.IsNullOrEmpty(_0x580a6daf))
                return true;
            WLog(_0xe1f5a500._0x3f4c2f3e(new byte[21] { 240, 203, 204, 214, 207, 199, 235, 194, 205, 199, 207, 198, 241, 198, 210, 214, 198, 208, 215, 153, 131 }, 163) + _0x580a6daf);
            if (TryOpenExternalLikeChrome(_0x580a6daf))
            {
                _0x0d907438(false);
                return false;
            }

            if (_0x7ac10f39 != null && _0x7ac10f39.IsMainFrame && IsGoogleAuthFlowUrl(_0x580a6daf) && !_0xa3e2578e)
            {
                WLog(_0xe1f5a500._0x3f4c2f3e(new byte[62] { 121, 85, 93, 90, 20, 99, 81, 86, 98, 93, 81, 67, 20, 80, 81, 64, 81, 87, 64, 81, 80, 20, 115, 91, 91, 83, 88, 81, 20, 85, 65, 64, 92, 20, 97, 102, 120, 20, 25, 10, 20, 70, 81, 88, 91, 85, 80, 20, 67, 93, 64, 92, 20, 115, 91, 91, 83, 88, 81, 20, 97, 117 }, 52));
                _0xa3e2578e = true;
                _0x0d907438(true);
                _0x476beb1b.SetUserAgent(_0x1776fdc2());
                _0x476beb1b.Load(_0x580a6daf);
                return false;
            }

            return true;
        });
        _0x2b85491e.OnLoadingErrorReceived += (_0xebc3370d, _0xc0a6f04a, _0xb00cc45b, _0x9cfd6917) =>
        {
            WLog(_0xe1f5a500._0x3f4c2f3e(new byte[25] { 3, 47, 39, 32, 110, 25, 43, 44, 24, 39, 43, 57, 110, 11, 60, 60, 33, 60, 116, 110, 45, 33, 42, 43, 115 }, 78) + _0xc0a6f04a + _0xe1f5a500._0x3f4c2f3e(new byte[9] { 129, 204, 196, 210, 210, 192, 198, 196, 156 }, 161) + _0xb00cc45b);
            string _0xf7746977 = GetFailingUrl(_0x9cfd6917);
            if (string.IsNullOrEmpty(_0xf7746977) || IsAboutBlank(_0xf7746977))
                return;
            _ = _0x5974f6f2(_0xe1f5a500._0x3f4c2f3e(new byte[8] { 79, 78, 103, 93, 74, 74, 87, 74 }, 56));
            WLog(_0xe1f5a500._0x3f4c2f3e(new byte[45] { 157, 177, 185, 190, 240, 135, 181, 178, 134, 185, 181, 167, 240, 182, 177, 185, 188, 185, 190, 183, 240, 133, 130, 156, 240, 253, 238, 240, 191, 160, 181, 190, 240, 181, 168, 164, 181, 162, 190, 177, 188, 188, 169, 234, 240 }, 208) + _0xf7746977);
            StopCurrentFailedLoad(_0xebc3370d);
            _0xde6bb759(_0xf7746977);
        };
        _0x2b85491e.OnPageStarted += (_0xebc3370d, _0x2e841f27) =>
        {
            _0x1057781f = 0;
            if (_0x947cd640 && IsAboutBlank(_0x2e841f27))
            {
                WLog(_0xe1f5a500._0x3f4c2f3e(new byte[27] { 29, 63, 40, 58, 44, 63, 32, 109, 44, 47, 34, 56, 57, 119, 47, 33, 44, 35, 38, 109, 62, 57, 44, 63, 57, 40, 41 }, 77));
                return;
            }

            WLog(_0xe1f5a500._0x3f4c2f3e(new byte[29] { 149, 185, 177, 182, 248, 143, 189, 186, 142, 177, 189, 175, 248, 151, 182, 136, 185, 191, 189, 139, 172, 185, 170, 172, 189, 188, 226, 248, 243 }, 216) + (Time.realtimeSinceStartup - _0x35648777).ToString(_0xe1f5a500._0x3f4c2f3e(new byte[5] { 106, 116, 106, 106, 106 }, 90)) + _0xe1f5a500._0x3f4c2f3e(new byte[2] { 45, 126 }, 94) + _0x2e841f27);
            if (TryOpenExternalLikeChrome(_0x2e841f27))
            {
                StopCurrentFailedLoad(_0xebc3370d);
                return;
            }

            if (ContainsIgnoreCase(_0x2e841f27, _0xe1f5a500._0x3f4c2f3e(new byte[8] { 178, 191, 191, 183, 248, 183, 166, 166 }, 214)) || ContainsIgnoreCase(_0x2e841f27, _0xe1f5a500._0x3f4c2f3e(new byte[15] { 242, 227, 251, 172, 245, 235, 230, 229, 231, 246, 172, 224, 238, 237, 229 }, 130)) || _0x2e841f27.StartsWith(_0xe1f5a500._0x3f4c2f3e(new byte[25] { 119, 107, 107, 111, 108, 37, 48, 48, 125, 111, 120, 115, 112, 125, 126, 115, 121, 126, 105, 49, 115, 118, 105, 122, 48 }, 31), StringComparison.OrdinalIgnoreCase))
            {
                StopCurrentFailedLoad(_0xebc3370d);
                OpenUrlExternally(_0x2e841f27);
                return;
            }

            if (IsGoogleAuthFlowUrl(_0x2e841f27))
            {
                _0x0d907438(true);
                WLog(_0xe1f5a500._0x3f4c2f3e(new byte[41] { 160, 136, 136, 128, 139, 130, 199, 134, 146, 147, 143, 199, 129, 139, 136, 144, 199, 131, 130, 147, 130, 132, 147, 130, 131, 199, 202, 217, 199, 140, 130, 130, 151, 199, 145, 142, 148, 142, 133, 139, 130 }, 231));
                return;
            }

            _0xdd46ba7e = true;
            _0x0d907438(true);
            WLog(_0xe1f5a500._0x3f4c2f3e(new byte[43] { 119, 69, 66, 118, 73, 69, 87, 0, 76, 79, 65, 68, 73, 78, 71, 15, 82, 69, 68, 73, 82, 69, 67, 84, 73, 78, 71, 0, 13, 30, 0, 75, 69, 69, 80, 0, 86, 73, 83, 73, 66, 76, 69 }, 32));
        };
        _0x2b85491e.OnPageCommitted += (_0xebc3370d, _0x2e841f27) =>
        {
            if (_0x947cd640 && IsAboutBlank(_0x2e841f27))
                return;
            WLog(_0xe1f5a500._0x3f4c2f3e(new byte[31] { 68, 104, 96, 103, 41, 94, 108, 107, 95, 96, 108, 126, 41, 70, 103, 89, 104, 110, 108, 74, 102, 100, 100, 96, 125, 125, 108, 109, 51, 41, 34 }, 9) + (Time.realtimeSinceStartup - _0x35648777).ToString(_0xe1f5a500._0x3f4c2f3e(new byte[5] { 245, 235, 245, 245, 245 }, 197)) + _0xe1f5a500._0x3f4c2f3e(new byte[2] { 136, 219 }, 251) + _0x2e841f27);
            if (!firstLoadShown && IsHttpUrl(_0x2e841f27))
            {
                firstLoadShown = true;
                _0xdd46ba7e = false;
                _0x0d907438(false);
                _0xbe083810();
                _0xbd783a01();
                _0xebc3370d.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x5974f6f2(_0xe1f5a500._0x3f4c2f3e(new byte[9] { 159, 158, 183, 135, 152, 141, 134, 141, 140 }, 232));
                WLog(_0xe1f5a500._0x3f4c2f3e(new byte[39] { 159, 179, 187, 188, 242, 133, 183, 176, 132, 187, 183, 165, 242, 161, 186, 189, 165, 188, 242, 189, 188, 242, 177, 189, 191, 191, 187, 166, 166, 183, 182, 242, 177, 189, 188, 166, 183, 188, 166 }, 210));
            }
        };
        _0x2b85491e.OnPageProgressChanged += (_0xebc3370d, _0x0b963851) =>
        {
            if (_0x947cd640)
                return;
            if (!firstLoadShown && _0x0b963851 >= 0.65f)
            {
                firstLoadShown = true;
                _0xdd46ba7e = false;
                _0x0d907438(false);
                _0xbe083810();
                _0xbd783a01();
                _0xebc3370d.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x5974f6f2(_0xe1f5a500._0x3f4c2f3e(new byte[9] { 8, 9, 32, 16, 15, 26, 17, 26, 27 }, 127));
                WLog(_0xe1f5a500._0x3f4c2f3e(new byte[32] { 144, 188, 180, 179, 253, 138, 184, 191, 139, 180, 184, 170, 253, 174, 181, 178, 170, 179, 253, 191, 164, 253, 173, 175, 178, 186, 175, 184, 174, 174, 231, 253 }, 221) + _0x0b963851);
            }
        };
        _0x2b85491e.OnPageFinished += (_0xebc3370d, _0xc0a6f04a, _0x2e841f27) =>
        {
            if (_0x947cd640 && IsAboutBlank(_0x2e841f27))
            {
                _0x947cd640 = false;
                WLog(_0xe1f5a500._0x3f4c2f3e(new byte[28] { 147, 177, 166, 180, 162, 177, 174, 227, 162, 161, 172, 182, 183, 249, 161, 175, 162, 173, 168, 227, 165, 170, 173, 170, 176, 171, 166, 167 }, 195));
                return;
            }

            WLog(_0xe1f5a500._0x3f4c2f3e(new byte[24] { 88, 116, 124, 123, 53, 66, 112, 119, 67, 124, 112, 98, 53, 83, 124, 123, 124, 102, 125, 112, 113, 47, 53, 62 }, 21) + (Time.realtimeSinceStartup - _0x35648777).ToString(_0xe1f5a500._0x3f4c2f3e(new byte[5] { 95, 65, 95, 95, 95 }, 111)) + _0xe1f5a500._0x3f4c2f3e(new byte[7] { 196, 151, 212, 216, 211, 210, 138 }, 183) + _0xc0a6f04a + _0xe1f5a500._0x3f4c2f3e(new byte[5] { 54, 99, 100, 122, 43 }, 22) + _0x2e841f27);
            if (!firstLoadShown)
            {
                firstLoadShown = true;
                _0xdd46ba7e = false;
                _0x0d907438(false);
                _0xbe083810();
                _0xbd783a01();
                _0xebc3370d.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x5974f6f2(_0xe1f5a500._0x3f4c2f3e(new byte[9] { 172, 173, 132, 180, 171, 190, 181, 190, 191 }, 219));
                WLog(_0xe1f5a500._0x3f4c2f3e(new byte[33] { 47, 3, 11, 12, 66, 53, 7, 0, 52, 11, 7, 21, 66, 4, 11, 16, 17, 22, 66, 14, 13, 3, 6, 66, 1, 13, 15, 18, 14, 7, 22, 7, 6 }, 98));
            }
            else if (_0xdd46ba7e)
            {
                _0xdd46ba7e = false;
                _0x0d907438(false);
                _0xebc3370d.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                WLog(_0xe1f5a500._0x3f4c2f3e(new byte[40] { 18, 62, 54, 49, 127, 8, 58, 61, 9, 54, 58, 40, 127, 12, 55, 48, 40, 127, 62, 57, 43, 58, 45, 127, 51, 48, 62, 59, 54, 49, 56, 127, 57, 54, 49, 54, 44, 55, 58, 59 }, 95));
            }
            else
            {
                _0x0d907438(false);
            }

            if (_0xa3e2578e && !IsGoogleAuthFlowUrl(_0x2e841f27) && !IsGoogleAuthFlowUrl(_0x2e841f27))
            {
                WLog(_0xe1f5a500._0x3f4c2f3e(new byte[48] { 168, 128, 128, 136, 131, 138, 207, 142, 154, 155, 135, 207, 156, 138, 138, 130, 156, 207, 137, 134, 129, 134, 156, 135, 138, 139, 207, 194, 209, 207, 157, 138, 156, 155, 128, 157, 138, 207, 139, 138, 137, 142, 154, 131, 155, 207, 186, 174 }, 239));
                _0xa3e2578e = false;
                _0x476beb1b.SetUserAgent("");
            }
        };
        _0x2b85491e.OnShouldClose += _0xebc3370d =>
        {
            WLog(_0xe1f5a500._0x3f4c2f3e(new byte[41] { 14, 1, 48, 38, 33, 8, 117, 24, 52, 60, 59, 117, 2, 48, 55, 3, 60, 48, 34, 117, 26, 59, 6, 61, 58, 32, 57, 49, 22, 57, 58, 38, 48, 117, 60, 59, 35, 58, 62, 48, 49 }, 85));
            _0xf5801677();
            return false;
        };
        // POPUP HANDLING LOGIC
        _0x2b85491e.SetPopupPageEventEnabled(true);
        bool _0x0b2eafe5 = false;
        bool _0x1258102c = false;
        _0x2b85491e.OnMultipleWindowOpened += (_0xebc3370d, _0x2edc2934) =>
        {
            _0xebc3370d.ScrollTo(0, 0, false);
            WLog(_0xe1f5a500._0x3f4c2f3e(new byte[43] { 206, 193, 240, 230, 225, 200, 181, 216, 244, 252, 251, 181, 194, 240, 247, 195, 252, 240, 226, 181, 216, 224, 249, 225, 252, 229, 249, 240, 194, 252, 251, 241, 250, 226, 181, 218, 229, 240, 251, 240, 241, 175, 181 }, 149) + _0x2edc2934);
            var _0x417494e1 = _0x2b85491e.GetPopupWindow(_0x2edc2934);
            if (_0x417494e1 == null)
                return;
            _0x7695dc33.Add(_0x417494e1);
            Debug.Log($"[Test] Popup ID: {_0x417494e1.Id}");
            _0x417494e1.OnPageStarted += (_0xcfd4137c, _0x2e841f27) =>
            {
                WLog(_0xe1f5a500._0x3f4c2f3e(new byte[36] { 63, 48, 1, 23, 16, 57, 68, 52, 11, 20, 17, 20, 68, 51, 1, 6, 50, 13, 1, 19, 68, 43, 10, 52, 5, 3, 1, 55, 16, 5, 22, 16, 1, 0, 94, 68 }, 100) + _0x2e841f27);
                _0x1057781f = 0;
                if (string.IsNullOrEmpty(_0x2e841f27) || IsAboutBlank(_0x2e841f27))
                    return;
                if (IsGoogleAuthFlowUrl(_0x2e841f27))
                {
                    WLog(_0xe1f5a500._0x3f4c2f3e(new byte[57] { 225, 238, 223, 201, 206, 231, 154, 234, 213, 202, 207, 202, 154, 253, 213, 213, 221, 214, 223, 154, 219, 207, 206, 210, 154, 220, 214, 213, 205, 154, 151, 132, 154, 201, 202, 213, 213, 220, 154, 253, 213, 213, 221, 214, 223, 154, 249, 210, 200, 213, 215, 223, 154, 239, 251, 128, 154 }, 186) + _0x2e841f27);
                    _0x0b2eafe5 = false;
                    _0xe10fad14();
                    if (_0xcfd4137c != null && _0xcfd4137c.IsAlive)
                        _0xcfd4137c.EvaluateJavaScript(_0x005239bf());
                    return;
                }

                if (_0x476beb1b == null)
                    return;
                if (!_0x0b2eafe5)
                {
                    _0x0b2eafe5 = true;
                    _0x476beb1b.SetUserAgent(WindowsDesktopUserAgent);
                    WLog(_0xe1f5a500._0x3f4c2f3e(new byte[39] { 107, 100, 85, 67, 68, 109, 16, 96, 95, 64, 69, 64, 16, 81, 64, 64, 92, 73, 16, 103, 89, 94, 84, 95, 71, 67, 16, 84, 85, 67, 91, 68, 95, 64, 16, 101, 113, 10, 16 }, 48) + _0x2e841f27);
                }

                if (_0xcfd4137c != null && _0xcfd4137c.IsAlive)
                    _0xcfd4137c.EvaluateJavaScript(_0xd43d82ae());
                if (!_0x1258102c && _0xcfd4137c != null && _0xcfd4137c.IsAlive && IsHttpUrl(_0x2e841f27))
                {
                    _0x1258102c = true;
                }
            };
            _0x417494e1.OnPageFinished += (_0xcfd4137c, _0x9cfd6917) =>
            {
                string _0x9ce8430a = _0x9cfd6917 != null ? _0x9cfd6917.data : string.Empty;
                WLog(_0xe1f5a500._0x3f4c2f3e(new byte[35] { 127, 112, 65, 87, 80, 121, 4, 116, 75, 84, 81, 84, 4, 115, 65, 70, 114, 77, 65, 83, 4, 98, 77, 74, 77, 87, 76, 65, 64, 30, 4, 81, 86, 72, 25 }, 36) + _0x9ce8430a);
                if (_0xcfd4137c == null || !_0xcfd4137c.IsAlive)
                    return;
                if (IsGoogleAuthFlowUrl(_0x9ce8430a))
                {
                    _0xe10fad14();
                    _0xcfd4137c.EvaluateJavaScript(_0x005239bf());
                    return;
                }

                if (!_0x0b2eafe5)
                    return;
                _0xcfd4137c.EvaluateJavaScript(_0xd43d82ae());
            };
        };
        _0x2b85491e.OnMultipleWindowClosed += (_0xebc3370d, _0x2edc2934) =>
        {
            _0x7695dc33.RemoveAll(_0xbfdfeabb => _0xbfdfeabb == null || _0xbfdfeabb.Id == _0x2edc2934 || !_0xbfdfeabb.IsAlive);
            _0x0d907438(false);
            if (_0x7695dc33.Count == 0 && _0x476beb1b != null)
            {
                _0x0b2eafe5 = false;
                _0x1258102c = false;
                _0x2ee38af9();
            }

            WLog(_0xe1f5a500._0x3f4c2f3e(new byte[43] { 222, 209, 224, 246, 241, 216, 165, 200, 228, 236, 235, 165, 210, 224, 231, 211, 236, 224, 242, 165, 200, 240, 233, 241, 236, 245, 233, 224, 210, 236, 235, 225, 234, 242, 165, 198, 233, 234, 246, 224, 225, 191, 165 }, 133) + _0x2edc2934);
        };
        _0x2b85491e.RegisterOnRequestMediaCapturePermission(_0x7ac10f39 =>
        {
            if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
            {
                Permission.RequestUserPermission(Permission.Camera);
                return UniWebViewMediaCapturePermissionDecision.Prompt;
            }

            return UniWebViewMediaCapturePermissionDecision.Grant;
        });
    }

    internal string _0x7ad84d3f(string _0x8e4b67c6)
    {
        int _0xecdc5e60 = _0x8e4b67c6.IndexOf(_0xe1f5a500._0x3f4c2f3e(new byte[3] { 77, 64, 25 }, 36), StringComparison.OrdinalIgnoreCase);
        if (_0xecdc5e60 < 0)
            return null;
        string _0xe43ba06c = _0x8e4b67c6.Substring(_0xecdc5e60 + 3);
        int _0x3ea3716d = _0xe43ba06c.IndexOf('&');
        return _0x3ea3716d >= 0 ? _0xe43ba06c.Substring(0, _0x3ea3716d) : _0xe43ba06c;
    }

    private string _0xd39d4dd2;
    private void WLog(string _0x2c74dd65)
    {
#if B_LOGS
        {
            Debug.Log(_0xe1f5a500._0x3f4c2f3e(new byte[7] { 250, 245, 196, 210, 213, 252, 129 }, 161) + _0x2c74dd65);
        }
#endif
    }

    private Action _0xd27a23cb;
    internal void Update()
    {
        if (_0x476beb1b == null)
            return;
        if (_0xb6f89f72())
            _0xf5801677();
        if (!isApplicationFocus || isApplicationPause)
            return;
        _0xbd783a01();
        if (_0xad233ed0 && _0xd74deb8e != null)
            _0xd74deb8e.Rotate(0f, 0f, -360f * Time.deltaTime);
    }

    internal bool IsAboutBlank(string _0x8237a6b3)
    {
        if (string.IsNullOrEmpty(_0x8237a6b3))
            return false;
        return _0x8237a6b3.StartsWith(_0xe1f5a500._0x3f4c2f3e(new byte[11] { 179, 176, 189, 167, 166, 232, 176, 190, 179, 188, 185 }, 210), StringComparison.OrdinalIgnoreCase);
    }

    private async Task<string> _0x70af4a9e(int _0xfe3b14a6 = 5, int _0x3fa8e531 = 500)
    {
        try
        {
            List<EntityData> _0x51a13943 = new List<EntityData>();
            int _0x1b8067bd = 0;
            do
            {
                _0x51a13943 = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0xe1f5a500._0x3f4c2f3e(new byte[8] { 39, 59, 54, 46, 50, 37, 30, 51 }, 87), _0xe61dc0c7, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0xe61dc0c7 }), new QueryOptions())).ToList();
                await Task.Delay(_0x3fa8e531);
            }
            while (_0x51a13943.Count == 0 && _0x1b8067bd++ < _0xfe3b14a6);
            {
#if B_LOGS
                {
                    Debug.Log(_0xe1f5a500._0x3f4c2f3e(new byte[33] { 223, 208, 225, 247, 240, 217, 164, 215, 229, 242, 225, 224, 164, 200, 237, 234, 239, 164, 213, 241, 225, 246, 253, 164, 246, 225, 247, 241, 232, 240, 247, 190, 164 }, 132) + JsonConvert.SerializeObject(_0x51a13943, Formatting.Indented));
                }
#endif
            }

            {
#if B_LOGS
                {
                    Debug.Log(_0xe1f5a500._0x3f4c2f3e(new byte[39] { 170, 165, 148, 130, 133, 172, 209, 162, 144, 135, 148, 149, 209, 189, 152, 159, 154, 209, 160, 132, 148, 131, 136, 209, 131, 148, 130, 132, 157, 133, 130, 209, 146, 158, 132, 159, 133, 203, 209 }, 241) + _0x51a13943.Count);
                }
#endif
            }

            var _0xa9a88845 = _0x51a13943.SelectMany(_0xb88be86c => _0xb88be86c.Data).FirstOrDefault(_0x724c914f => _0x724c914f.Key == _0xe61dc0c7)?.Value.GetAs<string>() ?? string.Empty;
            _0xa9a88845 = Decrypt(_0xa9a88845, _0xe61dc0c7);
            {
#if B_LOGS
                {
                    Debug.Log(_0xe1f5a500._0x3f4c2f3e(new byte[24] { 43, 36, 21, 3, 4, 45, 80, 60, 31, 17, 20, 80, 3, 17, 6, 21, 20, 80, 28, 25, 30, 27, 74, 80 }, 112) + _0xa9a88845);
                }
#endif
            }

            return _0xa9a88845;
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0xe1f5a500._0x3f4c2f3e(new byte[39] { 93, 82, 99, 117, 114, 91, 38, 65, 99, 114, 38, 105, 116, 38, 118, 103, 116, 117, 99, 38, 117, 103, 112, 99, 98, 38, 106, 111, 104, 109, 38, 96, 103, 111, 106, 99, 98, 60, 38 }, 6) + ex.Message);
                }
#endif
            }

            return string.Empty;
        }
    }

    internal bool _0x37b7754f(string _0x72bffc66)
    {
        return _0x72bffc66.StartsWith(_0xe1f5a500._0x3f4c2f3e(new byte[9] { 88, 84, 71, 94, 80, 65, 15, 26, 26 }, 53), StringComparison.OrdinalIgnoreCase) || _0x72bffc66.StartsWith(_0xe1f5a500._0x3f4c2f3e(new byte[24] { 183, 171, 171, 175, 172, 229, 240, 240, 175, 179, 190, 166, 241, 184, 176, 176, 184, 179, 186, 241, 188, 176, 178, 240 }, 223), StringComparison.OrdinalIgnoreCase) || _0x72bffc66.StartsWith(_0xe1f5a500._0x3f4c2f3e(new byte[23] { 121, 101, 101, 97, 43, 62, 62, 97, 125, 112, 104, 63, 118, 126, 126, 118, 125, 116, 63, 114, 126, 124, 62 }, 17), StringComparison.OrdinalIgnoreCase);
    }

    private async Task<bool> _0xfa575726()
    {
        _0x36fa1fc7.Instance?._0x2ae73bba();
        PushNotificationsService.Instance.OnRemoteNotificationReceived += (_0xd1df342f) =>
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0xe1f5a500._0x3f4c2f3e(new byte[32] { 220, 211, 226, 244, 243, 218, 167, 210, 233, 238, 243, 254, 167, 215, 242, 244, 239, 167, 201, 232, 243, 238, 225, 238, 228, 230, 243, 238, 232, 233, 189, 167 }, 135) + string.Join(_0xe1f5a500._0x3f4c2f3e(new byte[1] { 12 }, 5), _0xd1df342f));
                }
#endif
            }
        };
        try
        {
            _0x6edbf36e = await PushNotificationsService.Instance.RegisterForPushNotificationsAsync();
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0xe1f5a500._0x3f4c2f3e(new byte[31] { 173, 162, 147, 133, 130, 171, 214, 176, 151, 159, 154, 147, 146, 214, 130, 153, 214, 145, 147, 130, 214, 134, 131, 133, 158, 214, 130, 153, 157, 147, 152 }, 246));
                }
#endif
            }

            _0x6edbf36e = "";
        }

        _0xcfb9c503 = !string.IsNullOrEmpty(_0x6edbf36e);
        _0x367381fa = _0xd138a518();
        {
#if B_LOGS
            Debug.Log(_0xe1f5a500._0x3f4c2f3e(new byte[25] { 135, 136, 185, 175, 168, 129, 252, 137, 178, 181, 168, 165, 252, 140, 169, 175, 180, 252, 136, 179, 183, 185, 178, 230, 252 }, 220) + _0x6edbf36e);
#endif
        }

        _0x36fa1fc7.Instance?._0xbd171668();
        return false;
    }

    private string _0x72852a8f = "";
    internal void _0xbd783a01()
    {
        Rect _0x2463a179 = Screen.safeArea;
        Vector2 _0x8c923ec6 = new Vector2(Screen.width, Screen.height);
        if (_0x2463a179 == lastSafe && _0x8c923ec6 == lastSize)
            return;
        // Apply manual padding
        _0x2463a179.xMin += _0xf0d24033;
        _0x2463a179.xMax -= _0x2b4d3a42;
        _0x2463a179.yMin += _0xd4b2d30f;
        _0x2463a179.yMax -= _0x5dac63f7;
        // Convert Unity safe area -> native WebView frame
        Rect _0x13b0f011 = new Rect(_0x2463a179.x, _0x8c923ec6.y - _0x2463a179.y - _0x2463a179.height, // Y flip for native coordinate system
 _0x2463a179.width, _0x2463a179.height);
        _0x476beb1b.Frame = _0x13b0f011;
        lastSafe = Screen.safeArea;
        lastSize = _0x8c923ec6;
    }

    // WEB VIEW LOGIC
    public bool _0x0bbd3ce9 { get; set; }

    private string GetFailingUrl(UniWebViewNativeResultPayload _0x26e03280)
    {
        if (_0x26e03280 == null || _0x26e03280.Extra == null)
            return null;
        object _0x27221266;
        if (!_0x26e03280.Extra.TryGetValue(UniWebViewNativeResultPayload.ExtraFailingURLKey, out _0x27221266))
            return null;
        return _0x27221266 as string;
    }

    private void _0x5d8b9677(string _0x09f6fab6)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0xe1f5a500._0x3f4c2f3e(new byte[34] { 237, 226, 211, 197, 194, 235, 150, 240, 211, 194, 213, 222, 150, 243, 206, 194, 196, 215, 150, 230, 195, 197, 222, 150, 242, 215, 194, 215, 150, 228, 215, 193, 140, 150 }, 182) + _0x09f6fab6);
#endif
            }
        }

        var _0xb9a1a81f = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x09f6fab6);
        StartCoroutine(_0x158b6fba(_0xb9a1a81f));
    }

    // WS_SOURCE MONO
    public static _0x03d625e4 _0xd7248771 { get; private set; }

    private string _0x82ac796b()
    {
        string _0xb07385f6 = _0xe1f5a500._0x3f4c2f3e(new byte[62] { 156, 159, 158, 153, 152, 155, 154, 149, 148, 151, 150, 145, 144, 147, 146, 141, 140, 143, 142, 137, 136, 139, 138, 133, 132, 135, 188, 191, 190, 185, 184, 187, 186, 181, 180, 183, 182, 177, 176, 179, 178, 173, 172, 175, 174, 169, 168, 171, 170, 165, 164, 167, 205, 204, 207, 206, 201, 200, 203, 202, 197, 196 }, 253);
        System.Random _0x7201b52c = new System.Random();
        int _0xc900ce20 = _0x7201b52c.Next(8, 16);
        return new string (Enumerable.Repeat(_0xb07385f6, _0xc900ce20).Select(_0x97cf6b40 => _0x97cf6b40[_0x7201b52c.Next(_0x97cf6b40.Length)]).ToArray());
    }

    internal bool isDestroyedForce = false;
}

internal static class _0xe1f5a500
{
    internal static string _0x3f4c2f3e(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}