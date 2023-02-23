using System.Runtime.InteropServices;
using UnityEngine;

public class LoseZone : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void ShowAdv();

    private LoseMenu _loseMenu;
    private AddPoint _addPoint;
    private Animations _animations;

    private void Start()
    {
        _loseMenu = FindObjectOfType<LoseMenu>(true).GetComponent<LoseMenu>();
        _addPoint = FindObjectOfType<AddPoint>().GetComponent<AddPoint>();
        _animations = FindObjectOfType<Animations>().GetComponent<Animations>();
    }

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
        _animations.LozeMenuAnimatoin();
        //ShowAdv();
    }
}
