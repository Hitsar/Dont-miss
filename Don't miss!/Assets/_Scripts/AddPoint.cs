using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

public class AddPoint : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void SetToLeaderboard(int value);

    [SerializeField] private TextMeshProUGUI _text;
    private int _point;

    public void PointAdd()
    {
        _point++;
        _text.text = _point.ToString();
        SaveProgress();
    }

    public void SaveProgress()
    {
        if (Progress.Instance.PlayerInfo._point < _point)
        {
            Progress.Instance.PlayerInfo._point = _point;
            SetToLeaderboard(_point);
        }
    }
}
