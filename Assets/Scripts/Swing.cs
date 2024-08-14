using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Swing : MonoBehaviour
{
    [SerializeField] private KeyboardInput _input;
    [SerializeField] private float _force = 150f;

    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        _input.SpaceKeyDown += Move;
    }

    private void OnDisable()
    {
        _input.SpaceKeyDown -= Move;
    }

    private void Move()
    {
        _rigidbody.AddForce(transform.forward * _force);
    }
}
