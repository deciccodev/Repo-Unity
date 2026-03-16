using UnityEngine;

public class CubeMover : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private Vector3 _direction;
    
    [SerializeField] private GameObject _cube;

    void Update()
    {
        _direction = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            _direction += Vector3.forward;
            Debug.Log("Direzione: " + _direction);
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            _direction += Vector3.left;
            Debug.Log("Direzione: " + _direction);
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            _direction += Vector3.back;
            Debug.Log("Direzione: " + _direction);
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            _direction += Vector3.right;
            Debug.Log("Direzione: " + _direction);
        }
    }

    void FixedUpdate()
    {
        _rigidbody.MovePosition(_rigidbody.position + _direction * _speed * Time.fixedDeltaTime);
    }
}
