using UnityEngine;

public class SpeedBuff : Buff
{
    [SerializeField] private int _speedPoint;
    protected override void TakeEffect()
    {
        playerMovement.IncreaseSpeed(_speedPoint);
    }
}
