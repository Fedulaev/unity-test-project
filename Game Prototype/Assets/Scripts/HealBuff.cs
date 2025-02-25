using UnityEngine;
public class HealBuff : Buff
{
    [SerializeField] private int _healPoint;
    protected override void TakeEffect()
    {
        PlayerHealth playerHealth = Player.GetComponent<PlayerHealth>();
        playerHealth.Heal(_healPoint);
    }
}
