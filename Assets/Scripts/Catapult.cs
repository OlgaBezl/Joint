using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Catapult : MonoBehaviour
{
    [SerializeField] private KeyboardInput _input;
    [SerializeField] private float _force = 500f;
    [SerializeField] private ProjectileSpawner _projectileSpawner;

    private Rigidbody _rigidbody;
    private Quaternion _startRotation;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _startRotation = transform.rotation;
        Reset();
    }

    private void OnEnable()
    {
        _input.EKeyDown += Move;
        _input.QKeyDown += Reset;
    }

    private void OnDisable()
    {
        _input.EKeyDown -= Move;
        _input.QKeyDown -= Reset;
    }

    private void Move()
    {
        _rigidbody.AddForce(transform.up * _force);
    }

    private void Reset()
    {
        transform.rotation = _startRotation;
        _projectileSpawner.Spawn();

    }
}
