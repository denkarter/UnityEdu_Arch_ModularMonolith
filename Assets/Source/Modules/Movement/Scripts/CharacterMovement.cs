using UnityEngine;

namespace Movement.Source.Modules.Movement.Scripts
{
    internal class CharacterMovement : MonoBehaviour
    {
        [SerializeField] private float _speed;
        
        internal void Move(Vector3 direction)
        {
            transform.Translate(_speed * direction * Time.deltaTime);    
        }
    }
}
