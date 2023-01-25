using UnityEngine;

public class CoinControll : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Rigidbody _rigidbody;

    [SerializeField] private Vector3 _point1;
    [SerializeField] private Vector3 _point2;

    private Vector2 _sideMovement;

    private void Start()
    {
        _sideMovement = Vector2.left;
    }

    private void Update()
    {
        CoinDirection();
        _rigidbody.velocity = _sideMovement * _speed;

        if (Input.GetMouseButtonDown(0))
            CoinFall();
    }

    private void CoinFall()
    {
        _sideMovement = Vector2.down;
    }

    private void CoinDirection()
    {
        if (transform.position.x <= _point1.x)
        {
            _sideMovement = Vector2.right;
        }
        else if (transform.position.x >= _point2.x)
        {
            _sideMovement = Vector2.left;
        }
    }
}