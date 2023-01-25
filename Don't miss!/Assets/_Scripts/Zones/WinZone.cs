using System.Runtime.InteropServices;
using UnityEngine;

public class WinZone : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void ShowAdv();

    [SerializeField] private WinMenu _winMenu;
    [SerializeField] private AddPoint _addPoint;

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
        ShowAdv();
    }
}
