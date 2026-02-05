using UnityEngine;

public class Enemy : MonoBehaviour
{
    float       _speed;
    Transform   _target;

    Vector3     _dir;
    public void Construct(Transform target, float speed)
    {
        _target = target;
        _speed  = speed;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if문보단 업데이트를 꺼버리는게 더 좋은 방향
        if (_target == null) return;

        _dir = (_target.position - transform.position).normalized;
    }
    private void FixedUpdate()
    {
        ToTarget();
    }
    private void ToTarget()
    {
        if (_target == null) return;
        transform.position +=
            _dir * _speed * Time.fixedDeltaTime;
    }
}
