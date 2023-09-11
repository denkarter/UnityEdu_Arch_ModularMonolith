using System;
using Movement.Source.Modules.Movement.Scripts;
using UnityEngine;

namespace NameOfGame.Source.Game.Scripts
{
    public class GameRoot : MonoBehaviour
    {
        [SerializeField] private MovementInput _movementInput;
        [SerializeField] private WeaponInput _weaponInput;

        private void Start()
        {
            _movementInput.Activate();
            _weaponInput.Activate();
        }
    }
}
