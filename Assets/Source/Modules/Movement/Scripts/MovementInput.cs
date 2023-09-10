using UnityEngine;

namespace Movement.Source.Modules.Movement.Scripts
{
    public class MovementInput : MonoBehaviour
    {
        [SerializeField] private CharacterMovement _movement;
        private const string Horizontal = "Horizontal";
        private const string Vertical = "Vertical";
        private bool _active;

        private void Update()
        {
            if (_active == false)
                return;
            
            Vector3 direction = new Vector3(Input.GetAxisRaw(Horizontal), 0f, Input.GetAxisRaw(Vertical));
            _movement.Move(direction);
        }

        public void Activate()
        {
            _active = true;
        }

        public void Deactivate()
        {
            _active = false;
        }
    }
}