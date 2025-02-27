using System.Collections;
using UnityEngine;
[RequireComponent(typeof(BoxCollider2D))]
public class Buff : MonoBehaviour
{
    [SerializeField] private int _refreshDelay;
    protected GameObject _player;
    protected virtual void TakeEffect() => StartCoroutine(Refresh(_refreshDelay));
    private IEnumerator Refresh(int _delay)
    {
        Color startColor = GetComponent<SpriteRenderer>().color;
        ChangeState(new Color(1f, 1f, 1f, 0f), false);
        yield return new WaitForSeconds(_delay);
        ChangeState(startColor, true);
    }
    private void ChangeState(Color _color, bool _isColliderEnabled)
    {
        GetComponent<SpriteRenderer>().color = _color;
        GetComponent<BoxCollider2D>().enabled = _isColliderEnabled;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            _player = collision.gameObject;
            TakeEffect();
        }
    }
}
