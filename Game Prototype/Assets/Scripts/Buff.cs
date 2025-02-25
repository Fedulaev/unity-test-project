using UnityEngine;
[RequireComponent(typeof(BoxCollider2D))]
public class Buff : MonoBehaviour
{
    protected PlayerHealth playerHealth;
    protected PlayerMovement playerMovement;
    protected virtual void TakeEffect() { print("effect"); }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
            playerMovement = collision.gameObject.GetComponent<PlayerMovement>();
            TakeEffect();
        }
    }
}
