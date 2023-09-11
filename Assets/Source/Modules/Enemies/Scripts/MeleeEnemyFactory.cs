using UnityEngine;
using UnityEngine.Serialization;

namespace Enemies.Source.Modules.Enemies.Scripts
{
    internal class MeleeEnemyFactory : EnemyFactory
    {
        [SerializeField] private Enemy _enemy;
        [SerializeField] private Transform _spawnPoint;
        protected override Enemy Spawn()
        {
            return Instantiate(_enemy, _spawnPoint.position, _spawnPoint.rotation);
        }
    }
}