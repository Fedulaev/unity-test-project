using UnityEngine;

public class GyroscopeMovement : PlayerMovement
{
    private void Start()
    {
        Input.gyro.enabled = true;
    }
    protected override void Move()
    {
        float X = Input.gyro.attitude.x;
        float Y = Input.gyro.attitude.y;
        print(X + " " + Y);
        transform.Translate(new Vector3(X, Y) * _speed);
    }
}
