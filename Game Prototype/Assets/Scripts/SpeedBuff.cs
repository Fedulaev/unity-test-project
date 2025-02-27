using UnityEngine;

public class SpeedBuff : Buff
{
    [SerializeField] private int _speedBonus;
    [SerializeField] private int _duration;
    protected override void TakeEffect()
    {
        PlayerMovement playerMovement = _player.GetComponent<PlayerMovement>();
        StartCoroutine(playerMovement.IncreaseSpeed(_speedBonus, _duration));
    }
}
