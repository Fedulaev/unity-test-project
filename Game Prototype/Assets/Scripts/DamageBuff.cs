using UnityEngine;
public class DamageBuff : Buff
{
    [SerializeField] private int _damage;
    protected override void TakeEffect()
    {
        player.TakeDamage(_damage);
    }
}
