using UnityEngine;
public class HealBuff : Buff
{
    [SerializeField] private int _healPoint;
    protected override void TakeEffect()
    {
        playerHealth.Heal(_healPoint);
    }
}
