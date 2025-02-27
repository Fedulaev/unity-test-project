using UnityEngine;
public class DamageBuff : Buff
{
    [SerializeField] private int _damage;
    protected override void TakeEffect()
    {
        PlayerHealth playerHealth = _player.GetComponent<PlayerHealth>();
        playerHealth.TakeDamage(_damage);
    }
}
