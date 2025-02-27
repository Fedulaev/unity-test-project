using UnityEngine;
public class HealBuff : Buff
{
    [SerializeField] private int _healAmount;
    protected override void TakeEffect()
    {
        PlayerHealth playerHealth = _player.GetComponent<PlayerHealth>();
        playerHealth.Heal(_healAmount);
    }
}
