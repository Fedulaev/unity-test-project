using UnityEngine;

public class GyroscopeMovement : PlayerMovement
{
    private void Start()
    {
        if(SystemInfo.supportsGyroscope)
            Input.gyro.enabled = true;
    }
    protected override void Move()
    {
        float HorizontalInput = Input.gyro.attitude.x;
        float VerticalInput = Input.gyro.attitude.y;
        transform.Translate(new Vector3(HorizontalInput, VerticalInput) * _speed);
    }
}
