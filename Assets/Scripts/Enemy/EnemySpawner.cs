using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] Transform  _target;
    [SerializeField] Enemy      _enemyPrefab;
    private float _spawnTimer = 1.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _spawnTimer -= Time.deltaTime;
        if (_spawnTimer <= 0.0f)
        {
            _spawnTimer += 1.0f;
            SpawnEnemy();
        }
    }
    public void SpawnEnemy()
    {
        Debug.Log("Spawn Enemy");
        var enemy = Instantiate(_enemyPrefab, transform.position, Quaternion.identity);
        enemy.Construct(_target, 1.0f);
    }
}
