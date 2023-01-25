using UnityEngine;

public class CoinTransfer : MonoBehaviour
{
    [SerializeField] private Transform _point1;
    [SerializeField] private Transform _point2;

    public void Transfer()
    {
        int rn = Random.Range(0, 2);
        if (rn == 0)
            transform.position = _point1.position;
        else
            transform.position = _point2.position;
    }
}
