using Shooting.Source.Modules.Shooting.Scripts;
using UnityEngine;

public class WeaponInput : MonoBehaviour
{
    [SerializeField] private Weapon _weapon;
    private bool _active;
    private const string Fire = "Fire1";

    private void Update()
    {
        if (_active == false)
            return;

        if (Input.GetAxisRaw(Fire) > 0f)
        {
            _weapon.Shoot();
        }
    }

    public void Activate() => _active = true;
    public void Deactivate() => _active = false;
}