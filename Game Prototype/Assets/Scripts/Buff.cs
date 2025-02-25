using UnityEngine;
[RequireComponent(typeof(BoxCollider2D))]
public class Buff : MonoBehaviour
{
    protected GameObject Player;
    protected virtual void TakeEffect() { print("effect"); }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Player = collision.gameObject;
            TakeEffect();
        }
    }
}
