using System.Runtime.InteropServices;
using UnityEngine;

public class WinZone : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void ShowAdv();

    private WinMenu _winMenu;
    private AddPoint _addPoint;
    private Animations _animations;

    private void Start()
    {
        _winMenu = FindObjectOfType<WinMenu>(true).GetComponent<WinMenu>();
        _addPoint = FindObjectOfType<AddPoint>().GetComponent<AddPoint>();
        _animations = FindObjectOfType<Animations>().GetComponent<Animations>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out CoinControll coin))
        {
            Win(); 
        }
    }

    private void Win()
    {
        _addPoint.PointAdd();
        _winMenu.gameObject.SetActive(true);
        _animations.WinMenuAnimatoin();
        ShowAdv();
    }
}
