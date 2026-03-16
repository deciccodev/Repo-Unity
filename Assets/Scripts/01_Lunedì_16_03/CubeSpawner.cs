using Unity.VisualScripting;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private float moveAmount;
    [SerializeField] private int time;
    private Vector3 _resetSpawnPoint;
    private int _cubeCounter = 0;
    public int MaxSpawn = 6;

    void Awake()
    {
        Debug.Log($"Awake(), valore contatore spawns: {_cubeCounter}");
    }

    void OnEnable()
    {
        Debug.Log($"OnEnable(), valore contatore spawns: {_cubeCounter}");
    }

    void Start() 
    {
        Debug.Log($"Start(), valore contatore spawns: {_cubeCounter}");
        _resetSpawnPoint = _spawnPoint.position;
    }

    void Update()
    {
        Debug.Log($"Update(), valore contatore spawns: {_cubeCounter}");
        Debug.Log($"Update(), posizione spwan point: {_spawnPoint.position}");
        if (Input.GetKey(KeyCode.F))
        {
            SpawnPrefab();
            _spawnPoint.position += new Vector3(moveAmount, 0, 0);
            
            if (_cubeCounter >= MaxSpawn)
            {
                ResetPosition();
            }
        }
    }

    void FixedUpdate()
    {
        Debug.Log($"FixedUpdate(), valore contatore spawns: {_cubeCounter}");
    }

    void LateUpdate()
    {
        Debug.Log($"LateUpdate(), valore contatore spawns: {_cubeCounter}");
    }

    void OnDisable()
    {
        Debug.Log($"OnDisable(), valore contatore spawns: {_cubeCounter}");
    }

    void OnDestroy()
    {
        Debug.Log($"OnDestroy(), valore contatore spawns: {_cubeCounter}");
    }

    private void SpawnPrefab()
    {
        if (_cubeCounter < 3)
        {
            GameObject prefabIstantiated = Instantiate(_prefab, _spawnPoint.position, Quaternion.identity);
            prefabIstantiated.GetComponent<MeshRenderer>().material.color = Color.green;
            Destroy(prefabIstantiated, time);
            _cubeCounter ++;
        }
        else if (_cubeCounter < 6)
        {
            GameObject prefabIstantiated = Instantiate(_prefab, _spawnPoint.position, Quaternion.identity);
            prefabIstantiated.GetComponent<MeshRenderer>().material.color = Color.yellow;
            Destroy(prefabIstantiated, time);
            _cubeCounter ++;
        }
        /*else if (_cubeCounter == MaxSpawn)
            Destroy(gameObject, time);*/
    }

    private void ResetPosition()
    {
        _spawnPoint.position = _resetSpawnPoint;
        _cubeCounter = 0;
    }
}
