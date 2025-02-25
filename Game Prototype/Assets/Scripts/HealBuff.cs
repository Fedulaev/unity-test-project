using UnityEngine;
public class HealBuff : Buff
{
    [SerializeField] private int _healPoint;
    protected override void TakeEffect()
    {
        player.Heal(_healPoint);
    }
}
