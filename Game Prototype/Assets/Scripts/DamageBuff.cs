using UnityEngine;
public class DamageBuff : Buff
{
    [SerializeField] private int _damage;
    protected override void TakeEffect()
    {
        PlayerHealth playerHealth = Player.GetComponent<PlayerHealth>();
        playerHealth.TakeDamage(_damage);
    }
}
