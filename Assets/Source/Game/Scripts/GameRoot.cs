using System;
using Enemies.Source.Modules.Enemies.Scripts;
using Movement.Source.Modules.Movement.Scripts;
using UnityEngine;

namespace NameOfGame.Source.Game.Scripts
{
    public class GameRoot : MonoBehaviour
    {
        [SerializeField] private MovementInput _movementInput;
        [SerializeField] private WeaponInput _weaponInput;
        [SerializeField] private EnemyFactory _enemyFactory;

        private void Start()
        {
            _movementInput.Activate();
            _weaponInput.Activate();
            _enemyFactory.StartSpawn();
        }
    }
}
