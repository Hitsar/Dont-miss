using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    [SerializeField] private CoinTransfer _coinTransfer;
    public void Next()
    {
        _coinTransfer.Transfer();
    }

    public void ExitMenu()
    {
        SceneManager.LoadScene(0);
    }
}
