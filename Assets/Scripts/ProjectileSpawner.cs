using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{
    [SerializeField] private Projectile _projectile;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private Transform _parent;

    public void Spawn()
    {
        Instantiate(_projectile, _spawnPoint.position, _spawnPoint.rotation, _parent);
    }
}
