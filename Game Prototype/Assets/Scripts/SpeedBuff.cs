using UnityEngine;

public class SpeedBuff : Buff
{
    [SerializeField] private int _speedPoint;
    [SerializeField] private int _duration;
    protected override void TakeEffect()
    {
        PlayerMovement playerMovement = Player.GetComponent<PlayerMovement>();
        StartCoroutine(playerMovement.IncreaseSpeed(_speedPoint, _duration));
    }
}
