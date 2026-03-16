using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{   
    [SerializeField] private GameObject _prefab;
    [SerializeField] private Transform _spawnPoint;

    private void SpawnPrefab()
    {
        GameObject prefabIstantiated = Instantiate(_prefab, _spawnPoint.position, Quaternion.identity);
    }
}
