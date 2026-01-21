using UnityEngine;

public sealed class PlayerRoot : MonoBehaviour
{
    [SerializeField] private InputReader    _input;
    [SerializeField] private UnitController _unit;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _unit.Construct(_input);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
