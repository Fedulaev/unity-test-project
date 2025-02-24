using UnityEngine;
public class JoystickMovement : PlayerMovement
{
    [SerializeField] private FixedJoystick _joystick;
    protected override void Move()
    {
        _rb.linearVelocity = new Vector2(_joystick.Horizontal, _joystick.Vertical).normalized * _speed;
    }
}
