using System;
using UnityEngine;

namespace Movement.Source.Modules.Movement.Scripts
{
    public class MovementTest : MonoBehaviour
    {
        [SerializeField] private MovementInput _movementInput;

        private void Awake()
        {
            _movementInput.Activate();
        }
    }
}
