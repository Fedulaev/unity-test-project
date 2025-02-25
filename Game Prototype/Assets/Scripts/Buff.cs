using UnityEngine;
[RequireComponent(typeof(BoxCollider2D))]
public class Buff : MonoBehaviour
{
    protected PlayerHealth player;
    protected virtual void TakeEffect() { print("effect"); }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            player = collision.gameObject.GetComponent<PlayerHealth>();
            if (player != null)
                TakeEffect();
        }
    }
}
