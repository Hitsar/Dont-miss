using System.Runtime.InteropServices;
using UnityEngine;

public class LoseZone : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void ShowAdv();

    [SerializeField] private LoseMenu _loseMenu;
    [SerializeField] private AddPoint _addPoint;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out CoinControll coin))
        {
            Lose();
        }
    }

    private void Lose()
    {
        _addPoint.SaveProgress();
        _loseMenu.gameObject.SetActive(true);
        ShowAdv();
    }
}
