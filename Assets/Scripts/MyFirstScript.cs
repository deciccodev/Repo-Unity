using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private Vector3 _direction;
    
    [SerializeField] private GameObject _prefab;
    [SerializeField] private Transform _spawnPoint;

    void Update()
    {
        _direction = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            _direction += Vector3.forward;
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            _direction += Vector3.left;
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            _direction += Vector3.back;
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            _direction += Vector3.right;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnPrefab();
        }
    }

    void FixedUpdate()
    {
        _rigidbody.MovePosition(_rigidbody.position + _direction * _speed * Time.fixedDeltaTime);
    }

    private void SpawnPrefab()
    {
        GameObject prefabIstantiated = Instantiate(_prefab, _spawnPoint.position, Quaternion.identity);
    }
}
